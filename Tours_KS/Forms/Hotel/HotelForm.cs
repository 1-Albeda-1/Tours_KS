using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tours_KS.Context.DB;
using Tours_KS.Context.Models;
using Tours_KS.Forms.Hotel;

namespace Tours_KS.Forms
{
    public partial class HotelForm : Form
    {
        private int pageSize = 7;
        private int oldCountPage = -1;
        private readonly BindingSource bindingSource = new BindingSource();

        public HotelForm()
        {
            InitializeComponent();
            bindingSource.CurrentItemChanged += Bs_CurrentItemChanged;
            dataGridView1.AutoGenerateColumns = false;
            Print();
        }

        private void Print()
        {
            using (var db = new ToursContext())
            {
                var count = db.Hotels.Count();
                var countPage = (int)Math.Ceiling((decimal)count / pageSize);

                if (oldCountPage != countPage)
                {
                    oldCountPage = countPage;
                    var current = bindingSource.Position;

                    if (current > countPage)
                    {
                        current = countPage;
                    }

                    bindingSource.DataSource = Enumerable.Range(1, countPage);

                    if (current != -1)
                    {
                        bindingSource.Position = current;
                    }

                    bindingNavigatorHotels.BindingSource = bindingSource;
                }

                dataGridView1.DataSource = db.Hotels.Include(x => x.Country)
                .OrderBy(x => x.Name)
                    .Skip(bindingSource.Position * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
        }

        private void Bs_CurrentItemChanged(object sender, EventArgs e)
        {
            Print();
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {
            using(var db = new ToursContext())
            {
                dataGridView1.DataSource = db.Hotels.Include(x => x.Country).ToList();
            }
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TourForm form = new TourForm();
            this.Hide();
            form.ShowDialog();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HotelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddHotelForm addHotelForm = new AddHotelForm();
            if(addHotelForm.ShowDialog() == DialogResult.OK)
            {
                using(var db = new ToursContext())
                {
                    db.Hotels.Add(addHotelForm.Hotel);
                    db.SaveChanges();
                    Print();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var hotelId = (Tours_KS.Context.Models.Hotel)dataGridView1.SelectedRows[0].DataBoundItem;

            if (hotelId == null)
                return;
            using(var db = new ToursContext())
            {
                var hotel1 = db.Hotels.FirstOrDefault(x => x.Id == hotelId.Id);
                AddHotelForm addHotelForm = new AddHotelForm(hotel1);
                if(addHotelForm.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                    Print();
                }
            }
                
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var hotelId = (Tours_KS.Context.Models.Hotel)dataGridView1.SelectedRows[0].DataBoundItem;

            if (hotelId == null) return;

            using(var db = new ToursContext())
            {
                var hotel1 = db.Hotels.Include(x => x.Tours).FirstOrDefault(x => x.Id == hotelId.Id);
                if (hotel1.Tours.Count(x => x.IsActual) != 0)
                {
                    MessageBox.Show("Этот отель подходит к актуальным турам!!");
                }
                else if (MessageBox.Show($"Удалить ли отель {hotelId.Name}?", "Подтвердите!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.Hotels.Remove(hotel1);
                    db.SaveChanges();
                    Print();
                }
            }
        }
    }
}

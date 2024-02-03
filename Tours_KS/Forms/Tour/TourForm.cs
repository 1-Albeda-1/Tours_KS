using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tours_KS.Context.DB;
using Tours_KS.Context.Models;
using Tours_KS.Forms;
using Tours_KS.Forms.Tour;
using Type = Tours_KS.Context.Models.Type;

namespace Tours_KS
{
    public partial class TourForm : Form
    {
        private decimal allCount = 0;
        public TourForm()
        {
            InitializeComponent();
            comboBoxType.DisplayMember = nameof(Context.Models.Type.Name);
            comboBoxType.ValueMember = nameof(Context.Models.Type.Id);
        }
        private void TourInfo_ImageChanged(object sender, (Tour, byte[]) e)
        {
            using (var db = new ToursContext())
            {
                db.Entry(e.Item1).State = EntityState.Modified;
                e.Item1.ImagePreview = e.Item2;
                db.SaveChanges();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var db = new ToursContext())
            {
                var query = db.Types.OrderBy(x => x.Name);

                comboBoxType.Items.Clear();
                comboBoxType.Items.AddRange(query.ToArray());
                comboBoxType.Items.Insert(0, new Type()
                {
                    Id = -1,
                    Name = "Все типы",
                });

                comboBoxType.SelectedIndex = 0;

                var tours = db.Tours.Include(x => x.Types).ToList();
                allCount = 0;
                foreach (var tour in tours)
                { 
                    var tourInfo = new TourInfo(tour);
                    tourInfo.Parent = flowLayoutPanel1;
                    tourInfo.ImageChanged += TourInfo_ImageChanged;
                    allCount += tour.Price * tour.TicketCount;
                }
            }
            labelAllPrice.Text = allCount.ToString();
        }
        private void Filter()
        {
            if (comboBoxType.SelectedItem == null) return;
            var selectedTypeId = ((Type)comboBoxType.SelectedItem).Id;
            allCount = 0;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var visible = true;
                if (item is TourInfo tourInfo)
                {
                    if (selectedTypeId != -1 &&
                        !tourInfo.Tour.Types.Any(x => x.Id == selectedTypeId))
                    {
                        visible = false;
                    }

                    if (checkBoxActual.Checked && !tourInfo.Tour.IsActual)
                    {
                        visible = false;
                    }

                    if (!(string.IsNullOrEmpty(textBoxSearch.Text) ||
                        tourInfo.Tour.Name.ToLower().Contains(textBoxSearch.Text.ToLower())))
                    {
                        visible = false;
                    }
                    tourInfo.Visible = visible;

                    if(visible)
                    {
                        allCount += tourInfo.Tour.TicketCount * tourInfo.Tour.Price;
                    }
                }
            }
            labelAllPrice.Text = allCount.ToString();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void checkBoxActual_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void отелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelForm form = new HotelForm();
            form.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTourForm addTour = new AddTourForm();

            if (addTour.ShowDialog() == DialogResult.OK)
            {
                using (var db = new ToursContext())
                {
                    var ids = addTour.GetCheckedTypes();
                    addTour.Tour.Types = db.Types.Where(x => ids.Contains(x.Id)).ToList();
                    db.Tours.Add(addTour.Tour);
                    db.SaveChanges();
                }
            }

            var tourInfo = new TourInfo(addTour.Tour);
            tourInfo.Parent = flowLayoutPanel1;
            allCount += tourInfo.Tour.Price * tourInfo.Tour.TicketCount;
            labelAllPrice.Text = allCount.ToString();
        }
    }
}

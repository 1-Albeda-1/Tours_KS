using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tours_KS.Context.DB;
using Tours_KS.Context.Models;
using Tours_KS.Forms.Tour;

namespace Tours_KS
{
    public partial class TourInfo : UserControl
    {
        public Tour tour { get; set; }
        public event Action<Tour> AddToOrder;

        public TourInfo(Tour tour)
        {
            InitializeComponent();
            this.tour = tour;
            InitTour(tour);
        }
        public Tour Tour => tour;
        private void InitTour(Tour tour)
        {
            labelName.Text = tour.Name;
            labelPrice.Text = $"{tour.Price:C2}";
            labelActual.Text = tour.IsActual ? "Актуален" : "Не актуален";
            labelActual.ForeColor = tour.IsActual ? Color.Green : Color.Red;
            labelCount.Text = $"Билетов: {tour.TicketCount.ToString()}";
            if (tour.ImagePreview != null)
            {
                pictureBoxImageTour.Image = Image.FromStream(new MemoryStream(tour.ImagePreview));
            }
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                var image = File.ReadAllBytes(openFileDialog1.FileName);
                using (var db = new ToursContext())
                {
                    tour.ImagePreview = image;
                    db.Entry(tour).State = EntityState.Modified;
                    db.SaveChanges();
                }
                pictureBoxImageTour.Image = Image.FromStream(new MemoryStream(image));
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new ToursContext())
            {
                var tour1 = db.Tours.FirstOrDefault(x => x.Id == tour.Id);
                var form = new AddTourForm(tour1);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var ids = form.GetCheckedTypes();
                    tour1.Types.Clear();
                    tour1.Types = db.Types.Where(x => ids.Contains(x.Id)).ToList();
                    db.SaveChanges();
                    InitTour(tour1);
                }
            }
        }

        private void добавитьКЗаказуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tour.IsActual)
            {
                AddToOrder?.Invoke(tour);
            }
            else
                MessageBox.Show("Данный тур является не актуальным!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tours_KS.Context.DB;
using Tours_KS.Context.Models;

namespace Tours_KS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            using(var db = new ToursContext())
            {
                var tours = db.Tours.Include(nameof(Tour.Types)).ToList();
                foreach(var tour in tours)
                {
                    var tourInfo = new TourInfo(tour);
                    tourInfo.Parent = flowLayoutPanel1;
                    tourInfo.ImageChanged += TourInfo_ImageChanged;
                }
            }
        }
    }
}

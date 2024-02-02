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

namespace Tours_KS.Forms
{
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            using(var db = new ToursContext())
            {
                dataGridView1.DataSource = db.Hotels.Include(x => x.Country).ToList();
            }
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TourForm form = new TourForm();
            form.ShowDialog();
            this.Hide();
        }

    }
}

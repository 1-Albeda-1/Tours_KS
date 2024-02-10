using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tours_KS.Context.DB;
using Tours_KS.Context.Models;

namespace Tours_KS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");//Добавить: , tour.ImagePreview);
            pictureBox1.Image = Image.FromFile(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", Path.GetFileName(openFileDialog1.FileName));
                if(openFileDialog1.FileName != path)
                {
                    File.Copy(openFileDialog1.FileName, path);
                }
                using (var db = new ToursContext())
                {
                    var target = db.Tours.Where(x => x.Id == id).FirstOrDefault();
                    target.ImagePreview = File.ReadAllBytes(path);  //Path.GetFileName(path) если стринг!!;
                    db.SaveChanges();
                }
                pictureBox1.Image = Image.FromFile(path);
            }
            
        }
    }
}

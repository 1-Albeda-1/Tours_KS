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
using Tours_KS.Context.Models;

namespace Tours_KS
{
    public partial class OrderInfo : UserControl
    {
        public Tour Tour;
        public Action CountChange;
        public int Count;

        public OrderInfo(Tour tour, int count)
        {
            InitializeComponent();
            this.Tour = tour;
            Count = count;
            labelName.Text = Tour.Name;
            labelDescription.Text = string.IsNullOrWhiteSpace(Tour.Description) ? "Описание отсутсвует" : Tour.Description;
            labelCountTicket.Text = $"Кол-во билетов: {Tour.TicketCount}";
            labelCountry.Text = $"Страна: {Tour.Country}";
            labelPrice.Text = $"Цена: {Tour.Price} РУБ";
            numericUpDownCount.Value = count;
            listBoxTypeTour.DisplayMember = nameof(Tour.Name);
            listBoxTypeTour.Items.AddRange(Tour.Types.ToArray());
            if(Tour.ImagePreview != null)
            {
                pictureBoxTourImage.Image = Image.FromStream(new MemoryStream(Tour.ImagePreview));
            }
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            Count = (int)numericUpDownCount.Value;
            CountChange?.Invoke();
        }
    }
}

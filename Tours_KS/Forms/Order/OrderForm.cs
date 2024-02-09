using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tours_KS.Context.DB;
using System.Data.Entity;
using Tours_KS.Context.Models;

namespace Tours_KS.Forms.Order
{
    public partial class OrderForm : Form
    {
        private Dictionary<Tours_KS.Context.Models.Tour, int> Tours;
        private decimal allPrice = 0;
        private decimal allSale = 0;

        public OrderForm(Dictionary<Tours_KS.Context.Models.Tour, int> tours)
        {
            InitializeComponent();
            labelFIO.Text = $"{Users.User.LastName} {Users.User.FirstName} {Users.User.Patronymic}";
            Tours = tours;

            foreach (var item in Tours.Keys)
            {
                var orderInfo = new OrderInfo(item, Tours[item]);
                orderInfo.Parent = flowLayoutPanel1;
                orderInfo.CountChange += UpdatePrice;
                allPrice += item.Price * Tours[item];
            }

            toolStripLabelPrice.Text = $"Сумма заказа: {allPrice:C2}";

            using(var db = new ToursContext())
            {
                comboBoxPoint.Items.AddRange(db.ReceivingPoints.ToArray());
                comboBoxPoint.SelectedIndex = 0;
            }
        }
        private void UpdatePrice()
        {
            allPrice = 0;

            foreach (var item in flowLayoutPanel1.Controls)
            {
                if (item is OrderInfo order)
                {
                    allPrice += order.Tour.Price * order.Count;

                    if (Tours.TryGetValue(order.Tour, out var count))
                    {
                        Tours[order.Tour] = order.Count;
                    }
                }
            }
            toolStripLabelPrice.Text = $"Сумма заказа: {allPrice:C2}";
        }

        private void buttonTakeOrder_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var order = new Context.Models.Order
            {
                OrderDate = DateTimeOffset.Now,
                AllSale = 0,
                Price = allPrice,
                OrderCode = random.Next(100, 1000),
                ReceivingPointId = ((ReceivingPoint)comboBoxPoint.SelectedItem).Id
            };

            if(!Users.CompareRole(Role.Guest))
            {
                order.UserId = Users.User.Id;
            }

            using (var db = new ToursContext())
            {
                var Ids = Tours.Keys.Select(x => x.Id).ToList();
                var tours = db.Tours.Include(x => x.Country).Where(x => Ids.Contains(x.Id)).ToList();
                order.Tours = tours;
                db.Orders.Add(order);
                db.SaveChanges();
                MessageBox.Show("Заказ оформлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}


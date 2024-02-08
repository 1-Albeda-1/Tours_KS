using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tours_KS.Context.DB;
using Tours_KS.Context.Models;

namespace Tours_KS.Forms.Hotel
{
    public partial class AddHotelForm : Form
    {
        public Tours_KS.Context.Models.Hotel Hotel { get; set; }
        public AddHotelForm()
        {
            InitializeComponent();
            Hotel = new Tours_KS.Context.Models.Hotel();
            Initialize();
        }
        public AddHotelForm(Tours_KS.Context.Models.Hotel hotel) : this()
        {
            this.Text = "Изменить отель";
            Hotel = hotel;
            textBoxName.Text = hotel.Name;
            textBoxDescription.Text = hotel.Description;
            numericUpDownStarsCount.Value = hotel.CountOfStars;
            comboBoxCountry.SelectedItem = comboBoxCountry.Items.Cast<Country>().FirstOrDefault(x => x.Code == Hotel.CountryCode);

        }
        private void Initialize()
        {
            using(var db = new ToursContext())
            {
                comboBoxCountry.Items.AddRange(db.Countries.AsNoTracking().ToArray());
                comboBoxCountry.SelectedIndex = 0;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBoxName.Text) && !string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                Hotel.Name = textBoxName.Text;
                Hotel.Description = textBoxDescription.Text;
                Hotel.CountOfStars = (int)numericUpDownStarsCount.Value;
                Hotel.CountryCode = ((Country)comboBoxCountry.SelectedItem).Code;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Заполните все поля перед сохранением!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

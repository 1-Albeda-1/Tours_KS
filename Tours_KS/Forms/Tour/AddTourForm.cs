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
using Type = Tours_KS.Context.Models.Type;

namespace Tours_KS.Forms.Tour
{
    public partial class AddTourForm : Form
    {
        public Tours_KS.Context.Models.Tour Tour { get; set; }
        public AddTourForm()
        {
            InitializeComponent();
            comboBoxCountry.DisplayMember = nameof(Country.Name);
            checkedListBoxTypes.DisplayMember = nameof(Type.Name);
            Tour = new Tours_KS.Context.Models.Tour();
            Initialize();
        }
        private void Initialize()
        {
            using (var db = new ToursContext())
            {
                comboBoxCountry.Items.AddRange(db.Countries.AsNoTracking().ToArray());
                comboBoxCountry.SelectedIndex = 0;
                checkedListBoxTypes.Items.AddRange(db.Types.AsNoTracking().ToArray());
            }
        }

        public List<int> GetCheckedTypes()
            => checkedListBoxTypes.CheckedItems.Cast<Type>().Select(x => x.Id).ToList();

        public AddTourForm(Tours_KS.Context.Models.Tour tour) : this()
        {
            this.Text = "Изменить";
            Tour = tour;
            textBoxName.Text = Tour.Name;
            numericUpDownTicketCount.Value = Tour.TicketCount;
            numericUpDownPrice.Value = Tour.Price;

            var ids = Tour.Types.Select(x => x.Id).ToList();
            for (int i = 0; i < checkedListBoxTypes.Items.Count; i++)
            {
                if (ids.Contains(((Type)checkedListBoxTypes.Items[i]).Id))
                {
                    checkedListBoxTypes.SetItemChecked(i, true);
                }
            }

            comboBoxCountry.SelectedItem = comboBoxCountry.Items.Cast<Country>()
                .FirstOrDefault(x => x.Code == Tour.CountryCode);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Tour.Name = textBoxName.Text;
            Tour.Description = textBoxDiscription.Text;
            Tour.CountryCode = ((Country)comboBoxCountry.SelectedItem).Code;
            Tour.TicketCount = (int)numericUpDownTicketCount.Value;
            if(checkBoxActual.Checked)
            {
                Tour.IsActual = true;
            }          
            Tour.Price = numericUpDownPrice.Value;
            DialogResult = DialogResult.OK;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

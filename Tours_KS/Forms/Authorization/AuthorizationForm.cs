using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tours_KS.Context.Models;

namespace Tours_KS.Forms.Authorization
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnterGuest_Click(object sender, EventArgs e)
        {
            Users.User = new User
            {
                LastName = string.Empty,
                FirstName = "Неавторизованный гость",
                Patronymic = string.Empty,
                RoleType = Role.Quest
            };
            TourForm form = new TourForm();
            form.Show();
            this.Hide();
        }
    }
}

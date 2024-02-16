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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tours_KS.Forms.Authorization
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBoxLogin.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                using (var db = new ToursContext())
                {
                    var user = db.Users.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);

                    if (user == null)
                    {
                        MessageBox.Show("Неправильное имя пользователя или пароль!");
                        textBoxPassword.Clear();
                    }
                    else
                    {
                        Users.User = user;
                        TourForm form = new TourForm();
                        form.Show();
                        this.Hide();
                    }
                }
            }
            else
                MessageBox.Show("Заполните все поля перед входом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonEnterGuest_Click(object sender, EventArgs e)
        {
            Users.User = new User
            {
                LastName = string.Empty,
                FirstName = "Неавторизованный гость",
                Patronymic = string.Empty,
                RoleType = Role.Guest
            };
            TourForm form = new TourForm();
            form.Show();
            this.Hide();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

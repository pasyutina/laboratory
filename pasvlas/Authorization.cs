using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasvlas
{
    public partial class FormAuthorization : Form
    {
      public struct User
      {
            public string name;
            public string surname;
            public string login;
        public string password;
        public string type;
      }
        public static User users = new User();

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonVhod_Click(object sender, EventArgs e)
        {
                if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
                {
                    MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                
                bool key = false;
                    foreach (users user in Program.wftDb.users)
                    {
                        if (textBoxLogin.Text == user.login && textBoxPassword.Text == user.password)
                        {
                            key = true;
                            users.name = user.name;
                            users.surname = user.surname;
                            users.login = user.login;
                            users.password = user.password;
                            users.type = user.type.ToString();
                        }
                    }
                    if (!key)
                    {
                        MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxLogin.Text = "";
                        textBoxPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = null;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else textBoxPassword.UseSystemPasswordChar = true;

        }

        private void textBoxLogin_MouseClick(object sender, MouseEventArgs e)
        { 
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void textBoxLogin_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void textBoxLogin_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}

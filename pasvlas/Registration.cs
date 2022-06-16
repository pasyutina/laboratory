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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "")
            { 
                users users = new users();
                users.name = Convert.ToString(textBoxName.Text);
                users.surname = Convert.ToString(textBoxSurname.Text);
                users.login = Convert.ToString(textBoxLogin.Text);
                users.password = Convert.ToString(textBoxPassword.Text);
                users.type = 2;
                Program.wftDb.users.Add(users);
                Program.wftDb.SaveChanges();
                MessageBox.Show("Вы зарегистрировались!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAuthorization auth = new FormAuthorization();
                auth.Show();
                this.Hide();
            }
            else MessageBox.Show("Данные не заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormAuthorization auth = new FormAuthorization();
            auth.Show();
            this.Hide();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}

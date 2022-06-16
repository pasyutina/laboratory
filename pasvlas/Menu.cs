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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            labelHello.Text = "Приветствую тебя, " + FormAuthorization.users.name + " " + FormAuthorization.users.surname;
            if (FormAuthorization.users.type == "1") { labelType.Text = FormAuthorization.users.type = "Администратор"; buttonBio.Enabled = false; }
            else labelType.Text = FormAuthorization.users.type = "Лаборант";
        }

        private void buttonPriem_Click(object sender, EventArgs e)
        {
          
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form service = new Service();
            service.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form authorization = new FormAuthorization();
            authorization.Show();
            this.Hide();
        }

        private void buttonBio_Click(object sender, EventArgs e)
        {
            Form bio = new Biomaterial();
            bio.Show();
            this.Hide();
        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            Form patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void buttonOtchets_Click(object sender, EventArgs e)
        {
            Form otchet = new Otchets();
            otchet.Show();
            this.Hide();
        }
    }
}

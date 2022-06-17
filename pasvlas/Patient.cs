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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            ShowPatient();
        }

        void ShowPatient()
        {
            listViewPatient.Items.Clear();
            foreach (patients patients in Program.wftDb.patients)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                   patients.id.ToString(),
                   patients.name, patients.surname, patients.login, patients.password, patients.date.ToString("dd/MM/yyyy"), patients.pasport, patients.phone_number,
                   patients.email, patients.insurance_policy
                });
                item.Tag = patients;
                listViewPatient.Items.Add(item);
            }
        }
        private void labelCode_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void listViewService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPatient.SelectedItems.Count == 1)
            {
                patients patients = listViewPatient.SelectedItems[0].Tag as patients;
                textBoxName.Text = patients.name;
                textBoxSurname.Text = patients.surname;
                textBoxLogin.Text = patients.login;
                textBoxPass.Text = patients.password;
                dateTimePicker.Value = patients.date;
                textBoxPasport.Text = patients.pasport;
                textBoxPhone.Text = patients.phone_number;
                textBoxEmail.Text = patients.email;
                textBoxStrah.Text = patients.insurance_policy;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxLogin.Text = "";
                textBoxPass.Text = "";
                dateTimePicker.Value = DateTime.Now;
                textBoxPasport.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxStrah.Text = "";
            }
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxLogin.Text != "" && textBoxPass.Text != "" && textBoxPasport.Text != "" &&
                textBoxPhone.MaskCompleted != false && textBoxStrah.Text != "" && textBoxEmail.Text != "")
            {
                patients patients = new patients();
                patients.name = textBoxName.Text;
                patients.surname = textBoxSurname.Text;
                patients.login = textBoxLogin.Text;
                patients.password = textBoxPass.Text;
                patients.date = dateTimePicker.Value;
                patients.pasport = textBoxPasport.Text;
                patients.phone_number = textBoxPhone.Text;
                patients.email = textBoxEmail.Text;
                patients.insurance_policy = textBoxStrah.Text;
                Program.wftDb.patients.Add(patients);
                Program.wftDb.SaveChanges();
                ShowPatient();

            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxLogin.Text != "" && textBoxPass.Text != "" && textBoxPasport.Text != "" &&
               textBoxPhone.MaskCompleted != false && textBoxStrah.Text != "" && textBoxEmail.Text != "")
            {
                if (listViewPatient.SelectedItems.Count == 1)
                {
                    patients patients = listViewPatient.SelectedItems[0].Tag as patients;
                    patients.name = textBoxName.Text;
                    patients.surname = textBoxSurname.Text;
                    patients.login = textBoxLogin.Text;
                    patients.password = textBoxPass.Text;
                    patients.date = dateTimePicker.Value;
                    patients.pasport = textBoxPasport.Text;
                    patients.phone_number = textBoxPhone.Text;
                    patients.email = textBoxEmail.Text;
                    patients.insurance_policy = textBoxStrah.Text;
                    Program.wftDb.SaveChanges();
                    ShowPatient();
                   
                }
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxLogin.Text = "";
                    textBoxPass.Text = "";
                    dateTimePicker.Value = DateTime.Now;
                    textBoxPasport.Text = "";
                    textBoxPhone.Text = "";
                    textBoxEmail.Text = "";
                    textBoxStrah.Text = "";
                
            }
            else
            {
                MessageBox.Show("Невозможно изменить, пустое поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPatient.SelectedItems.Count == 1)
                {
                    patients patients = listViewPatient.SelectedItems[0].Tag as patients;
                    Program.wftDb.patients.Remove(patients);
                    Program.wftDb.SaveChanges();
                    ShowPatient();
                }
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxLogin.Text = "";
                textBoxPass.Text = "";
                dateTimePicker.Value = DateTime.Now;
                textBoxPasport.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxStrah.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
           
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxStrah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

        private void textBoxPasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
                ListViewItem foundItem =
                listViewPatient.FindItemWithText(textBoxSearch.Text, true, 0, true);
            if (foundItem != null )
            {
                listViewPatient.TopItem = foundItem;
                foundItem.BackColor = SystemColors.GrayText;
            }
        }

        private void buttonChar_Click(object sender, EventArgs e)
        {
           
        }
    }
}

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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
            ShowService();
        }

        void ShowService()
        {
            listViewService.Items.Clear();
            foreach (services service in Program.wftDb.services)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    service.id.ToString(),
                   service.code.ToString(), service.service, service.price, service.srok
                });
                item.Tag = service;
                listViewService.Items.Add(item);
            }
        }
        private void Service_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text != "" && textBoxName.Text != "" && textBoxPrice.Text != "" && textBoxSrok.Text != "")
            {
                services service = new services();
                service.code = Convert.ToInt32(textBoxCode.Text);
                service.service = Convert.ToString(textBoxName.Text);
                service.price = Convert.ToString(textBoxPrice.Text);
                service.srok = Convert.ToString(textBoxSrok.Text);
                Program.wftDb.services.Add(service);
                Program.wftDb.SaveChanges();
                ShowService();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text != "" && textBoxName.Text != "" && textBoxPrice.Text != "" && textBoxSrok.Text != "")
            {
                if (listViewService.SelectedItems.Count == 1)
                {
                    services service = listViewService.SelectedItems[0].Tag as services;
                    service.code = Convert.ToInt32(textBoxCode.Text);
                    service.service = textBoxName.Text;
                    service.price = textBoxPrice.Text;
                    service.srok = textBoxSrok.Text;
                    Program.wftDb.SaveChanges();
                    ShowService();
                }
                else
                {
                    textBoxCode.Text = "";
                    textBoxName.Text = "";
                    textBoxPrice.Text = "";
                    textBoxSrok.Text = "";
                }
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
                if (listViewService.SelectedItems.Count == 1)
                {
                    services service = listViewService.SelectedItems[0].Tag as services;
                    Program.wftDb.services.Remove(service);
                    Program.wftDb.SaveChanges();
                    ShowService();
                }
                textBoxCode.Text = "";
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxSrok.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewService.SelectedItems.Count == 1)
            {
                services service = listViewService.SelectedItems[0].Tag as services;
                textBoxCode.Text = service.code.ToString();
                textBoxName.Text = service.service;
                textBoxPrice.Text = service.price.ToString();
                textBoxSrok.Text = service.srok.ToString();
            }
            else
            {
                textBoxCode.Text = "";
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxSrok.Text = "";
            }
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonChar_Click(object sender, EventArgs e)
        {
            Hyi hui = new Hyi();
            hui.Show();
            this.Hide();
        }
    }
}

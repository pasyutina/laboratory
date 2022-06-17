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
    public partial class ChartService : Form
    {
        public ChartService()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.chart.Series[0].Points.Clear();
           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string x = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                string y = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                chart.Series[0].Points.AddXY(x, y);
            }

        }

        private void chart_Click(object sender, EventArgs e)
        {
           
        }

        private void Hyi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "podgotovkaDataSet.services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.podgotovkaDataSet.services);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form services = new Service();
            services.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.AddForms
{
    public partial class AddPublisher : Form
    {
        public AddPublisher()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void foxBigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPublisher_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void PopulateDataGridView()
        {
            Random random = new Random();

            // Define columns
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");

            // Add rows with random data
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add(
                    random.Next(100),   // Random integer for Column1
                    random.NextDouble() // Random double for Column2
                );
            }
        }
    }
}

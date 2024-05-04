using DBMidProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProjectDB1.Forms.AddForms
{
    public partial class AddAuthor : Form
    {
        public int AdminID;
        public AddAuthor(int adminuserid)
        {
            InitializeComponent();
            AdminID = adminuserid;
            label4.Text = AdminID.ToString();

            ShowAuthors();
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {
            string firstname = fname.Text;
            string lastname = lname.Text;
            string nationality = auNationality.Text;
            DateTime dateofbirth = date.Value;
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(nationality))
            {
                MessageBox.Show("Please Fill all the required fields");
            }
            else
            {
                BL.Admin admin = new BL.Admin();
                admin.AddAuthor(firstname, lastname, AdminID, dateofbirth, nationality,1);
                ShowAuthors();
            }


        }

        private void ShowAuthors()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName,Nationality,DateOfBirth FROM Author WHERE Status = 1 ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    fname.Text = row.Cells["FirstName"].Value?.ToString();
                    lname.Text = row.Cells["LastName"].Value?.ToString();
                    auNationality.Text = row.Cells["Nationality"].Value?.ToString();
                    if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dateValue))
                    {
                        date.Value = dateValue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
    }
}

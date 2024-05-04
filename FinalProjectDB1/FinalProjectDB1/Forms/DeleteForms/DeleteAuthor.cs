using DBMidProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.DeleteForms
{
    public partial class DeleteAuthor : Form
    {
        string firstname;
        string lastname;
        string nationality;
        DateTime dateOFB;
        public DeleteAuthor()
        {
            InitializeComponent();
            ShowAuthors();
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fname.Text) || string.IsNullOrEmpty(lname.Text) || string.IsNullOrEmpty(auNationality.Text))
            {
                MessageBox.Show("Please Fill all the required fields");
            }
            else
            {
                string firstname = fname.Text;
                string lastname = lname.Text;
                string nationality = auNationality.Text;
                DateTime dateofbirth = date.Value;
                int id = findID();
                MessageBox.Show(id.ToString());
                BL.Admin admin = new BL.Admin();
                admin.DeleteAuthor(firstname, lastname, id, dateofbirth, nationality,0);
                ShowAuthors();
            }
        }
        private int findID()
        {

            int id = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT AuthorID FROM Author WHERE  FirstName = @FirstName AND LastName = @LastName AND Nationality = @Nationality AND DateOfBirth = @DateOfBirth", con);
                cmd.Parameters.AddWithValue("@FirstName", firstname);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                cmd.Parameters.AddWithValue("@Nationality", nationality);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOFB);
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
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
                    firstname = fname.Text;
                    lastname = lname.Text;
                    nationality = auNationality.Text;
                    dateOFB = date.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
    }
}

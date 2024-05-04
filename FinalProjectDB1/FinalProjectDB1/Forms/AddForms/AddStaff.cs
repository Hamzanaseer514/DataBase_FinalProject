using DBMidProject;
using FinalProjectDB1.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mail;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.AddForms
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
            ShowStaff();
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {
            string Fname = textBox1.Text;
            string lname = textBox2.Text;
            string email = textBox3.Text;
            string password = textBox4.Text;
            string contact = textBox8.Text;
            string city = textBox5.Text;
            float Salary;
            if (!float.TryParse(textBox6.Text, out Salary) || Salary < 0)
            {
                MessageBox.Show("Please enter a valid non-negative number for salary.");
                return;
            }
            string Designation = comboBoxEdit2.Text;
            long cnic;
            string emailPattern = @"^\S+@gmail\.com";
            string usertype = "Staff";
            DateTime date = DateTime.Now;
            if (string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(contact) ||
                string.IsNullOrEmpty(comboBoxEdit2.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }



            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid Gmail address @gmail.com .");

            }
            else if (contact.Length != 11 || !contact.StartsWith("03"))
            {
                MessageBox.Show("Invalid contact number. Please enter a valid 11-digit contact number starting with '03'.");
            }
            else if (!long.TryParse(textBox7.Text, out cnic) || textBox7.Text.Length != 13 || !long.TryParse(textBox7.Text, out cnic))
            {
                MessageBox.Show("Invalid CNIC. Please enter a valid 14-digit CNIC number.");
            }

            

            else
            {
                bool exist = alreadyExist();
                if (!exist)
                {

                    Admin admin = new Admin();
                    admin.AddStaff(Fname, lname, email, password, contact, cnic, city, usertype, Designation, Salary,1);
                    ShowStaff();
                }
                else
                {
                    MessageBox.Show("Staff Already Exist");
                }

            }
        }
        private void ShowStaff()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select u.FirstName, u.LastName,u.Email,u.Password, u.Contact,u.CNIC,u.City,s.Salary,s.Designation  from Staff as s JOIN [user] as u on s.UserID = u.UserID WHERE s.Status = 1", con);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                    textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                    textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
                    textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
                    textBox8.Text = dataGridView1.SelectedRows[0].Cells[4].Value?.ToString();
                    textBox7.Text = dataGridView1.SelectedRows[0].Cells[5].Value?.ToString();
                    textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    textBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    comboBoxEdit2.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool alreadyExist()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [User]  WHERE Contact = @Contact OR Email = @Email OR CNIC = @CNIC", con);
            cmd.Parameters.AddWithValue("@Contact", textBox8.Text);
            cmd.Parameters.AddWithValue("@Email", textBox3.Text);
            cmd.Parameters.AddWithValue("@CNIC", textBox7.Text);

            int id = (int)cmd.ExecuteScalar();
            MessageBox.Show(id.ToString());
            if (id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

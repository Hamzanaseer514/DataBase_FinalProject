using DBMidProject;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using FinalProjectDB1.BL;

namespace FinalProjectDB1.Forms.DeleteForms
{
    public partial class DeleteStaff : Form
    {
        string ufname;
        string ulname;
        string ucontact;
        long ucnic;
        string uemail;
        string udesignation;
        float usalary;
        string upass;
        public DeleteStaff()
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
            string Designation = comboBoxEdit2.Text;
            long cnic;
            string emailPattern = @"^\S+@gmail\.com";
            float Salary;
            if (!float.TryParse(textBox6.Text, out Salary) || Salary < 0)
            {
                MessageBox.Show("Please enter a valid non-negative number for salary.");
                return;
            }

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

            else if (!((int.TryParse(textBox6.Text, out int intSalary) && intSalary >= 0) || (float.TryParse(textBox6.Text, out float floatSalary) && floatSalary >= 0)))
            {
                MessageBox.Show("Invalid salary. Please enter a valid non-negative number for salary.");
            }

            else
            {
                // bool exist = alreadyExist();
                // if (!exist)
                // {
                int id = findID();
                Admin admin = new Admin();
                admin.DeleteStaff(Fname, lname, email, password, contact, cnic, city, usertype, Designation, Salary, id, 0);
                ShowStaff();
                //  }
                //  else
                //  {
                //      MessageBox.Show("Staff Already Exist");
                //  }

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

                    ufname = textBox1.Text;
                    ulname = textBox2.Text;
                    uemail = textBox3.Text;
                    upass = textBox4.Text;
                    ucnic = long.Parse(textBox7.Text);
                    ucontact = textBox8.Text;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int findID()
        {

            int id = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT UserID From [User] WHERE FirstName = @FirstName AND LastName = @LastName AND Email = @Email AND Contact = @Contact AND CNIC = @CNIC AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@FirstName", ufname);
                cmd.Parameters.AddWithValue("@LastName", ulname);
                cmd.Parameters.AddWithValue("@Contact", ucontact);
                cmd.Parameters.AddWithValue("@Email", uemail);
                cmd.Parameters.AddWithValue("@CNIC", ucnic);
                cmd.Parameters.AddWithValue("@Password", upass);
                id = (int)cmd.ExecuteScalar();
                MessageBox.Show(id.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }
    }
}

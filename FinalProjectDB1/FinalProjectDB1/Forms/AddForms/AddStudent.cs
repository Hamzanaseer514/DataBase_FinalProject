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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Mail;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.AddForms
{

    public partial class AddStudent : Form
    {
        int activeStatus;
        public AddStudent()
        {
            InitializeComponent();
            ShowStudent();
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {

        }

        private void ShowStudent()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select s.RegistrationNo, u.FirstName, u.LastName,u.Email,u.Password, u.Contact,s.Department,s.Semester,u.CNIC, CASE WHEN Status = 1 THEN 'Active' WHEN Status = 2 THEN 'InActive' END AS Status,u.City, StudentShip_StartDate from student as s JOIN [user] as u on s.UserID = u.UserID ", con);
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
                    uregno.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                    firstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                    lastname.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
                    stemail.Text = dataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
                    upassword.Text = dataGridView1.SelectedRows[0].Cells[4].Value?.ToString();
                    ucontact.Text = dataGridView1.SelectedRows[0].Cells[5].Value?.ToString();
                    stdepart.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    stsemester.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    ucnic.Text = dataGridView1.SelectedRows[0].Cells[8].Value?.ToString();
                    ucity.Text = dataGridView1.SelectedRows[0].Cells[10].Value?.ToString();
                    astatus.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void royalButton1_Click_1(object sender, EventArgs e)
        {
            string Fname = firstname.Text;
            string lname = lastname.Text;
            string email = stemail.Text;
            string password = upassword.Text;
            string contact = ucontact.Text;
            string city = ucity.Text;
            string regno = uregno.Text;
            string department = stdepart.Text;
            int semester = int.Parse(stsemester.Text);
            long cnic;
            string emailPattern = @"^\S+@gmail\.com";
            string registrationPattern = @"^20\d{2}-[A-Z]{2}-.+$";
            string status = astatus.Text;
            if (status == "Active")
            {
                activeStatus = 1;
            }
            else if (status == "InActive")
            {
                activeStatus = 2;
            }
            string usertype = "Student";
            DateTime date = DateTime.Now;
            if (string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(contact) ||
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(regno) || string.IsNullOrEmpty(department) ||
                string.IsNullOrEmpty(stsemester.Text) || string.IsNullOrEmpty(ucnic.Text) || string.IsNullOrEmpty(astatus.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            else if (!int.TryParse(stsemester.Text, out semester))
            {
                MessageBox.Show("Invalid semester value. Please enter a valid integer value.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(uregno.Text, registrationPattern))
            {
                MessageBox.Show("Please enter a valid Registration Number in the format 20XX-YY-XX.");
                return;
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(stemail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid Gmail address @gmail.com .");

            }
            else if (contact.Length != 11 || !contact.StartsWith("03"))
            {
                MessageBox.Show("Invalid contact number. Please enter a valid 11-digit contact number starting with '03'.");
            }
            else if (!long.TryParse(ucnic.Text, out cnic) || ucnic.Text.Length != 13 || !long.TryParse(ucnic.Text, out cnic))
            {
                MessageBox.Show("Invalid CNIC. Please enter a valid 14-digit CNIC number.");
            }



            else
            {
                bool exist = alreadyExist();
                if (!exist)
                {

                    Admin admin = new Admin();
                    admin.AddStudent(Fname, lname, email, password, contact, cnic, city, usertype, regno, department, semester, activeStatus, date);
                    ShowStudent();
                }
                else
                {
                    MessageBox.Show("Student Already Exist");
                }

            }
        }

        private bool alreadyExist()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [User]  WHERE  FirstName = @FirstName OR LastName = @LastName OR Contact = @Contact OR Email = @Email AND Password = @Password OR CNIC = @CNIC", con);
            cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
            cmd.Parameters.AddWithValue("@LastName", lastname.Text);
            cmd.Parameters.AddWithValue("@Contact", ucontact.Text);
            cmd.Parameters.AddWithValue("@Email", stemail.Text);
            cmd.Parameters.AddWithValue("@CNIC", ucnic.Text);
            cmd.Parameters.AddWithValue("@Password", upassword.Text);

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

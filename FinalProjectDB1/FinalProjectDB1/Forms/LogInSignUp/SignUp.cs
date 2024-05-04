using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.LogInSignUp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount();
        }

        private void CreateAccount()
        {
            string Fname = firstname.Text;
            string lname = lastname.Text;
            string email = stemail.Text;
            string password = upassword.Text;
            string repass = ReenterPass.Text;
            string contact = ucontact.Text;
            string city = ucity.Text;
            string regno = uregno.Text;
            string department = stdepartment.Text;
            int ssemester = int.Parse(stsemester.Text);
            long cnic;
            string usertype = "Student";
            DateTime date = DateTime.Now;
            if (string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repass) || string.IsNullOrEmpty(contact) ||
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(regno) || string.IsNullOrEmpty(department) ||
                string.IsNullOrEmpty(stsemester.Text) || string.IsNullOrEmpty(ucnic.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            else if (!int.TryParse(stsemester.Text, out ssemester))
            {
                MessageBox.Show("Invalid semester value. Please enter a valid integer value.");
            }
            else if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Please enter a valid Gmail address.");
            }
            else if (!long.TryParse(ucnic.Text, out cnic) || ucnic.Text.Length != 13 || !long.TryParse(ucnic.Text, out cnic))
            {
                MessageBox.Show("Invalid CNIC. Please enter a valid 14-digit CNIC number.");
            }
            else if (!Regex.IsMatch(uregno.Text, @"^\d{4}-[a-zA-Z]{2}-\d{2}$"))
            {
                MessageBox.Show("Invalid registration number. Please enter a valid registration number in the format 2XXX-XX-XXX.");
            }
            else if (contact.Length != 11 || !contact.StartsWith("03"))
            {
                MessageBox.Show("Invalid contact number. Please enter a valid 11-digit contact number starting with '03'.");
            }
            else if (password != repass)
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.");
            }
            else if (!termAcceptCheckbox.Checked)
            {
                MessageBox.Show("Please accept the terms and conditions before proceeding.");
            }
            else
            {
                BL.Student student = new BL.Student(Fname,lname,email,password,contact,cnic,city,usertype, regno,department,ssemester,1,date);
                student.SignUp();
            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignIn login = new SignIn();
            this.Hide();
            login.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}

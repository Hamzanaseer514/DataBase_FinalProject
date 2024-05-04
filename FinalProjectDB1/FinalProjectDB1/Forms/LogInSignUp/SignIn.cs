using DBMidProject;
using FinalProjectDB1.BL;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProjectDB1.Forms.LogInSignUp
{
    public partial class SignIn : Form
    {
        int adminUserId = 0;
        public SignIn()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Forms.LogInSignUp.SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bool validation = Validate();
            if (validation)
            {

                string email = logEmail.Text;
                string password = logpassword.Text;
                Student st = new Student();
                string userType = st.signIn(email, password);
                adminUserId = getID(email, password);
                if (userType == "Student")
                {
                    MessageBox.Show("Welcome to Student Menu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (userType == "Admin")
                {
                    MessageBox.Show("Welcome to Admin Menu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(adminUserId.ToString());
                    Form1 f = new Form1(adminUserId);
                    f.Show();
                    this.Hide();
                }
                else if (userType == "Staff")
                {
                    MessageBox.Show("Welcome to Staff Menu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forms.Staff_Section.StaffMenu staffmenu = new Staff_Section.StaffMenu();
                    this.Hide();
                    staffmenu.Show();
                }
                else if (userType == null)
                {
                    MessageBox.Show("Login Failed, No Credentials Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(logEmail.Text) || string.IsNullOrEmpty(logpassword.Text))
            {
                MessageBox.Show("Please enter both email and password.");
                return false;
            }
            return true;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                logpassword.UseSystemPasswordChar = false;
            }
            else
            {
                logpassword.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        public int getID(string email, string password)
        {
            int userId = -1; // Initialize userId with a default value
            try
            {
                var con = Configuration.getInstance().getConnection();
                string query = "SELECT UserId FROM [User] WHERE Email = @Email AND Password = @Password";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                // Execute the command and get the UserId
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return userId;

        }

     
    }
}


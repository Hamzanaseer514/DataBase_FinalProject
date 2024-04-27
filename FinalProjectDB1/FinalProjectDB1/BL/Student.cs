using DBMidProject;
using FinalProjectDB1.Forms.LogInSignUp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FinalProjectDB1.BL
{
    internal class Student : User
    {
        public string RegistrationNo { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }
        public int Status { get; set; }
        public DateTime StudentShip_StartDate { get; set; }

        public Student() : base()
        {

        }

        // Parameterized constructor
        public Student(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string registrationNo, string department, int semester, int status, DateTime studentShip_StartDate)
            : base(firstName, lastName, email, password, contact, cnic, city, usertype)
        {
            RegistrationNo = registrationNo;
            Department = department;
            Semester = semester;
            Status = status;
            StudentShip_StartDate = studentShip_StartDate;
        }

        public void SignUp()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                string userInsertQuery = "INSERT INTO [User] (FirstName, LastName, Email, Passsword, Contact, CNIC, City, UserType) " +
                             "VALUES (@FirstName, @LastName, @Email, @Password, @Contact, @CNIC, @City,@UserType); SELECT SCOPE_IDENTITY()";
                SqlCommand userCommand = new SqlCommand(userInsertQuery, con);
                userCommand.Parameters.AddWithValue("@FirstName", FirstName);
                userCommand.Parameters.AddWithValue("@LastName", LastName);
                userCommand.Parameters.AddWithValue("@Email", Email);
                userCommand.Parameters.AddWithValue("@Password", Password);
                userCommand.Parameters.AddWithValue("@Contact", Contact);
                userCommand.Parameters.AddWithValue("@CNIC", CNIC);
                userCommand.Parameters.AddWithValue("@City", City);
                userCommand.Parameters.AddWithValue("@UserType", UserType);
                int userId = Convert.ToInt32(userCommand.ExecuteScalar());
                string studentInsertQuery = "INSERT INTO Student (UserID, RegistrationNo, Department, Semester, Status, StudentShip_StartDate) " +
                                            "VALUES (@UserID, @RegistrationNo, @Department, @Semester, @Status, @StudentShip_StartDate)";
                SqlCommand studentCommand = new SqlCommand(studentInsertQuery, con);
                studentCommand.Parameters.AddWithValue("@UserID", userId);
                studentCommand.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
                studentCommand.Parameters.AddWithValue("@Department", Department);
                studentCommand.Parameters.AddWithValue("@Semester", Semester);
                studentCommand.Parameters.AddWithValue("@Status", Status);
                studentCommand.Parameters.AddWithValue("@StudentShip_StartDate", StudentShip_StartDate);
                studentCommand.ExecuteNonQuery();
                MessageBox.Show("Student signed up successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        public string signIn(string email, string password)
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                string query = "SELECT * FROM [User] WHERE Email = @Email AND Passsword = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Check if a row was returned
                    {
                        string userType = reader["Usertype"].ToString();
                        int userid = (int)reader["UserID"];
                        return userType;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
          return  null;
        }

    }
}

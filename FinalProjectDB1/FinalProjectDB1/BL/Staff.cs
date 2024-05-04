using DBMidProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProjectDB1.BL
{
    internal class Staff : User
    {
        public string Designation { get; set; }
        public float Salary { get; set; }

        public int UserID { get; set; }

        public int Status { get; set; }

        public Staff(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string designation, float salary,int status)
            : base(firstName, lastName, email, password, contact, cnic, city, usertype)
        {
            Designation = designation;
            Salary = salary;
            Status = status;
        }

        public Staff(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string designation, float salary, int id,int status)
            : base(firstName, lastName, email, password, contact, cnic, city, usertype)
        {
            Designation = designation;
            Salary = salary;
            UserID = id;
            Status = status;
        }

        public void AddStaffInDataBase()
        {
            SqlTransaction transaction = null;

            try
            {

                var con = Configuration.getInstance().getConnection();
                transaction = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand("AddStaff", con, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@CNIC", CNIC);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@UserType", UserType);
                cmd.Parameters.AddWithValue("@Designation", Designation);
                cmd.Parameters.AddWithValue("@Salary", Salary);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Staff Added successfully");

            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void UpdateStaffInDataBase()
        {
            SqlTransaction transaction = null;
            try
            {

                var con = Configuration.getInstance().getConnection();
                transaction = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand("UpdateStaff", con, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@CNIC", CNIC);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@Designation", Designation);
                cmd.Parameters.AddWithValue("@Salary", Salary);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Staff Updated successfully");

            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        public void RemoveStaffFromDataBase()
        {
           
            try
            {

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Update Staff SET Status = @Status WHERE UserID = @UserID AND Designation = @Designation", con);
                cmd.Parameters.AddWithValue("@Designation", Designation);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Deleted successfully");
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}

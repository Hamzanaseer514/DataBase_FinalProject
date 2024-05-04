using DBMidProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace FinalProjectDB1.BL
{
    internal class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        int Status { get; set; }

        public int UserID { get; set; }

        public Author() { 
        }

        public Author(string firstName, string lastName,int userId, DateTime dateOfBirth, string nationality,int status)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
            UserID = userId;
            Status = status;
        }
      
        public void addAuthorInDatabase()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                string userInsertQuery = "INSERT INTO Author( UserID,FirstName, LastName, Nationality, DateOfBirth,Status) " +
                               "VALUES (@UserID, @FirstName, @LastName, @Nationality, @DateOfBirth,@Status);  SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(userInsertQuery, con);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@Nationality", Nationality);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Authors added Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void UpdateAuthorInDatabase()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();

                string updateQuery = "UPDATE Author SET FirstName = @FirstName, LastName = @LastName, Nationality = @Nationality, DateOfBirth = @DateOfBirth WHERE AuthorID = @AuthorID";

                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Nationality", Nationality);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@AuthorID", UserID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Authors Updated Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void DeleteAuthorInDatabase()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();

                string updateQuery = "UPDATE  Author SET Status = @Status WHERE AuthorID = @AuthorID";

                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Nationality", Nationality);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@AuthorID", UserID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Authors Deleted Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

using DBMidProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.BL
{
    internal class Category
    {
        private string CategoryName;
        private int UserID;

        public Category(string categoryname, int userid)
        {
            this.CategoryName = categoryname;
            this.UserID = userid;
        }
        public void addCategoryInDatabase()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                string userInsertQuery = "INSERT INTO Category( UserID,CategoryName) " +
                               "VALUES (@UserID, @CategoryName);  SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(userInsertQuery, con);
                cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void removeCategoryInDatabase()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();

                string deleteQuery = "DELETE FROM Category WHERE CategoryID = @CategoryID";

                SqlCommand cmd = new SqlCommand(deleteQuery, con);
                cmd.Parameters.AddWithValue("@CategoryID", UserID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}

using DBMidProject;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.BL
{
    internal class Location
    {
        public int ShelfNo { get; set; }
        public int Capacity { get; set; }
        public int UserID { get; set; }

        public Location(int shelfNo, int capacity, int userID)
        {
            ShelfNo = shelfNo;
            Capacity = capacity;
            UserID = userID;
        }
        public void addLocationInDatabase()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                string query = "INSERT INTO Location (ShelfNo, Capacity,UserID) VALUES (@ShelfNo, @Capacity,@UserID)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ShelfNo", ShelfNo);
                cmd.Parameters.AddWithValue("@Capacity", Capacity);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Location added Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void DeleteLocationInDatabase()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                string query = "DELETE FROM location Where LocationID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ShelfNo", ShelfNo);
                cmd.Parameters.AddWithValue("@Capacity", Capacity);
                cmd.Parameters.AddWithValue("@ID", UserID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Location Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }



        }
    }
}

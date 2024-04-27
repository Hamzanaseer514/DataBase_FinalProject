using DBMidProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.BL
{
    internal class Publisher
    {
        public string PublisherName { get; set; }
        public string PublicationType { get; set; }
        public string PublicationLanguage { get; set; }
        public string PublisherAddress { get; set; }

        public int UserID { get; set; }

        // Constructor
        public Publisher(string publisherName, string publicationType, string publicationLanguage,int userid, string publisherAddress)
        {
            PublisherName = publisherName;
            PublicationType = publicationType;
            PublicationLanguage = publicationLanguage;
            PublisherAddress = publisherAddress;
            UserID = userid;
        }
        public void addPublisherInDatabase()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("AddPublisher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PublisherName", PublisherName);
                cmd.Parameters.AddWithValue("@PublicationType", PublicationType);
                cmd.Parameters.AddWithValue("@PublicationLanguage", PublicationLanguage);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@PublisherAddress", PublisherAddress);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Publisher added Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.AddForms
{
    public partial class AddPublisher : Form
    {
        private int userid;
        public AddPublisher(int userid)
        {
            InitializeComponent();
            PopulateDataGridView();
            this.userid = userid;
        }

        private void foxBigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPublisher_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void PopulateDataGridView()
        {
            // Define book publishers
            string[] publishers = { "Publisher A", "Publisher B", "Publisher C", "Publisher D" };

            // Define languages
            string[] languages = { "English", "Spanish", "French", "German" };

            // Define book types
            string[] bookTypes = { "Ebook", "Hardbook" };

            // Define columns
            dataGridView1.Columns.Add("Column1", "ID");
            dataGridView1.Columns.Add("Column2", "Publisher Name");
            dataGridView1.Columns.Add("Column3", "Language");
            dataGridView1.Columns.Add("Column4", "Type");

            // Generate and shuffle IDs
            List<int> uniqueIDs = Enumerable.Range(1, 10).ToList();
            Shuffle(uniqueIDs);

            // Add rows with shuffled IDs and corresponding publisher information
            foreach (int id in uniqueIDs)
            {
                string publisherName = publishers[id % publishers.Length]; // Cycling through publishers
                string language = languages[id % languages.Length]; // Cycling through languages
                string type = bookTypes[id % 2]; // Cycling between Ebook and Hardbook

                dataGridView1.Rows.Add(
                    id,   // Book ID
                    publisherName,  // Publisher Name
                    language,       // Language
                    type            // Book Type
                );
            }
        }

        // Helper method to shuffle a list
        private void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {
            string publishername = pname.Text;
            string publishertype = ptype.Text;
            string publisherlanguage = planguage.Text;
            string publisherAdress = pAdress.Text;

            if (string.IsNullOrWhiteSpace(publishername) || string.IsNullOrWhiteSpace(publishertype) || string.IsNullOrWhiteSpace(publisherlanguage) || string.IsNullOrWhiteSpace(publisherAdress))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BL.Admin admin = new BL.Admin();
                admin.AddPublisher(publishername,publishertype,publisherlanguage,userid, publisherAdress);
            }
        }
    }
}

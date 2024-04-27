using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.UpdateForms
{
    public partial class UpdateCategory : Form
    {
        public UpdateCategory()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void PopulateDataGridView()
        {
            // Define book categories
            Dictionary<int, string> bookCategories = new Dictionary<int, string>()
    {
        { 1, "Fiction" },
        { 2, "Non-fiction" },
        { 3, "Science Fiction" },
        { 4, "Mystery" },
        // Add more categories as needed
    };

            // Define columns
            dataGridView1.Columns.Add("Column1", "ID");
            dataGridView1.Columns.Add("Column2", "Category");

            // Add rows with sequential IDs and corresponding categories
            for (int id = 1; id <= 4; id++)
            {
                string category = bookCategories[id]; // Get category for the book ID

                dataGridView1.Rows.Add(
                    id,   // Book ID
                    category  // Book category
                );
            }
        }

    }
}

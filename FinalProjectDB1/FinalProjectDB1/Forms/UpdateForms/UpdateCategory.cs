using DBMidProject;
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
using System.Xml.Linq;

namespace FinalProjectDB1.Forms.UpdateForms
{
    public partial class UpdateCategory : Form
    {
        string categoryname;
        public UpdateCategory()
        {
            InitializeComponent();
            ShowCategory();

        }

       

        private void royalButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cname.Text))
            {
                MessageBox.Show("Please Fill all the required fields");
            }
            else
            {
                string catname = cname.Text;
                int id = findID();
                MessageBox.Show(id.ToString());
                BL.Admin admin = new BL.Admin();
             //   admin.UpdateCategory(id,catname);
                ShowCategory();
            }
        }
        private void ShowCategory()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Category ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    cname.Text = row.Cells["CategoryName"].Value?.ToString();
                    
                    categoryname = cname.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
        private int findID()
        {

            int id = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT CategoryID FROM Category WHERE  CategoryName = @CategoryName", con);
                cmd.Parameters.AddWithValue("@CategoryName", categoryname);
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }


    }
}

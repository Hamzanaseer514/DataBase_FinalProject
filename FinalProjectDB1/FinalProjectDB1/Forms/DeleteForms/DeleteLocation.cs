using DBMidProject;
using FinalProjectDB1.BL;
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

namespace FinalProjectDB1.Forms.DeleteForms
{
    public partial class DeleteLocation : Form
    {
        int shelfnumber;
        int capacity;
        public DeleteLocation()
        {
            InitializeComponent();
            ShowLocation();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    sShelf.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                    sCapacity.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                    shelfnumber = int.Parse(sShelf.Text);
                    capacity = int.Parse(sCapacity.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowLocation()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT ShelfNo,Capacity FROM Location ", con);
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
        private int findID()
        {

            int id = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT LocationID FROM Location WHERE  ShelfNo = @ShelfNo AND Capacity = @Capacity", con);
                cmd.Parameters.AddWithValue("@ShelfNo", shelfnumber);
                cmd.Parameters.AddWithValue("@Capacity", capacity);
                id = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sShelf.Text) || string.IsNullOrWhiteSpace(sCapacity.Text))
            {
                MessageBox.Show("Please fill in both Shelf No and Capacity fields.");
            }
            else
            {
                if (int.TryParse(sShelf.Text, out int shelfNo) && int.TryParse(sCapacity.Text, out int ccapacity))
                {
                    int id = findID();
                    BL.Admin admin = new BL.Admin();
                    admin.UpdateLocation(shelfNo, ccapacity, id);
                    ShowLocation();
                }
                else
                {
                    MessageBox.Show("Please enter valid integers for Shelf No and Capacity.");
                }
            }
        }

        private void DeleteLocation_Load(object sender, EventArgs e)
        {
            ShowLocation();
        }
    }
}

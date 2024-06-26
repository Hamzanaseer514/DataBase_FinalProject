﻿using DBMidProject;
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

namespace FinalProjectDB1.Forms.DashBoard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            showTotalStudent();
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("select s.RegistrationNo, u.FirstName, u.LastName,u.Email, u.Contact,s.Department,s.Semester,u.CNIC, CASE WHEN Status = 1 THEN 'Active' WHEN Status = 2 THEN 'InActive' END AS Status from student as s JOIN [user] as u on s.UserID = u.UserID ", con);
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

        private void royalButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void showTotalStudent()
        {
            var con = Configuration.getInstance().getConnection();
            string countQuery = "SELECT COUNT(*) FROM Student";
            SqlCommand cmd = new SqlCommand(countQuery, con);
            int totalStudents = Convert.ToInt32(cmd.ExecuteScalar());
            std.Text = totalStudents.ToString();
        }
    }
}

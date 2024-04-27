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
    public partial class AddAuthor : Form
    {
        public int AdminID;
        public AddAuthor(int adminuserid)
        {
            InitializeComponent();
            AdminID = adminuserid; 
            label4.Text = AdminID.ToString();
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {
            string firstname = fname.Text;
            string lastname = lname.Text;
            string nationality = auNationality.Text;
            DateTime dateofbirth = date.Value;
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(nationality))
            {
                MessageBox.Show("Please Fill all the required fields");
            }
            else
            {
                BL.Admin admin = new BL.Admin();
                admin.AddAuthor(firstname, lastname,AdminID,dateofbirth, nationality);
            }


        }
    }
}

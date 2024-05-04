using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB1.Forms.Student_Section
{
    public partial class StudentMenu : Form
    {
        BookRequest BookReq;
        ViewIssueBook IssBook;
        ViewBook ViewB;
        PayFine PFine;
        ViewPayedFine ViewPF;
        Review R;
        public StudentMenu()
        {
            InitializeComponent();
            //Add Midcontainer right
            this.IsMdiContainer = true;
        }
        /* Use for Side Bar*/
        bool sidebarexpand = false;

        private void Sidemenu_Btn_Click(object sender, EventArgs e)
        {
            sidemenutimer.Start();
        }

        private void sidemenutimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                sidebar.Width -= 15;
                if (sidebar.Width <= 46)
                {
                    sidebarexpand = false;
                    sidemenutimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 15;
                if (sidebar.Width >= 237)
                {
                    sidebarexpand = true;
                    sidemenutimer.Stop();
                }
            }
        }

        private void BookRequest_Btn_Click(object sender, EventArgs e)
        {

        }

        private void ViewIssueBook_Btn_Click(object sender, EventArgs e)
        {

        }

        private void ViewBook_Btn_Click(object sender, EventArgs e)
        {

        }

        private void PayFine_Btn_Click(object sender, EventArgs e)
        {

        }

        private void ViewPayedFine_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Review_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}

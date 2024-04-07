using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace FinalProjectDB1
{
    public partial class Form1 : Form
    {
        DashboardForm dashboard;
        AddStudent Astudent;
        UpdateStudent UStudent;
        DeleteStudent DStudent;


        AddAdmincs AAdmin;
        UpdateAdmin UAdmin;
        DeleteAdmin DAdmin;


        AddStaff AStaff;
        UpdateStaff UStaff;
        DeleteStaff DStaff;


        Forms.AddForms.AddCategory ACat;
        UpdateCategory UCat;
        DeleteCategory DCat;


        Forms.AddForms.AddPublisher APub;
        UpdatePublisher7 UPub;
        DeletePublisher DPub;

        AddBook ABook;
        UpdateBook UBook;
        DeleteBook DBook;


        AddAuthor AAuthor;
        UpdateAuthor UAuthor;
        DeleteAuthor DAuthor;

        public Form1()
        {
           
            InitializeComponent();
            MdiProp();
        }

        /* Use for Student Menue*/ bool meueExpand = false;
        /* Use for Staff Menue*/ bool meueExpand1 = false;
        /* Use for Admin Menue*/ bool meueExpand2 = false;
        /* Use for Book Menue*/bool meueExpand3 = false;
        /* Use for Publisher Menue*/ bool meueExpand4 = false;
        /* Use for Category Menue*/bool meueExpand5 = false;
        /* Use for  Author Menue*/ bool meueExpand6 = false;
        /* Use for Side Bar*/ bool sidebarexpand = false;

        //These are used in form movemenet Events
        bool Dragging;
        Point DragCursorPoint;
        Point DragFormPoint;

       

        //Student Menue Bar
        private void MenuTransistion_Tick(object sender, EventArgs e)
        {
            if(meueExpand==false) {
                studentmenu.Height += 10;
                if(studentmenu.Height >= 215) 
                { 
                    MenuTransistion.Stop();
                    meueExpand = true;
                }

            }
            else
            {
                studentmenu.Height -= 10;
                if(studentmenu.Height <= 52)
                {
                    MenuTransistion.Stop();
                    meueExpand = false;
                }
            }
        }

        private void ManageStudentBtn_Click(object sender, EventArgs e)
        {
            MenuTransistion.Start();
        }
        // End of Student Menu Bar

        //Start of Staff Menu Bar
        private void stafftimer_Tick(object sender, EventArgs e)
        {
            if (meueExpand1 == false)
            {
                staffmenu.Height += 10;
                if (staffmenu.Height >= 215)
                {
                    stafftimer.Stop();
                    meueExpand1 = true;
                }

            }
            else
            {
                staffmenu.Height -= 10;
                if (staffmenu.Height <= 52)
                {
                    stafftimer.Stop();
                    meueExpand1 = false;
                }
            }
        }

        private void ManageStaffBtn_Click(object sender, EventArgs e)
        {
            stafftimer.Start();
        }
        //End of staff Menu Bar

        //Start of admin Menu Bar

        private void admintimer_Tick(object sender, EventArgs e)
        {
            if (meueExpand2 == false)
            {
                Adminmenu.Height += 10;
                if (Adminmenu.Height >= 215)
                {
                    admintimer.Stop();
                    meueExpand2 = true;
                }

            }
            else
            {
                Adminmenu.Height -= 10;
                if (Adminmenu.Height <= 52)
                {
                    admintimer.Stop();
                    meueExpand2 = false;
                }
            }

        }

        private void ManageAdminBtn_Click(object sender, EventArgs e)
        {
            admintimer.Start();
        }

        // End of admin bar

        //Start of Book menu
        private void Booktimer_Tick(object sender, EventArgs e)
        {
            if (meueExpand3 == false)
            {
                Bookmenu.Height += 10;
                if (Bookmenu.Height >= 215)
                {
                    Booktimer.Stop();
                    meueExpand3 = true;
                }

            }
            else
            {
               Bookmenu.Height -= 10;
                if (Bookmenu.Height <= 52)
                {
                    Booktimer.Stop();
                    meueExpand3 = false;
                }
            }

        }

        private void Bookmenubtn_Click(object sender, EventArgs e)
        {
            Booktimer.Start();
        }
        // End of Book menu

        //Start of Publisher Menu

        private void Publishertimer_Tick(object sender, EventArgs e)
        {
            if (meueExpand4 == false)
            {
                Publishermenu.Height += 10;
                if (Publishermenu.Height >= 215)
                {
                    Publishertimer.Stop();
                    meueExpand4 = true;
                }

            }
            else
            {
                Publishermenu.Height -= 10;
                if (Publishermenu.Height <= 52)
                {
                    Publishertimer.Stop();
                    meueExpand4 = false;
                }
            }
        }

        private void Publishermenubtn_Click(object sender, EventArgs e)
        {
            Publishertimer.Start();
        }


        // End of Publisher Menu
        // Start of Category Menu
        private void Categorytimer_Tick(object sender, EventArgs e)
        {
            if (meueExpand5 == false)
            {
                Categorymenu.Height += 10;
                if (Categorymenu.Height >= 215)
                {
                    Categorytimer.Stop();
                    meueExpand5 = true;
                }

            }
            else
            {
                Categorymenu.Height -= 10;
                if (Categorymenu.Height <= 52)
                {
                    Categorytimer.Stop();
                    meueExpand5 = false;
                }
            }
        }


        private void Categorymenubtn_Click(object sender, EventArgs e)
        {
            Categorytimer.Start();
        }
        // End of Catgory Menu
        // Start of Author menu

        private void Authortimer_Tick(object sender, EventArgs e)
        {
            if (meueExpand6 == false)
            {
                Authormenu.Height += 10;
                if (Authormenu.Height >= 215)
                {
                    Authortimer.Stop();
                    meueExpand6 = true;
                }

            }
            else
            {
                Authormenu.Height -= 10;
                if (Authormenu.Height <= 52)
                {
                    Authortimer.Stop();
                    meueExpand6 = false;
                }
            }

        }

        private void Authormenubtn_Click(object sender, EventArgs e)
        {
            Authortimer.Start();
        }
        // End of Author menu




        // Side bar control code start

        private void sidemenutimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                sidebar.Width -= 15;
                if (sidebar.Width <= 46)
                {
                    sidebarexpand = false;
                    Inventory.Visible = false;
                    sidemenutimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 15;
                if (sidebar.Width >= 237)
                {
                    sidebarexpand = true;
                    Inventory.Visible = true;
                    sidemenutimer.Stop();
                }
            }
        }

        private void Sidemenu_Click(object sender, EventArgs e)
        {
            
            sidemenutimer.Start();
        }
        // Side bar control code End

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState=FormWindowState.Normal;
                this.StartPosition=FormStartPosition.CenterParent;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        // This Events are used for Form movement 

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursorPoint=Cursor.Position;
            DragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Dragging)
            {
                Point Dif = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                this.Location = Point.Add(DragFormPoint, new Size(Dif));
            }
        }
        // End of this events


        private void Dashbutton_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new DashboardForm();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;    
                dashboard.Show();

            }
            else
            {
                dashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void AddStd_Btn_Click(object sender, EventArgs e)
        {
            if (Astudent == null)
            {
                Astudent = new AddStudent();
                Astudent.FormClosed += AddStudent_FormClosed;
                Astudent.MdiParent = this;
                Astudent.Dock = DockStyle.Fill;
                Astudent.Show();

            }
            else
            {
                Astudent.Activate();
            }
        }

        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Astudent.Activate();
        }

        private void UpdateStd_Btn_Click(object sender, EventArgs e)
        {
            if (UStudent == null)
            {
                UStudent = new UpdateStudent();
                UStudent.FormClosed += UpdateStudent_FormClosed;
                UStudent.MdiParent = this;
                UStudent.Dock = DockStyle.Fill;
                UStudent.Show();

            }
            else
            {
                UStudent.Activate();
            }

        }

        private void UpdateStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            UStudent.Activate();
        }

        private void DeleteStd_Btn_Click(object sender, EventArgs e)
        {
            if (DStudent == null)
            {
                DStudent = new DeleteStudent();
                DStudent.FormClosed += DeleteStudent_FormClosed;
                DStudent.MdiParent = this;
                DStudent.Dock = DockStyle.Fill;
                DStudent.Show();

            }
            else
            {
                DStudent.Activate();
            }
        }

        private void DeleteStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            DStudent.Activate();
        }

        private void AddAdmin_Btn_Click(object sender, EventArgs e)
        {
            if (AAdmin == null)
            {
                AAdmin = new AddAdmincs();
                AAdmin.FormClosed += AddAdmincs_FormClosed;
                AAdmin.MdiParent = this;
                AAdmin.Dock = DockStyle.Fill;
                AAdmin.Show();

            }
            else
            {
                AAdmin.Activate();
            }

        }

        private void AddAdmincs_FormClosed(object sender, FormClosedEventArgs e)
        {
            AAdmin.Activate();
        }

        private void UpdateAdmin_Btn_Click(object sender, EventArgs e)
        {
            if (UAdmin == null)
            {
                UAdmin = new UpdateAdmin();
                UAdmin.FormClosed += UpdateAdmin_FormClosed;
                UAdmin.MdiParent = this;
                UAdmin.Dock = DockStyle.Fill;
                UAdmin.Show();

            }
            else
            {
                UAdmin.Activate();
            }

        }

        private void UpdateAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            UAdmin.Activate();
        }

        private void DeleteAdmin_Click(object sender, EventArgs e)
        {
            if (DAdmin == null)
            {
                DAdmin = new DeleteAdmin();
                DAdmin.FormClosed += DeleteAdmin_FormClosed;
                DAdmin.MdiParent = this;
                DAdmin.Dock = DockStyle.Fill;
                DAdmin.Show();

            }
            else
            {
                DAdmin.Activate();
            }
        }

        private void DeleteAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            DAdmin.Activate(); 
        }

        private void AddStaff_Btn_Click(object sender, EventArgs e)
        {
            if (AStaff == null)
            {
                AStaff = new AddStaff();
                AStaff.FormClosed += AddStaff_FormClosed;
                AStaff.MdiParent = this;
                AStaff.Dock = DockStyle.Fill;
                AStaff.Show();

            }
            else
            {
                AStaff.Activate();
            }

        }

        private void AddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            AStaff.Activate();
        }

        private void UpdateStaff_Btn_Click(object sender, EventArgs e)
        {
            if (UStaff == null)
            {
                UStaff = new UpdateStaff();
                UStaff.FormClosed += UpdateStaff_FormClosed;
                UStaff.MdiParent = this;
                UStaff.Dock = DockStyle.Fill;
                UStaff.Show();

            }
            else
            {
                UStaff.Activate();
            }

        }

        private void UpdateStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            UStaff.Activate();
        }

        private void DeleteStaff_Btn_Click(object sender, EventArgs e)
        {
            if (DStaff == null)
            {
                DStaff = new DeleteStaff();
                DStaff.FormClosed += DeleteStaff_FormClosed;
                DStaff.MdiParent = this;
                DStaff.Dock = DockStyle.Fill;
                DStaff.Show();

            }
            else
            {
                DStaff.Activate();
            }


        }

        private void DeleteStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            DStaff.Activate();
        }

        private void AddCategory_Btn_Click(object sender, EventArgs e)
        {
            if (ACat == null)
            {
                ACat = new Forms.AddForms.AddCategory();
                ACat.FormClosed += AddCategory_FormClosed;
                ACat.MdiParent = this;
                ACat.Dock = DockStyle.Fill;
                ACat.Show();

            }
            else
            {
                ACat.Activate();
            }
        }

        private void AddCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ACat.Activate();
        }

        private void UpdateCategory_Btn_Click(object sender, EventArgs e)
        {
            if (UCat == null)
            {
                UCat = new UpdateCategory();
                UCat.FormClosed += UpdateCategory_FormClosed;
                UCat.MdiParent = this;
                UCat.Dock = DockStyle.Fill;
                UCat.Show();

            }
            else
            {
                UCat.Activate();
            }
        }

        private void UpdateCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            UCat.Activate();
        }

        private void DeleteCategory_Btn_Click(object sender, EventArgs e)
        {
            if (DCat == null)
            {
                DCat = new DeleteCategory();
                DCat.FormClosed += DeleteCategory_FormClosed;
                DCat.MdiParent = this;
                DCat.Dock = DockStyle.Fill;
                DCat.Show();

            }
            else
            {
                DCat.Activate();
            }
        }

        private void DeleteCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            DCat.Activate();
        }

        private void AddPublisher_Btn_Click(object sender, EventArgs e)
        {
            if (APub == null)
            {
                APub = new Forms.AddForms.AddPublisher();
                APub.FormClosed += AddPublisher_FormClosed;
                APub.MdiParent = this;
                APub.Dock = DockStyle.Fill;
                APub.Show();

            }
            else
            {
                APub.Activate();
            }

        }

        private void AddPublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            APub.Activate();
        }

        private void UpdatePublisher_Btn_Click(object sender, EventArgs e)
        {
            if (UPub == null)
            {
                UPub = new UpdatePublisher7();
                UPub.FormClosed += UpdatePublisher_FormClosed;
                UPub.MdiParent = this;
                UPub.Dock = DockStyle.Fill;
                UPub.Show();

            }
            else
            {
                UPub.Activate();
            }

        }

        private void UpdatePublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            UPub.Activate();
        }

        private void DeletePublisher_Click(object sender, EventArgs e)
        {
            if (DPub == null)
            {
                DPub = new DeletePublisher();
                DPub.FormClosed += DeletePublisher_FormClosed;
                DPub.MdiParent = this;
                DPub.Dock = DockStyle.Fill;
                DPub.Show();

            }
            else
            {
                DPub.Activate();
            }

        }

        private void DeletePublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            DPub.Activate();
        }

        private void AddBook_Btn_Click(object sender, EventArgs e)
        {
            if (ABook == null)
            {
                ABook = new AddBook();
                ABook.FormClosed += AddBook_FormClosed;
                ABook.MdiParent = this;
                ABook.Dock = DockStyle.Fill;
                ABook.Show();

            }
            else
            {
                ABook.Activate();
            }

        }

        private void AddBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            ABook.Activate();
        }

        private void UpdateBook_Btn_Click(object sender, EventArgs e)
        {
            if (UBook == null)
            {
                UBook = new UpdateBook();
                UBook.FormClosed += UpdateBook_FormClosed;
                UBook.MdiParent = this;
                UBook.Dock = DockStyle.Fill;
                UBook.Show();

            }
            else
            {
                UBook.Activate();
            }

        }

        private void UpdateBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            UBook.Activate();
        }

        private void DeleteBook_Btn_Click(object sender, EventArgs e)
        {
            if (DBook == null)
            {
                DBook = new DeleteBook();
                DBook.FormClosed += DeleteBook_FormClosed;
                DBook.MdiParent = this;
                DBook.Dock = DockStyle.Fill;
                DBook.Show();

            }
            else
            {
                DBook.Activate();
            }
        }

        private void DeleteBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBook.Activate();
        }

        private void AddAuthor_Btn_Click(object sender, EventArgs e)
        {
            if (AAuthor == null)
            {
                AAuthor = new AddAuthor();
                AAuthor.FormClosed += AddAuthor_FormClosed;
                AAuthor.MdiParent = this;
                AAuthor.Dock = DockStyle.Fill;
                AAuthor.Show();

            }
            else
            {
                AAuthor.Activate();
            }

        }

        private void AddAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            AAuthor.Activate();
        }

        private void UpdateAuthor_Btn_Click(object sender, EventArgs e)
        {
            if (UAuthor == null)
            {
                UAuthor = new UpdateAuthor();
                UAuthor.FormClosed += UpdateAuthor_FormClosed;
                UAuthor.MdiParent = this;
                UAuthor.Dock = DockStyle.Fill;
                UAuthor.Show();

            }
            else
            {
                UAuthor.Activate();
            }
        }

        private void UpdateAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            UAuthor.Activate();
        }

        private void DeleteAuthor_Btn_Click(object sender, EventArgs e)
        {
            if (DAuthor == null)
            {
                DAuthor = new DeleteAuthor();
                DAuthor.FormClosed += DeleteAuthor_FormClosed;
                DAuthor.MdiParent = this;
                DAuthor.Dock = DockStyle.Fill;
                DAuthor.Show();

            }
            else
            {
                DAuthor.Activate();
            }

        }

        private void DeleteAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            DAuthor.Activate();
        }


        private void MdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
    }



}


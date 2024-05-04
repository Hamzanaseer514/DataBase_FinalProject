namespace FinalProjectDB1.Forms.Staff_Section
{
    partial class StaffMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMenu));
            this.sidemenutimer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.BookIssuance_Btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CheckBookRequest_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BorrowedBook_Btn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.FileHandling_Btn = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AccountSetting_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminshowbtn = new System.Windows.Forms.Label();
            this.Sidemenu_Btn = new System.Windows.Forms.PictureBox();
            this.controlBox1 = new ReaLTaiizor.ControlBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.skyLabel10 = new ReaLTaiizor.SkyLabel();
            this.panel34 = new ReaLTaiizor.Panel();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sidemenu_Btn)).BeginInit();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel34.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidemenutimer
            // 
            this.sidemenutimer.Interval = 3;
            this.sidemenutimer.Tick += new System.EventHandler(this.sidemenutimer_Tick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BookIssuance_Btn);
            this.panel5.Location = new System.Drawing.Point(0, 256);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 64);
            this.panel5.TabIndex = 5;
            // 
            // BookIssuance_Btn
            // 
            this.BookIssuance_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.BookIssuance_Btn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssuance_Btn.ForeColor = System.Drawing.Color.White;
            this.BookIssuance_Btn.Image = ((System.Drawing.Image)(resources.GetObject("BookIssuance_Btn.Image")));
            this.BookIssuance_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookIssuance_Btn.Location = new System.Drawing.Point(-16, -17);
            this.BookIssuance_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.BookIssuance_Btn.Name = "BookIssuance_Btn";
            this.BookIssuance_Btn.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.BookIssuance_Btn.Size = new System.Drawing.Size(355, 97);
            this.BookIssuance_Btn.TabIndex = 4;
            this.BookIssuance_Btn.Text = "Books Issuance";
            this.BookIssuance_Btn.UseVisualStyleBackColor = false;
            this.BookIssuance_Btn.Click += new System.EventHandler(this.BookIssuance_Btn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CheckBookRequest_Btn);
            this.panel4.Location = new System.Drawing.Point(0, 192);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 64);
            this.panel4.TabIndex = 5;
            // 
            // CheckBookRequest_Btn
            // 
            this.CheckBookRequest_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.CheckBookRequest_Btn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBookRequest_Btn.ForeColor = System.Drawing.Color.White;
            this.CheckBookRequest_Btn.Image = ((System.Drawing.Image)(resources.GetObject("CheckBookRequest_Btn.Image")));
            this.CheckBookRequest_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckBookRequest_Btn.Location = new System.Drawing.Point(-15, -17);
            this.CheckBookRequest_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBookRequest_Btn.Name = "CheckBookRequest_Btn";
            this.CheckBookRequest_Btn.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.CheckBookRequest_Btn.Size = new System.Drawing.Size(355, 97);
            this.CheckBookRequest_Btn.TabIndex = 4;
            this.CheckBookRequest_Btn.Text = "Check Book Requests";
            this.CheckBookRequest_Btn.UseVisualStyleBackColor = false;
            this.CheckBookRequest_Btn.Click += new System.EventHandler(this.CheckBookRequest_Btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BorrowedBook_Btn);
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 64);
            this.panel2.TabIndex = 5;
            // 
            // BorrowedBook_Btn
            // 
            this.BorrowedBook_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.BorrowedBook_Btn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowedBook_Btn.ForeColor = System.Drawing.Color.White;
            this.BorrowedBook_Btn.Image = ((System.Drawing.Image)(resources.GetObject("BorrowedBook_Btn.Image")));
            this.BorrowedBook_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowedBook_Btn.Location = new System.Drawing.Point(-16, -17);
            this.BorrowedBook_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.BorrowedBook_Btn.Name = "BorrowedBook_Btn";
            this.BorrowedBook_Btn.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.BorrowedBook_Btn.Size = new System.Drawing.Size(355, 97);
            this.BorrowedBook_Btn.TabIndex = 4;
            this.BorrowedBook_Btn.Text = "Browse Borrowed Books";
            this.BorrowedBook_Btn.UseVisualStyleBackColor = false;
            this.BorrowedBook_Btn.Click += new System.EventHandler(this.BorrowedBook_Btn_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.FileHandling_Btn);
            this.panel7.Location = new System.Drawing.Point(0, 64);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 64);
            this.panel7.TabIndex = 5;
            // 
            // FileHandling_Btn
            // 
            this.FileHandling_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.FileHandling_Btn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileHandling_Btn.ForeColor = System.Drawing.Color.White;
            this.FileHandling_Btn.Image = ((System.Drawing.Image)(resources.GetObject("FileHandling_Btn.Image")));
            this.FileHandling_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileHandling_Btn.Location = new System.Drawing.Point(-16, -17);
            this.FileHandling_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.FileHandling_Btn.Name = "FileHandling_Btn";
            this.FileHandling_Btn.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.FileHandling_Btn.Size = new System.Drawing.Size(355, 97);
            this.FileHandling_Btn.TabIndex = 4;
            this.FileHandling_Btn.Text = "Fine Handling";
            this.FileHandling_Btn.UseVisualStyleBackColor = false;
            this.FileHandling_Btn.Click += new System.EventHandler(this.FileHandling_Btn_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 31);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(61, 678);
            this.sidebar.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AccountSetting_Btn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 64);
            this.panel3.TabIndex = 3;
            // 
            // AccountSetting_Btn
            // 
            this.AccountSetting_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.AccountSetting_Btn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountSetting_Btn.ForeColor = System.Drawing.Color.White;
            this.AccountSetting_Btn.Image = ((System.Drawing.Image)(resources.GetObject("AccountSetting_Btn.Image")));
            this.AccountSetting_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountSetting_Btn.Location = new System.Drawing.Point(-16, -17);
            this.AccountSetting_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.AccountSetting_Btn.Name = "AccountSetting_Btn";
            this.AccountSetting_Btn.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.AccountSetting_Btn.Size = new System.Drawing.Size(355, 97);
            this.AccountSetting_Btn.TabIndex = 4;
            this.AccountSetting_Btn.Text = "Account Setting";
            this.AccountSetting_Btn.UseVisualStyleBackColor = false;
            this.AccountSetting_Btn.Click += new System.EventHandler(this.AccountSetting_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "National Library   |";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.adminshowbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Sidemenu_Btn);
            this.panel1.Controls.Add(this.controlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 31);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // adminshowbtn
            // 
            this.adminshowbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminshowbtn.AutoSize = true;
            this.adminshowbtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminshowbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.adminshowbtn.Image = ((System.Drawing.Image)(resources.GetObject("adminshowbtn.Image")));
            this.adminshowbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminshowbtn.Location = new System.Drawing.Point(898, 1);
            this.adminshowbtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 0);
            this.adminshowbtn.Name = "adminshowbtn";
            this.adminshowbtn.Padding = new System.Windows.Forms.Padding(4, 6, 0, 0);
            this.adminshowbtn.Size = new System.Drawing.Size(133, 26);
            this.adminshowbtn.TabIndex = 12;
            this.adminshowbtn.Text = "          Staff Menu";
            // 
            // Sidemenu_Btn
            // 
            this.Sidemenu_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Sidemenu_Btn.Image")));
            this.Sidemenu_Btn.Location = new System.Drawing.Point(-11, 1);
            this.Sidemenu_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Sidemenu_Btn.Name = "Sidemenu_Btn";
            this.Sidemenu_Btn.Size = new System.Drawing.Size(72, 30);
            this.Sidemenu_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sidemenu_Btn.TabIndex = 1;
            this.Sidemenu_Btn.TabStop = false;
            this.Sidemenu_Btn.Click += new System.EventHandler(this.Sidemenu_Btn_Click);
            // 
            // controlBox1
            // 
            this.controlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.controlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBox1.DefaultLocation = true;
            this.controlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBox1.EnableHoverHighlight = true;
            this.controlBox1.EnableMaximizeButton = true;
            this.controlBox1.EnableMinimizeButton = true;
            this.controlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.controlBox1.Location = new System.Drawing.Point(1090, 0);
            this.controlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.controlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.controlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(90, 25);
            this.controlBox1.TabIndex = 19;
            this.controlBox1.Text = "controlBox1";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel11.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.skyLabel10, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(411, 1);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(304, 63);
            this.tableLayoutPanel11.TabIndex = 16;
            // 
            // skyLabel10
            // 
            this.skyLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skyLabel10.AutoSize = true;
            this.skyLabel10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel10.ForeColor = System.Drawing.Color.White;
            this.skyLabel10.Location = new System.Drawing.Point(43, 24);
            this.skyLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skyLabel10.Name = "skyLabel10";
            this.skyLabel10.Size = new System.Drawing.Size(217, 15);
            this.skyLabel10.TabIndex = 13;
            this.skyLabel10.Text = "COPYRIGHT c All Right Reserved";
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.panel34.Controls.Add(this.tableLayoutPanel11);
            this.panel34.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel34.Location = new System.Drawing.Point(61, 648);
            this.panel34.Margin = new System.Windows.Forms.Padding(4);
            this.panel34.Name = "panel34";
            this.panel34.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel34.Size = new System.Drawing.Size(1119, 61);
            this.panel34.TabIndex = 19;
            this.panel34.Text = "panel34";
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1180, 709);
            this.ControlBox = false;
            this.Controls.Add(this.panel34);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffMenu";
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sidemenu_Btn)).EndInit();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.panel34.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidemenutimer;
        private System.Windows.Forms.Button BookIssuance_Btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CheckBookRequest_Btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BorrowedBook_Btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FileHandling_Btn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AccountSetting_Btn;
        private System.Windows.Forms.Label adminshowbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Sidemenu_Btn;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.ControlBox controlBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private ReaLTaiizor.SkyLabel skyLabel10;
        private ReaLTaiizor.Panel panel34;
    }
}
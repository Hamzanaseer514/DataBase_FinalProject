namespace FinalProjectDB1.Forms.DeleteForms
{
    partial class DeleteStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foxBigLabel1 = new ReaLTaiizor.FoxBigLabel();
            this.lastname = new Guna.UI.WinForms.GunaLineTextBox();
            this.firstname = new Guna.UI.WinForms.GunaLineTextBox();
            this.stdepart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.royalButton1 = new ReaLTaiizor.RoyalButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.stsemester = new ReaLTaiizor.ComboBoxEdit();
            this.astatus = new ReaLTaiizor.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uregno = new Guna.UI.WinForms.GunaLineTextBox();
            this.stemail = new Guna.UI.WinForms.GunaLineTextBox();
            this.upassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.ucontact = new Guna.UI.WinForms.GunaLineTextBox();
            this.ucnic = new Guna.UI.WinForms.GunaLineTextBox();
            this.ucity = new Guna.UI.WinForms.GunaLineTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 199);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // foxBigLabel1
            // 
            this.foxBigLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxBigLabel1.ForeColor = System.Drawing.Color.Teal;
            this.foxBigLabel1.Line = ReaLTaiizor.FoxBigLabel.Direction.Bottom;
            this.foxBigLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.foxBigLabel1.Location = new System.Drawing.Point(2, 9);
            this.foxBigLabel1.Name = "foxBigLabel1";
            this.foxBigLabel1.Size = new System.Drawing.Size(364, 52);
            this.foxBigLabel1.TabIndex = 28;
            this.foxBigLabel1.Text = "DELETE STUDENT";
            // 
            // lastname
            // 
            this.lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lastname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastname.LineColor = System.Drawing.Color.Gainsboro;
            this.lastname.Location = new System.Drawing.Point(263, 75);
            this.lastname.Name = "lastname";
            this.lastname.PasswordChar = '\0';
            this.lastname.SelectedText = "";
            this.lastname.Size = new System.Drawing.Size(254, 30);
            this.lastname.TabIndex = 57;
            // 
            // firstname
            // 
            this.firstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.firstname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstname.LineColor = System.Drawing.Color.Gainsboro;
            this.firstname.Location = new System.Drawing.Point(263, 15);
            this.firstname.Name = "firstname";
            this.firstname.PasswordChar = '\0';
            this.firstname.SelectedText = "";
            this.firstname.Size = new System.Drawing.Size(254, 30);
            this.firstname.TabIndex = 27;
            // 
            // stdepart
            // 
            this.stdepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stdepart.FormattingEnabled = true;
            this.stdepart.Items.AddRange(new object[] {
            "Computer Science",
            "Computer Engineering",
            "Electrical Engineering",
            "Mechanical Engineering",
            "Civil Engineering",
            "Chemical Engineering",
            "Biomedical Engineering",
            "Environmental Engineering",
            "Industrial Engineering",
            "Materials Science and Engineering",
            "Nuclear Engineering",
            "Petroleum Engineering",
            "Software Engineering",
            "Information Technology",
            "Robotics Engineering",
            "Systems Engineering",
            "Biotechnology",
            "Telecommunication Engineering",
            "Architecture",
            "Urban Planning"});
            this.stdepart.Location = new System.Drawing.Point(783, 198);
            this.stdepart.Name = "stdepart";
            this.stdepart.Size = new System.Drawing.Size(256, 24);
            this.stdepart.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "First Name";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(4, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label9.Size = new System.Drawing.Size(133, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(4, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label10.Size = new System.Drawing.Size(183, 30);
            this.label10.TabIndex = 25;
            this.label10.Text = "Registration No";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(524, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Size = new System.Drawing.Size(76, 30);
            this.label3.TabIndex = 36;
            this.label3.Text = "CNIC";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(524, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Size = new System.Drawing.Size(142, 30);
            this.label5.TabIndex = 38;
            this.label5.Text = "Department";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(4, 255);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label11.Size = new System.Drawing.Size(122, 30);
            this.label11.TabIndex = 31;
            this.label11.Text = "Password";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(4, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label7.Size = new System.Drawing.Size(79, 30);
            this.label7.TabIndex = 51;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(524, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label6.Size = new System.Drawing.Size(60, 30);
            this.label6.TabIndex = 48;
            this.label6.Text = "City";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(524, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Contact";
            // 
            // royalButton1
            // 
            this.royalButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.royalButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.royalButton1.BorderColor = System.Drawing.Color.Transparent;
            this.royalButton1.BorderThickness = 3;
            this.royalButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.royalButton1.DrawBorder = true;
            this.royalButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.royalButton1.ForeColor = System.Drawing.Color.White;
            this.royalButton1.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.royalButton1.Image = null;
            this.royalButton1.LayoutFlags = ReaLTaiizor.RoyalLayoutFlags.ImageBeforeText;
            this.royalButton1.Location = new System.Drawing.Point(911, 310);
            this.royalButton1.Name = "royalButton1";
            this.royalButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.royalButton1.PressedForeColor = System.Drawing.Color.Black;
            this.royalButton1.Size = new System.Drawing.Size(128, 44);
            this.royalButton1.TabIndex = 16;
            this.royalButton1.Text = "DELETE";
            this.royalButton1.Click += new System.EventHandler(this.royalButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lastname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.firstname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.stdepart, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.royalButton1, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.stsemester, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.astatus, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.uregno, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.stemail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.upassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ucontact, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucnic, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucity, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 284);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 364);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(524, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label8.Size = new System.Drawing.Size(120, 30);
            this.label8.TabIndex = 53;
            this.label8.Text = "Semester";
            // 
            // stsemester
            // 
            this.stsemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stsemester.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.stsemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stsemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.stsemester.DropDownHeight = 100;
            this.stsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.stsemester.FormattingEnabled = true;
            this.stsemester.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.stsemester.IntegralHeight = false;
            this.stsemester.ItemHeight = 20;
            this.stsemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.stsemester.Location = new System.Drawing.Point(784, 257);
            this.stsemester.Margin = new System.Windows.Forms.Padding(4);
            this.stsemester.Name = "stsemester";
            this.stsemester.Size = new System.Drawing.Size(254, 26);
            this.stsemester.StartIndex = 0;
            this.stsemester.TabIndex = 54;
            // 
            // astatus
            // 
            this.astatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.astatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.astatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.astatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.astatus.DropDownHeight = 100;
            this.astatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.astatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.astatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.astatus.FormattingEnabled = true;
            this.astatus.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.astatus.IntegralHeight = false;
            this.astatus.ItemHeight = 20;
            this.astatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.astatus.Location = new System.Drawing.Point(264, 319);
            this.astatus.Margin = new System.Windows.Forms.Padding(4);
            this.astatus.Name = "astatus";
            this.astatus.Size = new System.Drawing.Size(252, 26);
            this.astatus.StartIndex = 0;
            this.astatus.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(524, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label4.Size = new System.Drawing.Size(6, 30);
            this.label4.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(4, 317);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label12.Size = new System.Drawing.Size(198, 30);
            this.label12.TabIndex = 55;
            this.label12.Text = "Activation Status";
            // 
            // uregno
            // 
            this.uregno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uregno.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uregno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uregno.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.uregno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uregno.LineColor = System.Drawing.Color.Gainsboro;
            this.uregno.Location = new System.Drawing.Point(263, 135);
            this.uregno.Name = "uregno";
            this.uregno.PasswordChar = '\0';
            this.uregno.SelectedText = "";
            this.uregno.Size = new System.Drawing.Size(254, 30);
            this.uregno.TabIndex = 57;
            // 
            // stemail
            // 
            this.stemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stemail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.stemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stemail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.stemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stemail.LineColor = System.Drawing.Color.Gainsboro;
            this.stemail.Location = new System.Drawing.Point(263, 195);
            this.stemail.Name = "stemail";
            this.stemail.PasswordChar = '\0';
            this.stemail.SelectedText = "";
            this.stemail.Size = new System.Drawing.Size(254, 30);
            this.stemail.TabIndex = 57;
            // 
            // upassword
            // 
            this.upassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.upassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.upassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.upassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.upassword.LineColor = System.Drawing.Color.Gainsboro;
            this.upassword.Location = new System.Drawing.Point(263, 255);
            this.upassword.Name = "upassword";
            this.upassword.PasswordChar = '\0';
            this.upassword.SelectedText = "";
            this.upassword.Size = new System.Drawing.Size(254, 30);
            this.upassword.TabIndex = 57;
            // 
            // ucontact
            // 
            this.ucontact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ucontact.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ucontact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucontact.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ucontact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucontact.LineColor = System.Drawing.Color.Gainsboro;
            this.ucontact.Location = new System.Drawing.Point(783, 15);
            this.ucontact.Name = "ucontact";
            this.ucontact.PasswordChar = '\0';
            this.ucontact.SelectedText = "";
            this.ucontact.Size = new System.Drawing.Size(256, 30);
            this.ucontact.TabIndex = 57;
            // 
            // ucnic
            // 
            this.ucnic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ucnic.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ucnic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucnic.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ucnic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucnic.LineColor = System.Drawing.Color.Gainsboro;
            this.ucnic.Location = new System.Drawing.Point(783, 75);
            this.ucnic.Name = "ucnic";
            this.ucnic.PasswordChar = '\0';
            this.ucnic.SelectedText = "";
            this.ucnic.Size = new System.Drawing.Size(256, 30);
            this.ucnic.TabIndex = 57;
            // 
            // ucity
            // 
            this.ucity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ucity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ucity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucity.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ucity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucity.LineColor = System.Drawing.Color.Gainsboro;
            this.ucity.Location = new System.Drawing.Point(783, 135);
            this.ucity.Name = "ucity";
            this.ucity.PasswordChar = '\0';
            this.ucity.SelectedText = "";
            this.ucity.Size = new System.Drawing.Size(256, 30);
            this.ucity.TabIndex = 57;
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 651);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.foxBigLabel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.FoxBigLabel foxBigLabel1;
        private Guna.UI.WinForms.GunaLineTextBox lastname;
        private Guna.UI.WinForms.GunaLineTextBox firstname;
        private System.Windows.Forms.ComboBox stdepart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.RoyalButton royalButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private ReaLTaiizor.ComboBoxEdit stsemester;
        private ReaLTaiizor.ComboBoxEdit astatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaLineTextBox uregno;
        private Guna.UI.WinForms.GunaLineTextBox stemail;
        private Guna.UI.WinForms.GunaLineTextBox upassword;
        private Guna.UI.WinForms.GunaLineTextBox ucontact;
        private Guna.UI.WinForms.GunaLineTextBox ucnic;
        private Guna.UI.WinForms.GunaLineTextBox ucity;
    }
}
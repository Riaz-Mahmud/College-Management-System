namespace Final_Project.UI.StudentForm
{
    partial class StudentDashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.AllNoticeDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnStudentsFullScreen = new System.Windows.Forms.Button();
            this.AllMarksdataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnRefreshTeacherList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NoticeForm = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelTopSide = new System.Windows.Forms.Panel();
            this.ProjectNameTxt = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CenterForm = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelSetButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.PanelLeftSide = new System.Windows.Forms.Panel();
            this.MarksForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AllNoticeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllMarksdataGrid)).BeginInit();
            this.NoticeForm.SuspendLayout();
            this.PanelTopSide.SuspendLayout();
            this.CenterForm.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.PanelLeftSide.SuspendLayout();
            this.MarksForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Final_Project.Properties.Resources.icons8_Fit_to_Width_30px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(788, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AllNoticeDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AllNoticeDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AllNoticeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllNoticeDataGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.AllNoticeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllNoticeDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllNoticeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AllNoticeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllNoticeDataGrid.DoubleBuffered = true;
            this.AllNoticeDataGrid.EnableHeadersVisualStyles = false;
            this.AllNoticeDataGrid.HeaderBgColor = System.Drawing.SystemColors.ScrollBar;
            this.AllNoticeDataGrid.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllNoticeDataGrid.Location = new System.Drawing.Point(26, 41);
            this.AllNoticeDataGrid.Name = "AllNoticeDataGrid";
            this.AllNoticeDataGrid.ReadOnly = true;
            this.AllNoticeDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AllNoticeDataGrid.RowHeadersVisible = false;
            this.AllNoticeDataGrid.Size = new System.Drawing.Size(727, 425);
            this.AllNoticeDataGrid.TabIndex = 10;
            this.AllNoticeDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllNoticeDataGrid_CellClick);
            // 
            // btnStudentsFullScreen
            // 
            this.btnStudentsFullScreen.BackgroundImage = global::Final_Project.Properties.Resources.icons8_Fit_to_Width_30px;
            this.btnStudentsFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStudentsFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentsFullScreen.FlatAppearance.BorderSize = 0;
            this.btnStudentsFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentsFullScreen.Location = new System.Drawing.Point(786, 50);
            this.btnStudentsFullScreen.Name = "btnStudentsFullScreen";
            this.btnStudentsFullScreen.Size = new System.Drawing.Size(36, 23);
            this.btnStudentsFullScreen.TabIndex = 3;
            this.btnStudentsFullScreen.UseVisualStyleBackColor = true;
            // 
            // AllMarksdataGrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AllMarksdataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.AllMarksdataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllMarksdataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AllMarksdataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllMarksdataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllMarksdataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AllMarksdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllMarksdataGrid.DoubleBuffered = true;
            this.AllMarksdataGrid.EnableHeadersVisualStyles = false;
            this.AllMarksdataGrid.HeaderBgColor = System.Drawing.SystemColors.ScrollBar;
            this.AllMarksdataGrid.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllMarksdataGrid.Location = new System.Drawing.Point(11, 44);
            this.AllMarksdataGrid.Name = "AllMarksdataGrid";
            this.AllMarksdataGrid.ReadOnly = true;
            this.AllMarksdataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AllMarksdataGrid.RowHeadersVisible = false;
            this.AllMarksdataGrid.Size = new System.Drawing.Size(742, 425);
            this.AllMarksdataGrid.TabIndex = 11;
            // 
            // btnRefreshTeacherList
            // 
            this.btnRefreshTeacherList.BackgroundImage = global::Final_Project.Properties.Resources.icons8_Refresh_30px;
            this.btnRefreshTeacherList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshTeacherList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshTeacherList.FlatAppearance.BorderSize = 0;
            this.btnRefreshTeacherList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTeacherList.Location = new System.Drawing.Point(99, 15);
            this.btnRefreshTeacherList.Name = "btnRefreshTeacherList";
            this.btnRefreshTeacherList.Size = new System.Drawing.Size(36, 23);
            this.btnRefreshTeacherList.TabIndex = 7;
            this.btnRefreshTeacherList.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "All Notice";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Final_Project.Properties.Resources.icons8_Refresh_30px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(79, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Marks";
            // 
            // NoticeForm
            // 
            this.NoticeForm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NoticeForm.Controls.Add(this.button1);
            this.NoticeForm.Controls.Add(this.AllNoticeDataGrid);
            this.NoticeForm.Controls.Add(this.btnRefreshTeacherList);
            this.NoticeForm.Controls.Add(this.label3);
            this.NoticeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoticeForm.Location = new System.Drawing.Point(157, 41);
            this.NoticeForm.Name = "NoticeForm";
            this.NoticeForm.Size = new System.Drawing.Size(765, 481);
            this.NoticeForm.TabIndex = 10;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.PanelTopSide;
            this.bunifuDragControl2.Vertical = true;
            // 
            // PanelTopSide
            // 
            this.PanelTopSide.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelTopSide.Controls.Add(this.ProjectNameTxt);
            this.PanelTopSide.Controls.Add(this.btnMinimize);
            this.PanelTopSide.Controls.Add(this.btnExit);
            this.PanelTopSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopSide.Location = new System.Drawing.Point(157, 0);
            this.PanelTopSide.Name = "PanelTopSide";
            this.PanelTopSide.Size = new System.Drawing.Size(765, 41);
            this.PanelTopSide.TabIndex = 8;
            // 
            // ProjectNameTxt
            // 
            this.ProjectNameTxt.AutoSize = true;
            this.ProjectNameTxt.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProjectNameTxt.Location = new System.Drawing.Point(6, 5);
            this.ProjectNameTxt.Name = "ProjectNameTxt";
            this.ProjectNameTxt.Size = new System.Drawing.Size(356, 30);
            this.ProjectNameTxt.TabIndex = 2;
            this.ProjectNameTxt.Text = "College Management System";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::Final_Project.Properties.Resources.icons8_Minus_30px;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(685, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 23);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Final_Project.Properties.Resources.icons8_Delete_30px_1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(727, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.ProjectNameTxt;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // CenterForm
            // 
            this.CenterForm.Controls.Add(this.groupBox6);
            this.CenterForm.Controls.Add(this.textBox1);
            this.CenterForm.Controls.Add(this.label1);
            this.CenterForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterForm.Location = new System.Drawing.Point(157, 41);
            this.CenterForm.Name = "CenterForm";
            this.CenterForm.Size = new System.Drawing.Size(765, 481);
            this.CenterForm.TabIndex = 9;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(44, 71);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(329, 398);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Student Information";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(225, 363);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(82, 19);
            this.textBox8.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(53, 363);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(66, 19);
            this.textBox7.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Year";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(53, 305);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(217, 19);
            this.textBox6.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(53, 240);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(217, 19);
            this.textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(53, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(217, 19);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(51, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(217, 19);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(53, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(217, 19);
            this.textBox2.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 26);
            this.label14.TabIndex = 12;
            this.label14.Text = "Contact Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 26);
            this.label12.TabIndex = 10;
            this.label12.Text = "Mother Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Father Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "BirthDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(0, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "DashBoard";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Student";
            // 
            // shapeContainer1
            // 
            // 
            // lineShape2
            // 
            // 
            // lineShape1
            // 
            // PanelSetButton
            // 
            this.PanelSetButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelSetButton.Location = new System.Drawing.Point(0, 41);
            this.PanelSetButton.Name = "PanelSetButton";
            this.PanelSetButton.Size = new System.Drawing.Size(8, 38);
            this.PanelSetButton.TabIndex = 1;
            // 
            // btnTeacher
            // 
            this.btnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Letter Gothic Std", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTeacher.Location = new System.Drawing.Point(0, 122);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(157, 38);
            this.btnTeacher.TabIndex = 3;
            this.btnTeacher.Text = "Notice";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Letter Gothic Std", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(0, 41);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(157, 38);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Letter Gothic Std", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudent.Location = new System.Drawing.Point(0, 82);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(157, 38);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Marks";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Letter Gothic Std", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(3, 472);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 38);
            this.button5.TabIndex = 7;
            this.button5.Text = "Log Out";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PanelLeftSide
            // 
            this.PanelLeftSide.BackColor = System.Drawing.Color.Teal;
            this.PanelLeftSide.Controls.Add(this.PanelSetButton);
            this.PanelLeftSide.Controls.Add(this.btnTeacher);
            this.PanelLeftSide.Controls.Add(this.btnHome);
            this.PanelLeftSide.Controls.Add(this.btnStudent);
            this.PanelLeftSide.Controls.Add(this.button5);
            this.PanelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.PanelLeftSide.Name = "PanelLeftSide";
            this.PanelLeftSide.Size = new System.Drawing.Size(157, 522);
            this.PanelLeftSide.TabIndex = 7;
            // 
            // MarksForm
            // 
            this.MarksForm.Controls.Add(this.btnStudentsFullScreen);
            this.MarksForm.Controls.Add(this.AllMarksdataGrid);
            this.MarksForm.Controls.Add(this.button2);
            this.MarksForm.Controls.Add(this.label2);
            this.MarksForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarksForm.Location = new System.Drawing.Point(157, 41);
            this.MarksForm.Name = "MarksForm";
            this.MarksForm.Size = new System.Drawing.Size(765, 481);
            this.MarksForm.TabIndex = 11;
            // 
            // StudentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 522);
            this.ControlBox = false;
            this.Controls.Add(this.CenterForm);
            this.Controls.Add(this.MarksForm);
            this.Controls.Add(this.NoticeForm);
            this.Controls.Add(this.PanelTopSide);
            this.Controls.Add(this.PanelLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.StudentDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllNoticeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllMarksdataGrid)).EndInit();
            this.NoticeForm.ResumeLayout(false);
            this.NoticeForm.PerformLayout();
            this.PanelTopSide.ResumeLayout(false);
            this.PanelTopSide.PerformLayout();
            this.CenterForm.ResumeLayout(false);
            this.CenterForm.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.PanelLeftSide.ResumeLayout(false);
            this.MarksForm.ResumeLayout(false);
            this.MarksForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid AllNoticeDataGrid;
        private System.Windows.Forms.Button btnStudentsFullScreen;
        private Bunifu.Framework.UI.BunifuCustomDataGrid AllMarksdataGrid;
        private System.Windows.Forms.Button btnRefreshTeacherList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel NoticeForm;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel PanelTopSide;
        private System.Windows.Forms.Label ProjectNameTxt;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel CenterForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelLeftSide;
        private System.Windows.Forms.FlowLayoutPanel PanelSetButton;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel MarksForm;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
    }
}
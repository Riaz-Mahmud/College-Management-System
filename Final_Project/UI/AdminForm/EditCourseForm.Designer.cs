namespace Final_Project.UI.AdminForm
{
    partial class EditCourseForm
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
            this.CourseGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleTxt = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnPayment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.classCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseIDTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CourseGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CourseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CourseGridView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.CourseGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourseGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CourseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseGridView.DoubleBuffered = true;
            this.CourseGridView.EnableHeadersVisualStyles = false;
            this.CourseGridView.HeaderBgColor = System.Drawing.SystemColors.ScrollBar;
            this.CourseGridView.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CourseGridView.Location = new System.Drawing.Point(286, 41);
            this.CourseGridView.Name = "CourseGridView";
            this.CourseGridView.ReadOnly = true;
            this.CourseGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CourseGridView.RowHeadersVisible = false;
            this.CourseGridView.Size = new System.Drawing.Size(525, 481);
            this.CourseGridView.TabIndex = 10;
            this.CourseGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.titleTxt);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 41);
            this.panel1.TabIndex = 11;
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleTxt.Location = new System.Drawing.Point(3, 5);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(149, 30);
            this.titleTxt.TabIndex = 4;
            this.titleTxt.Text = "Edit Course";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Final_Project.Properties.Resources.icons8_Delete_30px_1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(778, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.titleTxt;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayment.BorderRadius = 0;
            this.btnPayment.ButtonText = "UPDATE";
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.DisabledColor = System.Drawing.Color.Gray;
            this.btnPayment.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPayment.Iconimage = null;
            this.btnPayment.Iconimage_right = null;
            this.btnPayment.Iconimage_right_Selected = null;
            this.btnPayment.Iconimage_Selected = null;
            this.btnPayment.IconMarginLeft = 0;
            this.btnPayment.IconMarginRight = 0;
            this.btnPayment.IconRightVisible = true;
            this.btnPayment.IconRightZoom = 0D;
            this.btnPayment.IconVisible = true;
            this.btnPayment.IconZoom = 90D;
            this.btnPayment.IsTab = false;
            this.btnPayment.Location = new System.Drawing.Point(78, 325);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPayment.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPayment.selected = false;
            this.btnPayment.Size = new System.Drawing.Size(96, 38);
            this.btnPayment.TabIndex = 18;
            this.btnPayment.Text = "UPDATE";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayment.Textcolor = System.Drawing.Color.White;
            this.btnPayment.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // classCombo
            // 
            this.classCombo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.classCombo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCombo.FormattingEnabled = true;
            this.classCombo.Items.AddRange(new object[] {
            "XI",
            "XII"});
            this.classCombo.Location = new System.Drawing.Point(12, 199);
            this.classCombo.Name = "classCombo";
            this.classCombo.Size = new System.Drawing.Size(258, 29);
            this.classCombo.TabIndex = 17;
            this.classCombo.Text = "Select Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Class";
            // 
            // courseName
            // 
            this.courseName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.courseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.Location = new System.Drawing.Point(12, 137);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(258, 26);
            this.courseName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Course Name";
            // 
            // courseIDTxt
            // 
            this.courseIDTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.courseIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIDTxt.Location = new System.Drawing.Point(12, 79);
            this.courseIDTxt.Name = "courseIDTxt";
            this.courseIDTxt.ReadOnly = true;
            this.courseIDTxt.Size = new System.Drawing.Size(258, 26);
            this.courseIDTxt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Course ID";
            // 
            // statusCombo
            // 
            this.statusCombo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusCombo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "active",
            "deactive"});
            this.statusCombo.Location = new System.Drawing.Point(12, 265);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(258, 29);
            this.statusCombo.TabIndex = 22;
            this.statusCombo.Text = "Select Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status";
            // 
            // shapeContainer1
            // 
            // 
            // lineShape1
            // 
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(814, 522);
            this.ControlBox = false;
            this.Controls.Add(this.statusCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.courseIDTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.classCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CourseGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid CourseGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.TextBox courseIDTxt;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayment;
        private System.Windows.Forms.ComboBox classCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.Label label4;
    }
}
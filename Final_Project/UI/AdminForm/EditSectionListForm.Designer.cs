namespace Final_Project.UI.AdminForm
{
    partial class EditSectionListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SectionGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.classCom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxLimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sectionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherCom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNameCom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sectionID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPayment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.statusCom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 41);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit Teachers Information";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Final_Project.Properties.Resources.icons8_Delete_30px_1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(895, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 23);
            this.btnExit.TabIndex = 1;
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
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // SectionGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SectionGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SectionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SectionGridView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.SectionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SectionGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SectionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SectionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SectionGridView.DoubleBuffered = true;
            this.SectionGridView.EnableHeadersVisualStyles = false;
            this.SectionGridView.HeaderBgColor = System.Drawing.SystemColors.ScrollBar;
            this.SectionGridView.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SectionGridView.Location = new System.Drawing.Point(338, 81);
            this.SectionGridView.Name = "SectionGridView";
            this.SectionGridView.ReadOnly = true;
            this.SectionGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SectionGridView.RowHeadersVisible = false;
            this.SectionGridView.Size = new System.Drawing.Size(581, 484);
            this.SectionGridView.TabIndex = 13;
            this.SectionGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SectionGridView_CellClick);
            // 
            // classCom
            // 
            this.classCom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.classCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCom.ForeColor = System.Drawing.Color.Black;
            this.classCom.FormattingEnabled = true;
            this.classCom.Items.AddRange(new object[] {
            "XI",
            "XII"});
            this.classCom.Location = new System.Drawing.Point(9, 141);
            this.classCom.Name = "classCom";
            this.classCom.Size = new System.Drawing.Size(309, 28);
            this.classCom.TabIndex = 28;
            this.classCom.Text = "Select Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Class";
            // 
            // maxLimit
            // 
            this.maxLimit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.maxLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLimit.Location = new System.Drawing.Point(9, 389);
            this.maxLimit.Name = "maxLimit";
            this.maxLimit.Size = new System.Drawing.Size(183, 27);
            this.maxLimit.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Max Student Limit";
            // 
            // sectionName
            // 
            this.sectionName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionName.Location = new System.Drawing.Point(9, 327);
            this.sectionName.Name = "sectionName";
            this.sectionName.Size = new System.Drawing.Size(183, 27);
            this.sectionName.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Section Name";
            // 
            // teacherCom
            // 
            this.teacherCom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.teacherCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherCom.ForeColor = System.Drawing.Color.Black;
            this.teacherCom.FormattingEnabled = true;
            this.teacherCom.Location = new System.Drawing.Point(9, 265);
            this.teacherCom.Name = "teacherCom";
            this.teacherCom.Size = new System.Drawing.Size(309, 28);
            this.teacherCom.TabIndex = 22;
            this.teacherCom.Text = "Select Teacher";
            this.teacherCom.Click += new System.EventHandler(this.teacherCom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Select Teacher";
            // 
            // courseNameCom
            // 
            this.courseNameCom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.courseNameCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameCom.ForeColor = System.Drawing.Color.Black;
            this.courseNameCom.FormattingEnabled = true;
            this.courseNameCom.Location = new System.Drawing.Point(9, 201);
            this.courseNameCom.Name = "courseNameCom";
            this.courseNameCom.Size = new System.Drawing.Size(309, 28);
            this.courseNameCom.TabIndex = 20;
            this.courseNameCom.Text = "Select Course";
            this.courseNameCom.Click += new System.EventHandler(this.courseNameCom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Select Course";
            // 
            // sectionID
            // 
            this.sectionID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sectionID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionID.Location = new System.Drawing.Point(9, 81);
            this.sectionID.Name = "sectionID";
            this.sectionID.ReadOnly = true;
            this.sectionID.Size = new System.Drawing.Size(105, 20);
            this.sectionID.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Section ID";
            // 
            // btnPayment
            // 
            this.btnPayment.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayment.BorderRadius = 0;
            this.btnPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.btnPayment.Location = new System.Drawing.Point(90, 501);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPayment.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPayment.selected = false;
            this.btnPayment.Size = new System.Drawing.Size(127, 44);
            this.btnPayment.TabIndex = 31;
            this.btnPayment.Text = "UPDATE";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayment.Textcolor = System.Drawing.Color.White;
            this.btnPayment.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // statusCom
            // 
            this.statusCom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCom.ForeColor = System.Drawing.Color.Black;
            this.statusCom.FormattingEnabled = true;
            this.statusCom.Items.AddRange(new object[] {
            "active",
            "deactive"});
            this.statusCom.Location = new System.Drawing.Point(9, 449);
            this.statusCom.Name = "statusCom";
            this.statusCom.Size = new System.Drawing.Size(309, 28);
            this.statusCom.TabIndex = 33;
            this.statusCom.Text = "Select Stutas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(5, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(337, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Filter:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkCyan;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(455, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 35;
            this.button7.Text = "Teacher";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(380, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Section";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditSectionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(931, 566);
            this.ControlBox = false;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusCom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.sectionID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.classCom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxLimit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sectionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teacherCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseNameCom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SectionGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditSectionListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSectionListForm";
            this.Load += new System.EventHandler(this.EditSectionListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid SectionGridView;
        private System.Windows.Forms.TextBox sectionID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox classCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sectionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox teacherCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox courseNameCom;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayment;
        private System.Windows.Forms.ComboBox statusCom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
    }
}
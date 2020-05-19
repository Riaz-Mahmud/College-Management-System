namespace Final_Project.UI
{
    partial class EditStudentsInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.yearcombo = new System.Windows.Forms.ComboBox();
            this.sexSelect = new System.Windows.Forms.ComboBox();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.mothername = new System.Windows.Forms.TextBox();
            this.fathername = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(947, 41);
            this.panel1.TabIndex = 0;
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
            this.label1.Text = "Edit Students Information";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Final_Project.Properties.Resources.icons8_Delete_30px_1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(911, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.statusCombo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.birthdate);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.yearcombo);
            this.panel2.Controls.Add(this.sexSelect);
            this.panel2.Controls.Add(this.phonenumber);
            this.panel2.Controls.Add(this.mothername);
            this.panel2.Controls.Add(this.fathername);
            this.panel2.Controls.Add(this.address);
            this.panel2.Controls.Add(this.fullName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 564);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(344, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(600, 561);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // statusCombo
            // 
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "active",
            "deactive"});
            this.statusCombo.Location = new System.Drawing.Point(46, 475);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(273, 21);
            this.statusCombo.TabIndex = 10;
            this.statusCombo.Text = "Select Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Status";
            // 
            // birthdate
            // 
            this.birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdate.Location = new System.Drawing.Point(46, 128);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(273, 20);
            this.birthdate.TabIndex = 56;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(169, 506);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(150, 39);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "UserName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Family Contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Mother Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Father Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "BirthDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Full Name";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(46, 32);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(273, 20);
            this.username.TabIndex = 1;
            // 
            // yearcombo
            // 
            this.yearcombo.FormattingEnabled = true;
            this.yearcombo.Items.AddRange(new object[] {
            "XI",
            "XII"});
            this.yearcombo.Location = new System.Drawing.Point(46, 423);
            this.yearcombo.Name = "yearcombo";
            this.yearcombo.Size = new System.Drawing.Size(273, 21);
            this.yearcombo.TabIndex = 9;
            this.yearcombo.Text = "Select Year";
            // 
            // sexSelect
            // 
            this.sexSelect.FormattingEnabled = true;
            this.sexSelect.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexSelect.Location = new System.Drawing.Point(46, 222);
            this.sexSelect.Name = "sexSelect";
            this.sexSelect.Size = new System.Drawing.Size(273, 21);
            this.sexSelect.TabIndex = 5;
            this.sexSelect.Text = "Select Gender";
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(46, 176);
            this.phonenumber.Multiline = true;
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(273, 20);
            this.phonenumber.TabIndex = 4;
            this.phonenumber.TextChanged += new System.EventHandler(this.phonenumber_TextChanged);
            // 
            // mothername
            // 
            this.mothername.Location = new System.Drawing.Point(46, 369);
            this.mothername.Multiline = true;
            this.mothername.Name = "mothername";
            this.mothername.Size = new System.Drawing.Size(273, 20);
            this.mothername.TabIndex = 8;
            // 
            // fathername
            // 
            this.fathername.Location = new System.Drawing.Point(46, 323);
            this.fathername.Multiline = true;
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(273, 20);
            this.fathername.TabIndex = 7;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(46, 276);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(273, 20);
            this.address.TabIndex = 6;
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(46, 78);
            this.fullName.Multiline = true;
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(273, 20);
            this.fullName.TabIndex = 2;
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
            // EditStudentsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 605);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStudentsInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStudentsInfoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.ComboBox yearcombo;
        private System.Windows.Forms.ComboBox sexSelect;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.TextBox mothername;
        private System.Windows.Forms.TextBox fathername;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
    }
}
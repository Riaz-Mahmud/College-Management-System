namespace Final_Project.UI
{
    partial class ReceivePaymentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivePaymentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.ProjectTxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelPaymentInfo = new System.Windows.Forms.Panel();
            this.yearCom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPayment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.paymentDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.payTypeCom = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSerch = new Bunifu.Framework.UI.BunifuTextbox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.ProjectTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Final_Project.Properties.Resources.icons8_Delete_30px_1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(717, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ProjectTxt
            // 
            this.ProjectTxt.AutoSize = true;
            this.ProjectTxt.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProjectTxt.Location = new System.Drawing.Point(3, 5);
            this.ProjectTxt.Name = "ProjectTxt";
            this.ProjectTxt.Size = new System.Drawing.Size(210, 30);
            this.ProjectTxt.TabIndex = 4;
            this.ProjectTxt.Text = "Receive Payment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.PanelPaymentInfo);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSerch);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 503);
            this.panel2.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(59, 186);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(187, 14);
            this.textBox5.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Class:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Enter Username or ID";
            // 
            // PanelPaymentInfo
            // 
            this.PanelPaymentInfo.Controls.Add(this.label11);
            this.PanelPaymentInfo.Controls.Add(this.button1);
            this.PanelPaymentInfo.Controls.Add(this.textBox4);
            this.PanelPaymentInfo.Controls.Add(this.yearCom);
            this.PanelPaymentInfo.Controls.Add(this.label10);
            this.PanelPaymentInfo.Controls.Add(this.btnPayment);
            this.PanelPaymentInfo.Controls.Add(this.label7);
            this.PanelPaymentInfo.Controls.Add(this.amountTxt);
            this.PanelPaymentInfo.Controls.Add(this.paymentDate);
            this.PanelPaymentInfo.Controls.Add(this.label6);
            this.PanelPaymentInfo.Controls.Add(this.monthCom);
            this.PanelPaymentInfo.Controls.Add(this.label5);
            this.PanelPaymentInfo.Controls.Add(this.label4);
            this.PanelPaymentInfo.Controls.Add(this.payTypeCom);
            this.PanelPaymentInfo.Location = new System.Drawing.Point(292, 6);
            this.PanelPaymentInfo.Name = "PanelPaymentInfo";
            this.PanelPaymentInfo.Size = new System.Drawing.Size(449, 211);
            this.PanelPaymentInfo.TabIndex = 11;
            // 
            // yearCom
            // 
            this.yearCom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.yearCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearCom.FormattingEnabled = true;
            this.yearCom.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.yearCom.Location = new System.Drawing.Point(309, 48);
            this.yearCom.Name = "yearCom";
            this.yearCom.Size = new System.Drawing.Size(121, 24);
            this.yearCom.TabIndex = 14;
            this.yearCom.Text = "Year Select";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Year";
            // 
            // btnPayment
            // 
            this.btnPayment.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayment.BorderRadius = 0;
            this.btnPayment.ButtonText = "Submit";
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
            this.btnPayment.Location = new System.Drawing.Point(24, 156);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPayment.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPayment.selected = false;
            this.btnPayment.Size = new System.Drawing.Size(96, 38);
            this.btnPayment.TabIndex = 12;
            this.btnPayment.Text = "Submit";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayment.Textcolor = System.Drawing.Color.White;
            this.btnPayment.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Amount";
            // 
            // amountTxt
            // 
            this.amountTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.amountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTxt.Location = new System.Drawing.Point(91, 100);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(142, 26);
            this.amountTxt.TabIndex = 7;
            this.amountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // paymentDate
            // 
            this.paymentDate.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.paymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paymentDate.Location = new System.Drawing.Point(309, 14);
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.Size = new System.Drawing.Size(121, 20);
            this.paymentDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // monthCom
            // 
            this.monthCom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.monthCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCom.FormattingEnabled = true;
            this.monthCom.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthCom.Location = new System.Drawing.Point(90, 51);
            this.monthCom.Name = "monthCom";
            this.monthCom.Size = new System.Drawing.Size(143, 24);
            this.monthCom.TabIndex = 3;
            this.monthCom.Text = "Selete Months";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type";
            // 
            // payTypeCom
            // 
            this.payTypeCom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.payTypeCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payTypeCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payTypeCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payTypeCom.FormattingEnabled = true;
            this.payTypeCom.Items.AddRange(new object[] {
            "Tution Free",
            "Half Year Exam Fee",
            "Final Exam Fee"});
            this.payTypeCom.Location = new System.Drawing.Point(90, 12);
            this.payTypeCom.Name = "payTypeCom";
            this.payTypeCom.Size = new System.Drawing.Size(143, 24);
            this.payTypeCom.TabIndex = 0;
            this.payTypeCom.Text = "Select Payment Type";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(64, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(187, 14);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(92, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(159, 14);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(187, 14);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 201);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(145, 20);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Transaction History";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(12, 223);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(729, 268);
            this.bunifuCustomDataGrid1.TabIndex = 3;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(155, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(96, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSerch
            // 
            this.txtSerch.BackColor = System.Drawing.Color.Silver;
            this.txtSerch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSerch.BackgroundImage")));
            this.txtSerch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSerch.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSerch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSerch.Icon")));
            this.txtSerch.Location = new System.Drawing.Point(37, 25);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.Size = new System.Drawing.Size(214, 34);
            this.txtSerch.TabIndex = 1;
            this.txtSerch.text = "";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(753, 503);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 289;
            this.lineShape1.X2 = 290;
            this.lineShape1.Y1 = 7;
            this.lineShape1.Y2 = 216;
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
            this.bunifuDragControl1.TargetControl = this.ProjectTxt;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(286, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(42, 22);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(334, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(228, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "TnxID:";
            this.label11.Visible = false;
            // 
            // ReceivePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 546);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceivePaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceivePaymentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelPaymentInfo.ResumeLayout(false);
            this.PanelPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label ProjectTxt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuTextbox txtSerch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.Panel PanelPaymentInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox monthCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox payTypeCom;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DateTimePicker paymentDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amountTxt;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayment;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox yearCom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}
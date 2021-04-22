using Final_Project.Entities;
using Final_Project.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.UI.StudentForm
{
    public partial class StudentDashBoard : Form
    {
        AdminService adminService;
        string USERNAME;
        string SECTION;
        string YEAR;
        public StudentDashBoard()
        {
            InitializeComponent();
            this.adminService = new AdminService();
        }
        public StudentDashBoard(string username)
        {
            InitializeComponent();
            this.adminService = new AdminService();
            this.USERNAME = username;
        }

        
        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnHome.Height;
            PanelSetButton.Top = btnHome.Top;
            CenterForm.Visible = true;
            MarksForm.Visible = false;
            NoticeForm.Visible = false;
            
            
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnStudent.Height;
            PanelSetButton.Top = btnStudent.Top;
            CenterForm.Visible = false;
            MarksForm.Visible = true;
            NoticeForm.Visible = false;
            GetAllMarksDataByStudent();
        }

        

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnTeacher.Height;
            PanelSetButton.Top = btnTeacher.Top;
            CenterForm.Visible = false;
            MarksForm.Visible = false;
            NoticeForm.Visible = true;
            
            NoticeViewGridView();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = button5.Height;
            PanelSetButton.Top = button5.Top;
            int result = adminService.LogOut();
            if (result > 0)
            {
                LoginForm logout = new LoginForm();
                this.Hide();
                logout.Show();
            }
            else
            {
                MessageBox.Show("Something Worng");
            }
        }

        private void StudentDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StudentDashBoard_Load(object sender, EventArgs e)
        {

            var data = adminService.GetCurrentUserbyUsername(USERNAME);
            if (data.Id.Equals(0) && data.Username == "")
            {
                MessageBox.Show("Something Wrong");
            }
            textBox2.Text = data.Name;
            textBox3.Text = data.Birthdate;
            textBox4.Text = data.FatherName;
            textBox5.Text = data.MotherName;
            textBox6.Text = data.FamilyPhone;
            textBox7.Text = data.CollegeYear;
            textBox8.Text = data.Section;
            SECTION = data.Section;
            YEAR = data.CollegeYear;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void NoticeViewGridView()
        {
            AllNoticeDataGrid.DataSource = adminService.GetAllNotice(USERNAME);
        }

        private void AllNoticeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = AllNoticeDataGrid.Rows[rowIndex];
                string from = row.Cells[1].Value.ToString();
                string message = row.Cells[4].Value.ToString();
                MessageBox.Show("From: " + from +"\n\n"+"Message: " + message);

            }
            catch (Exception)
            {
                MessageBox.Show("Something Wrong!");
            }
        }

        private void GetAllMarksDataByStudent()
        {
            AllMarksdataGrid.DataSource = adminService.GetAllMarksDataByStudent(USERNAME);
        }
    }
}

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

namespace Final_Project.UI.TeacherForm
{
    public partial class TeacherDashBoard : Form
    {
        string USERNAME;
        AdminService adminService;
        public TeacherDashBoard()
        {
            InitializeComponent();
            this.adminService = new AdminService();
        }

        public TeacherDashBoard(string username)
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
            Section.Visible = false;
            NoticeForm.Visible = false;
            CourseForm.Visible = false;
            LoadTeacherDetails();
        }

        

        private void btnStudent_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnStudent.Height;
            PanelSetButton.Top = btnStudent.Top;
            CenterForm.Visible = false;
            Section.Visible = true;
            NoticeForm.Visible = false;
            CourseForm.Visible = false;
            CheckGradeLock();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnTeacher.Height;
            PanelSetButton.Top = btnTeacher.Top;
            CenterForm.Visible = false;
            Section.Visible = false;
            NoticeForm.Visible = true;
            CourseForm.Visible = false;
            GetAllNoticeByTeacher();
        }

        

        private void btnCourse_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnCourse.Height;
            PanelSetButton.Top = btnCourse.Top;
            CenterForm.Visible = false;
            Section.Visible = false;
            NoticeForm.Visible = false;
            CourseForm.Visible = true;
            GetAllCourseByTeacher();
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

        private void btnAddNewTeacher_Click(object sender, EventArgs e)
        {
            AddNewNotice addNotice = new AddNewNotice(USERNAME);
            addNotice.Show();
        }

        private void GetAllNoticeByTeacher()
        {
            AllNoticeDataGrid.DataSource = adminService.GetAllNoticeByTeacher(USERNAME);
        }

        private void AllNoticeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = AllNoticeDataGrid.Rows[rowIndex];
                string from = row.Cells[1].Value.ToString();
                string message = row.Cells[4].Value.ToString();
                textBox7.Text = row.Cells[0].Value.ToString();
                MessageBox.Show("From: " + from + "\n\n" + "Message: " + message);

            }
            catch (Exception)
            {
                MessageBox.Show("Something Wrong!");
            }
        }

        private void btnRefreshTeacherList_Click(object sender, EventArgs e)
        {
            GetAllNoticeByTeacher();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Select Class First");
            }
            else
            {
                comboBox2.Text = "";
                comboBox2.DataSource = adminService.GetAllSectionByTeacher(USERNAME, comboBox1.SelectedItem.ToString());
            }
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Select Class First and Section First");
            }
            else
            {
                comboBox3.DataSource = adminService.GetAllCourseByTeacher(USERNAME,comboBox1.SelectedItem.ToString(),comboBox2.SelectedItem.ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Select Class First and Section First and Course first");
            }
            else
            {
                GetAllSectionStudentByTeacher();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Select Class First and Section First and Course first");
            }
            else
            {
                GetAllSectionStudentByTeacher();
            }
        }

        private void GetAllSectionStudentByTeacher()
        {
            SectionStudentsdataGrid.DataSource = adminService.GetAllSectionStudentByTeacher(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
        }

        private void GetAllCourseByTeacher()
        {
            CourseGridView.DataSource = adminService.GetAllCourseByTeacher(USERNAME);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAllCourseByTeacher();
        }

        private void btnAddNewStudents_Click(object sender, EventArgs e)
        {
            UploadMarks marksUp = new UploadMarks(USERNAME);
            marksUp.Show();
        }

        private void btnEditTeacherInfo_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Select Notice ID First");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Select Notice ID First");
            }
            else
            {
                int result = adminService.DeleteNoticeByTeacher(Convert.ToInt32(textBox7.Text));
                if (result > 0)
                {
                    MessageBox.Show("Delete Successful");
                    textBox7.Text = "";
                    GetAllNoticeByTeacher();
                }
                else
                {
                    MessageBox.Show("Somethign Wrong");
                }
            }
        }

        private void CheckGradeLock()
        {
            string status = adminService.ViewGradeLockStatus();
            if(status == "active")
            {
                label13.Visible = true;
                btnUploadMarks.Enabled = false;
            }else if(status == "deactivate")
            {
                label13.Enabled = false;
                btnUploadMarks.Enabled = true;
            }
        }

        private void LoadTeacherDetails()
        {
            var data = adminService.LoadTeacherDetails(USERNAME);
            if (data.Id.Equals(0) && data.Username == "")
            {
                MessageBox.Show("Something Wrong");
            }
            else
            {
                textBox2.Text = data.Name;
                textBox3.Text = data.Username;
                textBox4.Text = data.Birthdate;
                textBox5.Text = data.Address;
                textBox6.Text = data.Phone;
            }
        }
    }
}

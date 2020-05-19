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
    public partial class UploadMarks : Form
    {
        bool RESULT = false;
        bool STUDENT = true;
        string USERNAME;
        AdminService adminService;
        public UploadMarks()
        {
            InitializeComponent();
            this.adminService = new AdminService();
        }
        public UploadMarks(string username)
        {
            InitializeComponent();
            this.adminService = new AdminService();
            this.USERNAME = username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                comboBox3.DataSource = adminService.GetAllCourseByTeacher(USERNAME, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RESULT = false;
            STUDENT = true;
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

        private void SectionStudentsdataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (STUDENT)
            {
                try
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow row = SectionStudentsdataGrid.Rows[rowIndex];
                    string year = row.Cells[3].Value.ToString();
                    string section = row.Cells[5].Value.ToString();
                    string username = row.Cells[4].Value.ToString();
                    string subject = comboBox3.SelectedItem.ToString();
                    SubmitMarks_Form marks = new SubmitMarks_Form(year, section, username, subject);
                    marks.Show();

                }
                catch (Exception)
                {
                    MessageBox.Show("Something Wrong!");
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RESULT = true;
            STUDENT = false;
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Select Class First and Section First and Course first");
            }
            else
            {
                GetAllSectionStudentResultByTeacher();
            }

        }

        private void GetAllSectionStudentResultByTeacher()
        {
            SectionStudentsdataGrid.DataSource = adminService.GetAllSectionStudentResultByTeacher(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString());
        }

        private void UploadMarks_Load(object sender, EventArgs e)
        {
            comboBox4.DataSource = adminService.GetCurrentAcademicYear();
        }
    }
}

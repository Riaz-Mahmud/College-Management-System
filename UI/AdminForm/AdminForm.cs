using Final_Project.Entities;
using Final_Project.Services;
using Final_Project.UI;
using Final_Project.UI.AdminForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class HomeForm : Form
    {
        AdminService adminService;
        public HomeForm()
        {
            InitializeComponent();
            this.adminService = new AdminService();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnHome.Height;
            PanelSetButton.Top = btnHome.Top;
            CenterForm.Visible = true;
            StudentForm.Visible = false;
            TeacherForm.Visible = false;
            CourseForm.Visible = false;
            SectionForm.Visible = false;
            TransactionForm.Visible = false;
            SettingForm.Visible = false;
            HomePanelLoad();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnStudent.Height;
            PanelSetButton.Top = btnStudent.Top;
            CenterForm.Visible = false;
            StudentForm.Visible = true;
            TeacherForm.Visible = false;
            CourseForm.Visible = false;
            SectionForm.Visible = false;
            TransactionForm.Visible = false;
            SettingForm.Visible = false;
            ViewGridView();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnTeacher.Height;
            PanelSetButton.Top = btnTeacher.Top;
            CenterForm.Visible = false;
            StudentForm.Visible = false;
            TeacherForm.Visible = true;
            CourseForm.Visible = false;
            SectionForm.Visible = false;
            TransactionForm.Visible = false;
            SettingForm.Visible = false;
            TeacherViewGridView();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnCourse.Height;
            PanelSetButton.Top = btnCourse.Top;
            CenterForm.Visible = false;
            StudentForm.Visible = false;
            TeacherForm.Visible = false;
            CourseForm.Visible = true;
            SectionForm.Visible = false;
            TransactionForm.Visible = false;
            SettingForm.Visible = false;
            CourseViewGridView();
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnSection.Height;
            PanelSetButton.Top = btnSection.Top;
            CenterForm.Visible = false;
            StudentForm.Visible = false;
            TeacherForm.Visible = false;
            CourseForm.Visible = false;
            SectionForm.Visible = true;
            TransactionForm.Visible = false;
            SettingForm.Visible = false;
            SectionViewGridView();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = btnTransaction.Height;
            PanelSetButton.Top = btnTransaction.Top;
            CenterForm.Visible = false;
            StudentForm.Visible = false;
            TeacherForm.Visible = false;
            CourseForm.Visible = false;
            SectionForm.Visible = false;
            TransactionForm.Visible = true;
            SettingForm.Visible = false;
            TrnxViewGripView();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            PanelSetButton.Height = button8.Height;
            PanelSetButton.Top = button8.Top;
            CenterForm.Visible = false;
            StudentForm.Visible = false;
            TeacherForm.Visible = false;
            CourseForm.Visible = false;
            SectionForm.Visible = false;
            TransactionForm.Visible = false;
            SettingForm.Visible = true;
            ViewGradeLockStatus();
            LoadAcademicYear();
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

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAddNewStudents_Click(object sender, EventArgs e)
        {
            AddNewStudentsForm addnewstudens = new AddNewStudentsForm();
            addnewstudens.Show();
        }
        private void ViewGridView()
        {
            AllStudentsdataGrid.DataSource = adminService.GetAllStudents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewGridView();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            showFullScreenStudentsList();
        }

        private void btnStudentsFullScreen_Click(object sender, EventArgs e)
        {
            showFullScreenStudentsList();
        }

        private void showFullScreenStudentsList()
        {
            AllStudentsListFullScreenForm allStudentsList = new AllStudentsListFullScreenForm();
            allStudentsList.Show();
        }

        private void btnAddNewStudents_Click_1(object sender, EventArgs e)
        {
            AddNewStudentsForm addNewStudens = new AddNewStudentsForm();
            addNewStudens.Show();
        }

        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            EditStudentsInfoForm editStudents = new EditStudentsInfoForm();
            editStudents.Show();
        }

        private void btnAllStudentsList_Click(object sender, EventArgs e)
        {
            showFullScreenStudentsList();
        }

        private void btnReceivePayment_Click(object sender, EventArgs e)
        {
            ReceivePaymentForm receivePayment = new ReceivePaymentForm();
            receivePayment.Show();
        }

        private void btnAddNewTeacher_Click(object sender, EventArgs e)
        {
            AddNewTeacherForm addnewTeacher = new AddNewTeacherForm();
            addnewTeacher.Show();
        }
        private void TeacherViewGridView()
        {
            AllTeacherDataGrid.DataSource = adminService.GetAllTeacher();
        }

        private void btnEditTeacherInfo_Click(object sender, EventArgs e)
        {
            EditTeachersInfoForm editTeacherInfo = new EditTeachersInfoForm();
            editTeacherInfo.Show();
        }

        private void btnAllTeacherList_Click(object sender, EventArgs e)
        {
            AllTeacherListForm allTeacherList = new AllTeacherListForm();
            allTeacherList.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllTeacherListForm allTeacherList = new AllTeacherListForm();
            allTeacherList.Show();
        }

        private void btnRefreshTeacherList_Click(object sender, EventArgs e)
        {
            TeacherViewGridView();
        }

        private void btnAddNewCouse_Click(object sender, EventArgs e)
        {
            AddNewCourseForm addNewCourse = new AddNewCourseForm();
            addNewCourse.Show();
        }

        private void CourseViewGridView()
        {
            CourseGridView.DataSource = adminService.GetAllCourse();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CourseViewGridView();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            EditCourseForm editCourseForm = new EditCourseForm();
            editCourseForm.Show();
        }

        private void btnCreateNewSection_Click(object sender, EventArgs e)
        {
            AddNewSectionForm addNewSection = new AddNewSectionForm();
            addNewSection.Show();
        }

        private void SectionViewGridView()
        {
            SectionGridView.DataSource = adminService.GetAllSection();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SectionViewGridView();
        }

        private void btnEditSection_Click(object sender, EventArgs e)
        {
            EditSectionListForm editSection = new EditSectionListForm();
            editSection.Show();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            ReceivePaymentForm receivePyament = new ReceivePaymentForm();
            receivePyament.Show();
        }

        private void TrnxViewGripView()
        {
            TranxDataGrid.DataSource = adminService.GetAllTransaction();
        }

        private void TrnxRefreshBtn_Click(object sender, EventArgs e)
        {
            TrnxViewGripView();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddSectionTeacher addNewSection = new AddSectionTeacher();
            addNewSection.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //textBox2 //total student
            HomePanelLoad();
        }

        public void HomePanelLoad()
        {
            textBox2.Text = adminService.GetTotalStudentCount();
            textBox5.Text = adminService.GetTotalActiveStudentCount();
            textBox3.Text = adminService.GetTotalTeacherCount();
            textBox6.Text = adminService.GetTotalActiveTeacherCount();
            textBox4.Text = adminService.GetTotalCourseCount();
            textBox7.Text = adminService.GetTotalActiveCourseCount();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ReceivePaymentForm receivePyament = new ReceivePaymentForm();
            receivePyament.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SectionViewGridView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SectionTeacherViewGridView();
        }

        private void SectionTeacherViewGridView()
        {
            SectionGridView.DataSource = adminService.GetAllSectionTeacher();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            updateStatusLock("active");
            
        }

        void updateStatusLock(string status)
        {
            int result = adminService.UpdateGradeLockStatus(status);
            if (result > 0)
            {
                MessageBox.Show("Update");
                ViewGradeLockStatus();
            }
            else
            {
                MessageBox.Show("Something Wrong!");
            }
        }

        private void ViewGradeLockStatus()
        {
            textBox8.Text = adminService.ViewGradeLockStatus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            updateStatusLock("deactivate");
        }

        public void LoadAcademicYear()
        {
            AcademicYearDataTable.DataSource = adminService.LoadAcademicYear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                MessageBox.Show("Select First!");
            }
            else
            {
                int result = adminService.DeleteAcademicYear(Convert.ToInt32(textBox9.Text));
                if (result > 0)
                {
                    MessageBox.Show("Delete Successful");
                    textBox9.Text = "";
                    LoadAcademicYear();
                }
                else
                {
                    MessageBox.Show("Somethign Wrong");
                }
            }
        }

        private void AcademicYearDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = AcademicYearDataTable.Rows[rowIndex];
                textBox9.Text = row.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Wrong!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddAcademicYear addYear = new AddAcademicYear();
            addYear.Show();
        }
        
    }
}

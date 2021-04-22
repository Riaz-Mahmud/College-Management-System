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

namespace Final_Project.UI.AdminForm
{
    public partial class EditSectionListForm : Form
    {
        AdminService adminService;
        bool TEACHER = false;
        bool SECTION = true;
        public EditSectionListForm()
        {
            InitializeComponent();
            this.adminService = new AdminService();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void SectionViewGridView()
        {
            SectionGridView.DataSource = adminService.GetAllSection();
        }

        private void SectionGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            courseNameCom.Enabled = true;
            teacherCom.Enabled = true;
            maxLimit.Enabled = true;
            maxLimit.Text = "";
            courseNameCom.Text = "";
            teacherCom.Text = "";
            try
            {
                
                if(SECTION)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow row = SectionGridView.Rows[rowIndex];
                    sectionID.Text = row.Cells[0].Value.ToString();
                    classCom.Text = row.Cells[2].Value.ToString();
                    maxLimit.Text = row.Cells[3].Value.ToString();
                    sectionName.Text = row.Cells[1].Value.ToString();
                    statusCom.Text = row.Cells[6].Value.ToString();
                        
                    courseNameCom.Enabled = false;
                    teacherCom.Enabled = false;
                }
                else if(TEACHER)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow row = SectionGridView.Rows[rowIndex];
                    sectionID.Text = row.Cells[0].Value.ToString();
                    courseNameCom.Text = row.Cells[4].Value.ToString();
                    teacherCom.Text = row.Cells[5].Value.ToString();
                    classCom.Text = row.Cells[2].Value.ToString();
                    sectionName.Text = row.Cells[1].Value.ToString();
                    statusCom.Text = row.Cells[6].Value.ToString();
                    maxLimit.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void EditSectionListForm_Load(object sender, EventArgs e)
        {
            SectionViewGridView();
            //courseNameCom.DataSource = adminService.GetAllCourseNames();
            //teacherCom.DataSource = adminService.GetAllTeacherNames();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (SECTION)
            {

                int result = adminService.EditSection(Convert.ToInt32(sectionID.Text), classCom.SelectedItem.ToString(), sectionName.Text, maxLimit.Text, statusCom.SelectedItem.ToString());
                if (result > 0)
                {

                    MessageBox.Show("updated successfully.");
                    SectionViewGridView();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Error occured..");
                }
            }
            else if(TEACHER)
            {
                int result = adminService.EditSectionTeacher(Convert.ToInt32(sectionID.Text), courseNameCom.SelectedItem.ToString(), teacherCom.SelectedItem.ToString(), classCom.SelectedItem.ToString(), sectionName.Text, statusCom.SelectedItem.ToString());
                if (result > 0)
                {
                    MessageBox.Show("updated successfully.");
                    SectionTeacherViewGridView();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Error occured..");
                }
            }
        }

        private void ClearText()
        {
            courseNameCom.SelectedItem = teacherCom.SelectedItem = classCom.SelectedItem = statusCom.SelectedItem = null;
            sectionID.Text = sectionName.Text = maxLimit.Text = "";
        }

        private void courseNameCom_Click(object sender, EventArgs e)
        {
            if (classCom.SelectedItem == null)
            {
                MessageBox.Show("Select College Year First!");
            }
            else
            {
                courseNameCom.DataSource = adminService.GetAllCourseNames(classCom.SelectedItem.ToString());
            }
            
            //teacherCom.DataSource = adminService.GetAllTeacherNames();
        }

        private void teacherCom_Click(object sender, EventArgs e)
        {
            //courseNameCom.DataSource = adminService.GetAllCourseNames();
            teacherCom.DataSource = adminService.GetAllTeacherNames();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TEACHER = false;
            SECTION = true;
            SectionViewGridView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TEACHER = true;
            SECTION = false;
            SectionTeacherViewGridView();
        }

        private void SectionTeacherViewGridView()
        {
            SectionGridView.DataSource = adminService.GetAllSectionTeacher();
        }
    }
}

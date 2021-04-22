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
    public partial class EditCourseForm : Form
    {
        AdminService adminService;
        public EditCourseForm()
        {
            InitializeComponent();
            this.adminService = new AdminService();
            CourseViewGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void CourseViewGridView()
        {
            CourseGridView.DataSource = adminService.GetAllCourse();
        }

        private void CourseGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = CourseGridView.Rows[rowIndex];
                courseIDTxt.Text = row.Cells[0].Value.ToString();
                courseName.Text = row.Cells[1].Value.ToString();
                classCombo.Text = row.Cells[2].Value.ToString();
                statusCombo.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                courseIDTxt.Text = courseName.Text = classCombo.Text = statusCombo.Text = "";
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (courseName.Text == "" || classCombo.SelectedItem == null || statusCombo.SelectedItem == null)
            {
                MessageBox.Show("Added successfully.");
            }
            else
            {
                int result = adminService.EditCourse(Convert.ToInt32(courseIDTxt.Text), courseName.Text, classCombo.SelectedItem.ToString(), statusCombo.SelectedItem.ToString());
                if (result > 0)
                {

                    //username,fullName,birthdate,sexSelect.SelectedItem.ToString(),address,fathername,mothername,phonenumber,yearcombo.SelectedItem.ToString(),statusCombo.SelectedItem.ToString()
                    MessageBox.Show("updated successfully.");
                    CourseViewGridView();
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
            courseIDTxt.Text = courseName.Text = "";
            classCombo.SelectedItem = statusCombo.SelectedItem = null;
        }
    }
}

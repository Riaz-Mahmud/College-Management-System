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
    public partial class EditTeachersInfoForm : Form
    {
        AdminService adminService;
        public EditTeachersInfoForm()
        {
            InitializeComponent();
            this.adminService = new AdminService();
            TeacherViewGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TeacherViewGridView()
        {
            AllTeacherDataGrid.DataSource = adminService.GetAllTeacher();
        }

        private void AllTeacherDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = AllTeacherDataGrid.Rows[rowIndex];
                username.Text = row.Cells[5].Value.ToString();
                fullName.Text = row.Cells[1].Value.ToString();
                birthdate.Text = row.Cells[2].Value.ToString();
                phonenumber.Text = row.Cells[4].Value.ToString();
                address.Text = row.Cells[3].Value.ToString();
                statusCombo.Text = row.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                //txtIdShow.Text = "";
                MessageBox.Show("" + ex);

            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (fullName.Text == "" || birthdate.Text == "" || phonenumber.Text == "" || address.Text == "" || statusCombo.SelectedItem == null)
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                int result = adminService.EditTeacher(username.Text, fullName.Text, birthdate.Text, address.Text, phonenumber.Text, statusCombo.SelectedItem.ToString());
                if (result > 0)
                {
                    MessageBox.Show("updated successfully.");
                    TeacherViewGridView();
                }
                else
                {
                    MessageBox.Show("Error occured..");
                }
            }
        }

    }
}

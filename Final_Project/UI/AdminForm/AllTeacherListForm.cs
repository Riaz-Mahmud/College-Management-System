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
    public partial class AllTeacherListForm : Form
    {
        AdminService adminService;
        public AllTeacherListForm()
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = AllTeacherDataGrid.Rows[rowIndex];
                txtIdShow.Text = row.Cells[0].Value.ToString();
                
            }
            catch (Exception ex)
            {
                //txtIdShow.Text = "";
                MessageBox.Show("" + ex);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherViewGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditTeachersInfoForm editTeacherInfo = new EditTeachersInfoForm();
            editTeacherInfo.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dresult == DialogResult.Yes)
            {
                int result = adminService.RemoveTeacher(Convert.ToInt32(txtIdShow.Text));
                if (result > 0)
                {
                    MessageBox.Show("Deleted successfully.");
                    TeacherViewGridView();
                    txtIdShow.Text = "";
                }
                else
                {
                    MessageBox.Show("Error occured..");
                    txtIdShow.Text = "";
                }
            }
        
        }
    }
}

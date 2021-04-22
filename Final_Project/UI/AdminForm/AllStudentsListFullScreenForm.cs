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

namespace Final_Project.UI
{
    public partial class AllStudentsListFullScreenForm : Form
    {
        AdminService adminService;
        public AllStudentsListFullScreenForm()
        {
            InitializeComponent();
            this.adminService = new AdminService();
            ViewGridView();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void ViewGridView()
        {
            dataGridView1.DataSource = adminService.GetAllStudents();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try 
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                txtIdShow.Text = row.Cells[0].Value.ToString();
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch(Exception)
            {
                txtIdShow.Text = "";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditStudentsInfoForm editStudentsInfo = new EditStudentsInfoForm();
            editStudentsInfo.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dresult == DialogResult.Yes)
            {
                int result = adminService.RemoveStudent(Convert.ToInt32(txtIdShow.Text));
                if (result > 0)
                {
                    MessageBox.Show("Deleted successfully.");
                    ViewGridView();
                    txtIdShow.Text = "";
                }
                else
                {
                    MessageBox.Show("Error occured..");
                    txtIdShow.Text = "";
                }
            }
            else
            { }
        }
    }
}

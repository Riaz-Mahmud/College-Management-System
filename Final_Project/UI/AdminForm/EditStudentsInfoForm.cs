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
    public partial class EditStudentsInfoForm : Form
    {
        AdminService adminService;
        public EditStudentsInfoForm()
        {
            InitializeComponent();
            this.adminService = new AdminService();
            ViewGridView();
        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {

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
                username.Text = row.Cells[9].Value.ToString();
                fullName.Text = row.Cells[1].Value.ToString();
                birthdate.Text = row.Cells[2].Value.ToString();
                phonenumber.Text = row.Cells[7].Value.ToString();
                sexSelect.Text = row.Cells[3].Value.ToString();
                address.Text = row.Cells[4].Value.ToString();
                fathername.Text = row.Cells[5].Value.ToString();
                mothername.Text = row.Cells[6].Value.ToString();
                yearcombo.Text = row.Cells[8].Value.ToString();
                statusCombo.Text = row.Cells[11].Value.ToString();
            }
            catch (Exception ex)
            {
                //txtIdShow.Text = "";
                MessageBox.Show(""+ex);
                
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (fullName.Text == "" || birthdate.Text == "" || sexSelect.SelectedItem == null || address.Text == "" || fathername.Text == "" || mothername.Text == "" || phonenumber.Text == "" || yearcombo.SelectedItem == null || statusCombo.SelectedItem == null)
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                int result = adminService.EditStudent(username.Text, fullName.Text, birthdate.Text, sexSelect.SelectedItem.ToString(), address.Text, fathername.Text, mothername.Text, phonenumber.Text, yearcombo.SelectedItem.ToString(), statusCombo.SelectedItem.ToString());
                if (result > 0)
                {

                    //username,fullName,birthdate,sexSelect.SelectedItem.ToString(),address,fathername,mothername,phonenumber,yearcombo.SelectedItem.ToString(),statusCombo.SelectedItem.ToString()
                    MessageBox.Show("updated successfully.");
                    ViewGridView();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Error occured..");
                    ClearText();
                }
            }
        }

        private void ClearText()
        {
            username.Text = fullName.Text = birthdate.Text = address.Text = fathername.Text = mothername.Text = phonenumber.Text = "";
            yearcombo.SelectedItem = statusCombo.SelectedItem = sexSelect.SelectedItem = null;
        }
    }
}

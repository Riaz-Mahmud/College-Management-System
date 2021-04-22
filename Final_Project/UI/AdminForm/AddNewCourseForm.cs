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
    public partial class AddNewCourseForm : Form
    {
        AdminService adminService;
        public AddNewCourseForm()
        {
            InitializeComponent();
            this.adminService = new AdminService();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                if(chekcAlreadyAvailable())
                {
                    int result = adminService.AddCourse(textBox1.Text, comboBox1.SelectedItem.ToString(),"active");
                    if (result > 0)
                    {
                        MessageBox.Show("Added successfully.");
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Error occured..");
                    }
                }
                else
                {
                    MessageBox.Show("Course Name Already Available");
                }
            }
        }

        private bool chekcAlreadyAvailable()
        {
            int check = adminService.chekcAlreadyAvailable(textBox1.Text, comboBox1.SelectedItem.ToString());
            if (check > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void ClearText()
        {
            textBox1.Text = "";
            comboBox1.SelectedItem = null;
        }
    }
}

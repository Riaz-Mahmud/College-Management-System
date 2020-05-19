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
    public partial class AddNewTeacherForm : Form
    {
        AdminService adminService;
        public AddNewTeacherForm()
        {
            InitializeComponent();
            this.adminService = new AdminService();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fullName.Text == "" || dateTimePicker1.Text == "" || phonenumber.Text == "" || address.Text == "" || username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                if (checkTeacherUsernameAlreadyAvailable())
                {
                    int result = adminService.AddTeacher("2", username.Text, password.Text, fullName.Text, dateTimePicker1.Text, address.Text, phonenumber.Text, "active");
                    if (result > 0)
                    {
                        MessageBox.Show("Student added successfully.");
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Error occured..");
                    }
                }
                else
                {
                    MessageBox.Show("Teacher Username Already Available");
                }
            }
        }

        private bool checkTeacherUsernameAlreadyAvailable()
        {
            int result = adminService.checkTeacherUsernameAlreadyAvailable(username.Text);
            if (result == 2)
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
            fullName.Text = dateTimePicker1.Text = phonenumber.Text = address.Text = username.Text = password.Text = "";
        }
    }
}

using Final_Project.Services;
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

namespace Final_Project.UI
{
    public partial class AddNewStudentsForm : Form
    {
        AdminService adminService;
        LoginService loginService;
        public AddNewStudentsForm()
        {
            InitializeComponent();
            this.adminService = new AdminService();
            this.loginService = new LoginService();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddNewStudentsForm_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (fullName.Text == "" || birthdate.Text == "" || sexSelect.SelectedItem == null || address.Text == "" || fathername.Text == "" || mothername.Text == "" || phonenumber.Text == "" || yearcombo.SelectedItem == null || comboBox1.SelectedItem == null || username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                //string Status = "active";
                if (checkSectionLimit())
                {
                    if (checkUserNameTaken())
                    {
                        int result = adminService.AddStudents(username.Text, password.Text, fullName.Text, birthdate.Text, sexSelect.SelectedItem.ToString(), address.Text, fathername.Text, mothername.Text, phonenumber.Text, yearcombo.SelectedItem.ToString(), comboBox1.SelectedItem.ToString(), "active", "3");
                        if (result > 0)
                        {
                            MessageBox.Show("Student added successfully.\nUsername: " + username.Text + "\nPassword: " + password.Text);
                            ClearText();
                        }
                        else
                        {
                            MessageBox.Show("Error occured..");
                            ClearText();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Already Taken!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Section Reach Max Student Limit");
                    label14.Visible = true;
                }
            }
        }

        private bool checkUserNameTaken()
        {
            int result = adminService.checkUserNameTaken(username.Text);
            
            if (result == 3)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private bool checkSectionLimit()
        {
            int limit = adminService.checkSectionLimit(yearcombo.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());
            if (limit > 0)
            {
                return true;
            }
            return false;
        }
        void ClearText()
        {
            username.Text = password.Text = fullName.Text = birthdate.Text = sexSelect.Text = address.Text = fathername.Text = mothername.Text = phonenumber.Text = yearcombo.Text = comboBox1.Text = string.Empty;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (yearcombo.SelectedItem == null)
            {
                MessageBox.Show("Select College Year First");
            }
            else
            {
                comboBox1.Text = "";
                comboBox1.DataSource = adminService.GetAllSectionByYear(yearcombo.SelectedItem.ToString());
            }
           
        }

        private void label14_Click(object sender, EventArgs e)
        {
            AddNewSectionForm addNewSection = new AddNewSectionForm();
            addNewSection.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (checkUserNameTaken())
            {
                MessageBox.Show("Available");
            }
            else
            {
                MessageBox.Show("Not Available");
            }
        }


    }
}

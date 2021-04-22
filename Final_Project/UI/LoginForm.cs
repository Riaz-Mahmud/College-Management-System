using Final_Project.Services;
using Final_Project.UI.StudentForm;
using Final_Project.UI.TeacherForm;
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
    public partial class LoginForm : Form
    {
        LoginService login;
        public LoginForm()
        {
            InitializeComponent();
            login = new LoginService();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username_text.Text == "" || password_text.Text == "" || TypeCBox.SelectedItem == null)
            {
                MessageBox.Show("Username or Password or Type can not be empty");
            }
            else
            {
                if (TypeCBox.SelectedItem.ToString() == "Admin")
                {
                    //MessageBox.Show("Admin");
                    int result = login.LoginValidationAdmin(username_text.Text, password_text.Text);
                    if (result > 0)
                    {
                        if (result == 1)
                        {
                            username_text.Text = "";
                            password_text.Text = "";
                            HomeForm homeForm = new HomeForm();
                            this.Hide();
                            homeForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("You do not have the priviledge");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");

                    }

                }
                else if (TypeCBox.SelectedItem.ToString() == "Teacher")
                {
                    int result = login.LoginValidationTeacher(username_text.Text, password_text.Text);
                    if (result > 0)
                    {
                        if (result == 2)
                        {

                            TeacherDashBoard teacherForm = new TeacherDashBoard(username_text.Text);
                            this.Hide();
                            teacherForm.Show();
                            username_text.Text = "";
                            password_text.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("You do not have the priviledge");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");

                    }
                }
                else if (TypeCBox.SelectedItem.ToString() == "Student")
                {
                    //MessageBox.Show("Student");
                    int result = login.LoginValidationStudent(username_text.Text, password_text.Text);
                        if (result > 0)
                    {
                        if (result == 3)
                        {
                            StudentDashBoard studentForm = new StudentDashBoard(username_text.Text);
                            this.Hide();
                            studentForm.Show();
                            username_text.Text = "";
                            password_text.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("You do not have the priviledge");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");

                    }
                }
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            username_text.Text = "";
            password_text.Text = "";
        }
    }
}

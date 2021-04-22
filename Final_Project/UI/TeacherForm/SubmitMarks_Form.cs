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

namespace Final_Project.UI.TeacherForm
{
    public partial class SubmitMarks_Form : Form
    {
        string USERNAME;
        string YEAR;
        string SECTION;
        string SUBJECT;
        AdminService adminService;
        public SubmitMarks_Form()
        {
            InitializeComponent();
        }

        public SubmitMarks_Form(string year,string section,string username, string subject)
        {
            InitializeComponent();
            this.adminService = new AdminService();
            this.USERNAME = username;
            this.YEAR = year;
            this.SECTION = section;
            this.SUBJECT = subject;
            textBox1.Text = username;
            textBox2.Text = year;
            textBox3.Text = subject;
            textBox4.Text = section;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked || textBox5.Text == "")
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                float mark = Convert.ToSingle(textBox5.Text);
                if (mark > 0 && mark < 100)
                {
                    if (radioButton1.Checked)
                    {
                        if (checkAlreadySubmitMidMark())
                        {
                            mark = Convert.ToSingle(textBox5.Text);
                            string acaYear = comboBox1.SelectedItem.ToString();
                            int result = adminService.UploadStudentMidMark(YEAR, SECTION, SUBJECT, mark, USERNAME, acaYear, "active");
                            if (result > 0)
                            {
                                MessageBox.Show("Success");
                            }
                            else
                            {
                                MessageBox.Show("Something Wrong!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Already Submit MidExam Marks!");
                            button2.Visible = true;
                        }

                    }
                    else if (radioButton2.Checked)
                    {
                        mark = Convert.ToSingle(textBox5.Text);
                        string acaYear = comboBox1.SelectedItem.ToString();
                        int result = adminService.UploadStudentFinalMark(YEAR, SECTION, SUBJECT, mark, USERNAME, acaYear);
                        if (result > 0)
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Something Wrong!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something wrong!!");
                    }
                }
                else
                {
                    MessageBox.Show("Marks Should be between 0 to 100");
                }
            }
        }

        private bool checkAlreadySubmitMidMark()
        {
            string acaYear = comboBox1.SelectedItem.ToString();
            int result = adminService.checkAlreadySubmitMidMark(YEAR, SECTION, SUBJECT, USERNAME, acaYear, "active");
            if (result >0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SubmitMarks_Form_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = adminService.GetCurrentAcademicYear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float mark = Convert.ToSingle(textBox5.Text);
            if(mark >0 && mark < 100)
            {
                string acaYear = comboBox1.SelectedItem.ToString();
                int result = adminService.EditStudentMidMark(YEAR, SECTION, SUBJECT, mark, USERNAME, acaYear);
                if (result > 0)
                {
                    MessageBox.Show("Success");
                    button2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Something Wrong!");
                }
            }
            else
            {
                MessageBox.Show("Marks Should be between 0 to 100");
            }
            
        }
    }
}

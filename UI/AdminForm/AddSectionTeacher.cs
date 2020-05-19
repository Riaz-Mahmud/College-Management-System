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
    public partial class AddSectionTeacher : Form
    {
        AdminService adminService;
        public AddSectionTeacher()
        {
            InitializeComponent();
            this.adminService = new AdminService();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddNewSection_Load(object sender, EventArgs e)
        {
            
            comboBox2.DataSource = adminService.GetAllTeacherNames();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox3.SelectedItem == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                int result = adminService.AddTacherToSection(comboBox4.SelectedItem.ToString(), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), "active");
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
        }

        private void ClearText()
        {
            comboBox1.SelectedItem =comboBox3.SelectedItem = comboBox3.SelectedItem =comboBox4.SelectedItem = null;
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Select College Year First");
            }
            else
            {
                comboBox4.Text = "";
                comboBox4.DataSource = adminService.GetAllSectionName(comboBox3.SelectedItem.ToString());
            }
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Select College Year First");
            }
            else
            {
                comboBox1.Text = "";
                comboBox1.DataSource = adminService.GetAllCourseNames(comboBox3.SelectedItem.ToString());
            }
        }
    }
}

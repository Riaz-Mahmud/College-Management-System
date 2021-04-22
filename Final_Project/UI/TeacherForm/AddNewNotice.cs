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
    public partial class AddNewNotice : Form
    {
        AdminService adminService;
        string USERNAME;
        public AddNewNotice()
        {
            InitializeComponent();
            this.adminService = new AdminService();
        }

        public AddNewNotice(string username)
        {
            InitializeComponent();
            this.USERNAME = username;
            this.adminService = new AdminService();
            textBox1.Text = username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Select College Year First");
            }
            else
            {
                comboBox2.Text = "";
                comboBox2.DataSource = adminService.GetAllSectionByTeacher(USERNAME, comboBox1.SelectedItem.ToString());
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || textBox1.Text == "")
            {
                MessageBox.Show("Empty Field!");
            }
            else
            {
                int result = adminService.AddNewNotice(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), textBox1.Text, USERNAME);
                if (result > 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Something Wrong!");
                }
            }
        }
    }
}

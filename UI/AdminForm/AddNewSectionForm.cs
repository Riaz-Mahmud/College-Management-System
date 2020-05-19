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
    public partial class AddNewSectionForm : Form
    {
        AdminService adminService;
        public AddNewSectionForm()
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
            if (comboBox3.SelectedItem == null || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                if (checkSectionAvailable())
                {
                    int result = adminService.AddSection(comboBox3.SelectedItem.ToString(), textBox1.Text, textBox2.Text, "active");
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
                    MessageBox.Show("Section Name Already Available");
                }
            }
        }

        private bool checkSectionAvailable()
        {
            int result = adminService.checkSectionAvailable(comboBox3.SelectedItem.ToString(), textBox1.Text);
            if (result > 0)
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
            textBox1.Text = textBox2.Text = "";
            comboBox3.SelectedItem = null;
        }

        private void AddNewSectionForm_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = adminService.GetAllCourseNames();
            //comboBox2.DataSource = adminService.GetAllTeacherNames();
        }
    }
}

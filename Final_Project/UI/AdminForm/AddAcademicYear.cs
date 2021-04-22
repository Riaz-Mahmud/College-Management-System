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
    public partial class AddAcademicYear : Form
    {
        AdminService adminService;
        public AddAcademicYear()
        {
            InitializeComponent();
            this.adminService = new AdminService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                int result = adminService.AddNewAcademicYear(textBox1.Text);
                if (result > 0)
                {
                    MessageBox.Show("Success");
                    textBox1.Text = "";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something Wrong!");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

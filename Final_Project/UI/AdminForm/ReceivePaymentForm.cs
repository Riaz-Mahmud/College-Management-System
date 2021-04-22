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
    public partial class ReceivePaymentForm : Form
    {
        string user_name= "";
        AdminService adminService;
        public ReceivePaymentForm()
        {
            InitializeComponent();
            adminService = new AdminService();
            PanelPaymentInfo.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label11.Visible = false;
            textBox4.Text = "";
            if(txtSerch.text== "")
            {
                MessageBox.Show("Empty Field!");
            }
            else
            {
                user_name = txtSerch.text;
                if (viewStudentInfo())
                {
                    ViewGridView();
                    PanelPaymentInfo.Visible = true;
                }
                else
                {
                    MessageBox.Show("User Not found");
                    Clear();
                }
            }
        }

        private bool viewStudentInfo()
        {
            var data = adminService.GetUserbyUsername(user_name);
            if (data.Id.Equals(0) && data.Username == "" )
            {
                return false;
            }
            textBox1.Text = Convert.ToString(data.Id);
            textBox2.Text = data.Username;
            textBox3.Text = data.Name;
            textBox5.Text = data.CollegeYear;
            return true;
        }

        private void ViewGridView()
        {
            bunifuCustomDataGrid1.DataSource = adminService.GetUserTransaction(user_name);
        }

        private void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            bunifuCustomDataGrid1.DataSource = null;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if(payTypeCom.SelectedItem == null || monthCom.SelectedItem == null || yearCom.SelectedItem == null || amountTxt.Text == "" || paymentDate.Text=="")
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                if (checkIsAlreadyPay())
                {
                    MessageBox.Show("Already Paid " + payTypeCom.SelectedItem.ToString());
                }
                else
                {
                    int result = adminService.AddNewTrnx(textBox2.Text, textBox3.Text, paymentDate.Text, textBox5.Text, Convert.ToSingle(amountTxt.Text),payTypeCom.SelectedItem.ToString(), monthCom.SelectedItem.ToString(), yearCom.SelectedItem.ToString());
                    if (result > 0)
                    {
                        MessageBox.Show("New Trnx Added!");
                        ViewGridView();
                        ClearAfterPaymentSuccess();
                    }
                    else
                    {
                        MessageBox.Show("Error occured..");
                        ClearAfterPaymentSuccess();
                    }
                }
            }
        }

        private void ClearAfterPaymentSuccess()
        {
            amountTxt.Text = "";
            payTypeCom.SelectedItem = monthCom.SelectedItem = yearCom.SelectedItem = null;
        }

        private bool checkIsAlreadyPay()
        {
            if (payTypeCom.SelectedItem.ToString() == "Tution Free")
            {
                string username = adminService.UserTutionPaidOrNot(textBox2.Text, payTypeCom.SelectedItem.ToString(), monthCom.SelectedItem.ToString(), yearCom.SelectedItem.ToString());
                if (username == "")
                {
                    return false;
                }
                return true;
            }
            else
            {
                string username = adminService.UserExamFeePainOrNOt(textBox2.Text, payTypeCom.SelectedItem.ToString(), yearCom.SelectedItem.ToString());
                if (username == "")
                {
                    return false;
                }
                return true;
            }

            
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button1.Visible = true;
                label11.Visible = true;
                int rowIndex = e.RowIndex;
                DataGridViewRow row = bunifuCustomDataGrid1.Rows[rowIndex];
                textBox4.Text = row.Cells[0].Value.ToString();
                
            }
            catch (Exception)
            {
                button1.Visible = false;
                label11.Visible = false;
                textBox4.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Select TnxID First");
            }
            else
            {
                int result = adminService.DeleteTrnx(Convert.ToInt32(textBox4.Text));
                if (result > 0)
                {
                    MessageBox.Show("Delete Successful");
                    button1.Visible = false;
                    label11.Visible = false;
                    textBox4.Text = "";
                    ViewGridView();
                }
                else
                {
                    MessageBox.Show("Somethign Wrong");
                }
            }
        }
        
    }
}

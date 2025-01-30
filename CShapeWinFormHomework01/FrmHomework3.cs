using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShapeWinFormHomework01
{
    public partial class FrmHomework3 : Form
    {
        public FrmHomework3()
        {
            InitializeComponent();
        }

        private void FrmHomework3_Load(object sender, EventArgs e)
        {
            tbNumPeople.KeyPress += ShareData.textBox_KeyPressNum;
            tbTotalAmount.KeyPress += ShareData.tb_KeyPressDecimal;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private bool ValidateInputs(TextBox totalAmountBox, TextBox numPeopleBox)
        {
            
            if (string.IsNullOrWhiteSpace(totalAmountBox.Text) || string.IsNullOrWhiteSpace(numPeopleBox.Text))
            {

                ShareData.showWarningMSG("กรุณากรอกข้อมูลให้ครบ");
                return false;
            }

            // Validate that the total amount is a valid positive number
            if (!double.TryParse(totalAmountBox.Text, out double totalAmount) || totalAmount <= 0)
            {
                ShareData.showWarningMSG("กรุณากรอกจำนวนเงินที่ถูกต้อง");

                return false;
            }

            // Validate that the number of people is a valid positive integer
            if (!int.TryParse(numPeopleBox.Text, out int numPeople) || numPeople <= 0)
            {
                ShareData.showWarningMSG("จำนวนคนต้องเป็นตัวเลขที่มากกว่า 0");
                return false;
            }

            return true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            if (!ValidateInputs(tbTotalAmount, tbNumPeople))
                return;

            
            double totalAmount = double.Parse(tbTotalAmount.Text);
            int numPeople = int.Parse(tbNumPeople.Text);

            
            if (numPeople == 0)
            {
                MessageBox.Show("จำนวนคนต้องไม่เป็น 0", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            double share = totalAmount / numPeople;

            
            lbResult.Text = share.ToString("#,###,###,##0.00");
        }
    }
}

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
    public partial class FrmHomework4 : Form
    {
        public FrmHomework4()
        {
            InitializeComponent();
        }

        private void FrmHomework4_Load(object sender, EventArgs e)
        {
            btReset.PerformClick();
            tbParticipants.KeyPress += ShareData.textBox_KeyPressNum;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            
            rbJava.Checked = true;
            rbAndroid.Checked = false;
            rbIOS.Checked = false;
            rbPHP.Checked = false;

            
            tbParticipants.Clear();

            
            lbSelectedCourse.Text = "XXX";
            lbTotalParticipants.Text = "XXX";
            lbTotalFee.Text = "XXX";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private static bool ValidateInputs(RadioButton rbJava, RadioButton rbAndroid, RadioButton rbIOS, RadioButton rbPHP, TextBox tbParticipants)
        {
            if (!rbJava.Checked && !rbAndroid.Checked && !rbIOS.Checked && !rbPHP.Checked)
            {
                ShareData.showWarningMSG("กรุณาเลือกหลักสูตรการอบรม");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbParticipants.Text) || !int.TryParse(tbParticipants.Text, out int participants) || participants <= 0)
            {
                ShareData. showWarningMSG("กรุณากรอกจำนวนผู้เข้าอบรมให้ถูกต้อง (ตัวเลขมากกว่า 0)");
                return false;
            }

            return true; // ✅ Inputs are valid
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            
            if (!ValidateInputs(rbJava, rbAndroid, rbIOS, rbPHP, tbParticipants))
                return;

            
            double courseFee = 0;
            string selectedCourse = "";

            if (rbJava.Checked) { courseFee = 1000; selectedCourse = "JAVA"; }
            else if (rbAndroid.Checked) { courseFee = 1200; selectedCourse = "Android"; }
            else if (rbIOS.Checked) { courseFee = 1400; selectedCourse = "iOS"; }
            else if (rbPHP.Checked) { courseFee = 1600; selectedCourse = "PHP"; }

            //Get number of participants
            int participants = int.Parse(tbParticipants.Text);

            //Apply discount
            double discountRate = 0;
            if (participants >= 2 && participants <= 4)
            {
                discountRate = 0.05; // 5% discount
            }
            else if (participants >= 5)
            {
                discountRate = 0.10; // 10% discount
            }

            double totalFee = (courseFee * participants) * (1 - discountRate);

            //Display Results
            lbSelectedCourse.Text = selectedCourse;
            lbTotalParticipants.Text = participants.ToString();
            lbTotalFee.Text = totalFee.ToString("#,###,##0.00");
        }
    }
}

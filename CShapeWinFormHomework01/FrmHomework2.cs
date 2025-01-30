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
    public partial class FrmHomework2 : Form
    {
        public FrmHomework2()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


        private static bool ValidateInputs(TextBox tbStudentID, TextBox tbFullName, TextBox tbMidtermScore, TextBox tbFinalScore, TextBox tbAccumScore)
        {
            if (string.IsNullOrWhiteSpace(tbStudentID.Text))
            {
                ShareData.showWarningMSG("กรุณากรอกรหัสนักศึกษา");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbFullName.Text))
            {
                ShareData.showWarningMSG("กรุณากรอกชื่อ-สกุล");
                return false;
            }

            if (!double.TryParse(tbMidtermScore.Text, out double midterm) || midterm < 0 || midterm > 100)
            {
                ShareData.showWarningMSG("กรุณากรอกคะแนนสอบกลางภาคให้ถูกต้อง (0-100)");
                return false;
            }

            if (!double.TryParse(tbFinalScore.Text, out double final) || final < 0 || final > 100)
            {
                ShareData.showWarningMSG("กรุณากรอกคะแนนสอบปลายภาคให้ถูกต้อง (0-100)");
                return false;
            }

            if (!double.TryParse(tbAccumScore.Text, out double accum) || accum < 0 || accum > 100)
            {
                ShareData.showWarningMSG("กรุณากรอกคะแนนเก็บให้ถูกต้อง (0-100)");
                return false;
            }

            double totalScore = midterm + final + accum;
            if (totalScore > 100)
            {
                ShareData.showWarningMSG($"คะแนนรวม ({totalScore}) ไม่สามารถเกิน 100 ได้");
                return false;
            }

            return true; 
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbStudentID.Clear();
            tbFullName.Clear();
            tbMidtermScore.Clear();
            tbFinalScore.Clear();
            tbAccumScore.Clear();

            lbStudentID.Text = "XXXXXXXXXX";
            lbFullName.Text = "XXXXXXXXXX";
            lbTotalScore.Text = "XXXXXXXXXX";
            lbGPA.Text = "XXXXXXXXXX";
        }

        private void FrmHomework2_Load(object sender, EventArgs e)
        {
            btReset.PerformClick();

            tbStudentID.KeyPress += ShareData.textBox_KeyPressNum;
            tbFullName.KeyPress += ShareData.ValidateName;
            tbMidtermScore.KeyPress += ShareData.tb_KeyPressDecimal;
            tbFinalScore.KeyPress += ShareData.tb_KeyPressDecimal;
            tbAccumScore.KeyPress += ShareData.tb_KeyPressDecimal;

        }

        private string GetLetterGrade(double totalScore)
        {
            if (totalScore >= 80) return "A";
            else if (totalScore >= 75) return "B+";
            else if (totalScore >= 70) return "B";
            else if (totalScore >= 65) return "C+";
            else if (totalScore >= 60) return "C";
            else if (totalScore >= 55) return "D+";
            else if (totalScore >= 50) return "D";
            else return "F"; // Below 50 = Fail
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {

            if (!ValidateInputs(tbStudentID, tbFullName, tbMidtermScore, tbFinalScore, tbAccumScore))
                return;

            // Convert scores to numbers
            double midterm = double.Parse(tbMidtermScore.Text);
            double final = double.Parse(tbFinalScore.Text);
            double accum = double.Parse(tbAccumScore.Text);

            // Calculate total score (should not exceed 100)
            double totalScore = midterm + final + accum;

            // Convert total score to letter grade
            string grade = GetLetterGrade(totalScore);

            // Display results
            lbStudentID.Text = tbStudentID.Text;
            lbFullName.Text = tbFullName.Text;
            lbTotalScore.Text = totalScore.ToString("0.00");
            lbGPA.Text = grade; // Display letter grade instead of GPA

        }
        }
    }

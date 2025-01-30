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
    public partial class FrmHomework1 : Form
    {
        public FrmHomework1()
        {
            InitializeComponent();
        }
    



    private static void ShowMonthMessage(int month)
        {
            string monthName = "";
            string details = "";

            switch (month)
            {
                case 1: monthName = "มกราคม"; details = "เดือนที่ 1 ของปี มี 31 วัน"; break;
                case 2: monthName = "กุมภาพันธ์"; details = "เดือนที่ 2 ของปี มี 28 หรือ 29 วัน"; break;
                case 3: monthName = "มีนาคม"; details = "เดือนที่ 3 ของปี มี 31 วัน"; break;
                case 4: monthName = "เมษายน"; details = "เดือนที่ 4 ของปี มี 30 วัน"; break;
                case 5: monthName = "พฤษภาคม"; details = "เดือนที่ 5 ของปี มี 31 วัน"; break;
                case 6: monthName = "มิถุนายน"; details = "เดือนที่ 6 ของปี มี 30 วัน"; break;
                case 7: monthName = "กรกฎาคม"; details = "เดือนที่ 7 ของปี มี 31 วัน"; break;
                case 8: monthName = "สิงหาคม"; details = "เดือนที่ 8 ของปี มี 31 วัน"; break;
                case 9: monthName = "กันยายน"; details = "เดือนที่ 9 ของปี มี 30 วัน"; break;
                case 10: monthName = "ตุลาคม"; details = "เดือนที่ 10 ของปี มี 31 วัน"; break;
                case 11: monthName = "พฤศจิกายน"; details = "เดือนที่ 11 ของปี มี 30 วัน"; break;
                case 12: monthName = "ธันวาคม"; details = "เดือนที่ 12 ของปี มี 31 วัน"; break;
                default:
                    ShareData.showWarningMSG("ข้อมูลเดือนไม่ถูกต้อง!");
                    return;
            }

            MessageBox.Show($"📅 เดือน {monthName}\n📖 {details}", "ข้อมูลเดือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btMonth_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null || clickedButton.Tag == null)
            {
                ShareData.showWarningMSG("เกิดข้อผิดพลาดในการเลือกเดือน!");
                return;
            }

            int monthNumber;
            if (!int.TryParse(clickedButton.Tag.ToString(), out monthNumber) || monthNumber < 1 || monthNumber > 12)
            {
                ShareData.showWarningMSG("หมายเลขเดือนไม่ถูกต้อง!");
                return;
            }

            ShowMonthMessage(monthNumber);
        }
        private void FrmHomework1_Load(object sender, EventArgs e)
        {
            btMonth1.Tag = 1;
            btMonth2.Tag = 2;
            btMonth3.Tag = 3;
            btMonth4.Tag = 4;
            btMonth5.Tag = 5;
            btMonth6.Tag = 6;
            btMonth7.Tag = 7;
            btMonth8.Tag = 8;
            btMonth9.Tag = 9;
            btMonth10.Tag = 10;
            btMonth11.Tag = 11;
            btMonth12.Tag = 12;

            btMonth1.Click += btMonth_Click;
            btMonth2.Click += btMonth_Click;
            btMonth3.Click += btMonth_Click;
            btMonth4.Click += btMonth_Click;
            btMonth5.Click += btMonth_Click;
            btMonth6.Click += btMonth_Click;
            btMonth7.Click += btMonth_Click;
            btMonth8.Click += btMonth_Click;
            btMonth9.Click += btMonth_Click;
            btMonth10.Click += btMonth_Click;
            btMonth11.Click += btMonth_Click;
            btMonth12.Click += btMonth_Click;
        }
    }
}

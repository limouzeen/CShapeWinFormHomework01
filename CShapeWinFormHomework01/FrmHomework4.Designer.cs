namespace CShapeWinFormHomework01
{
    partial class FrmHomework4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbJava = new System.Windows.Forms.RadioButton();
            this.rbAndroid = new System.Windows.Forms.RadioButton();
            this.rbIOS = new System.Windows.Forms.RadioButton();
            this.rbPHP = new System.Windows.Forms.RadioButton();
            this.tbParticipants = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalFee = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTotalParticipants = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSelectedCourse = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(186, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "โปรแกรมคำนวณค่าอบรม สัมนา";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbJava
            // 
            this.rbJava.AutoSize = true;
            this.rbJava.Checked = true;
            this.rbJava.Location = new System.Drawing.Point(163, 71);
            this.rbJava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbJava.Name = "rbJava";
            this.rbJava.Size = new System.Drawing.Size(219, 17);
            this.rbJava.TabIndex = 16;
            this.rbJava.TabStop = true;
            this.rbJava.Text = "อบรม JAVA Developer (คนละ 1,000 บาท)";
            this.rbJava.UseVisualStyleBackColor = true;
            // 
            // rbAndroid
            // 
            this.rbAndroid.AutoSize = true;
            this.rbAndroid.Location = new System.Drawing.Point(163, 101);
            this.rbAndroid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAndroid.Name = "rbAndroid";
            this.rbAndroid.Size = new System.Drawing.Size(229, 17);
            this.rbAndroid.TabIndex = 17;
            this.rbAndroid.Text = "อบรม Android Developer (คนละ 1,200 บาท)";
            this.rbAndroid.UseVisualStyleBackColor = true;
            // 
            // rbIOS
            // 
            this.rbIOS.AutoSize = true;
            this.rbIOS.Location = new System.Drawing.Point(163, 131);
            this.rbIOS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbIOS.Name = "rbIOS";
            this.rbIOS.Size = new System.Drawing.Size(211, 17);
            this.rbIOS.TabIndex = 18;
            this.rbIOS.Text = "อบรม IOS Developer (คนละ 1,400 บาท)";
            this.rbIOS.UseVisualStyleBackColor = true;
            // 
            // rbPHP
            // 
            this.rbPHP.AutoSize = true;
            this.rbPHP.Location = new System.Drawing.Point(163, 161);
            this.rbPHP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPHP.Name = "rbPHP";
            this.rbPHP.Size = new System.Drawing.Size(215, 17);
            this.rbPHP.TabIndex = 19;
            this.rbPHP.Text = "อบรม PHP Developer (คนละ 1,600 บาท)";
            this.rbPHP.UseVisualStyleBackColor = true;
            // 
            // tbParticipants
            // 
            this.tbParticipants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbParticipants.Location = new System.Drawing.Point(163, 195);
            this.tbParticipants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbParticipants.MaxLength = 3;
            this.tbParticipants.Name = "tbParticipants";
            this.tbParticipants.Size = new System.Drawing.Size(213, 20);
            this.tbParticipants.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "จำนวนคนที่เข้าอบรม";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "คน";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(163, 235);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(212, 92);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "หมายเหตุ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "- กรณีเข้าอบรม 5 คนขึ้นไปลด 10%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "- กรณีเข้าอบรม  2 - 4 คน ลด 5%";
            // 
            // btExit
            // 
            this.btExit.Image = global::CShapeWinFormHomework01.Properties.Resources.Kyo_Tux_Aeon_Sign_Shutdown_24;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExit.Location = new System.Drawing.Point(273, 343);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExit.Name = "btExit";
            this.btExit.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            this.btExit.Size = new System.Drawing.Size(82, 67);
            this.btExit.TabIndex = 26;
            this.btExit.Text = "ปิดหน้าจอ";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btReset
            // 
            this.btReset.Image = global::CShapeWinFormHomework01.Properties.Resources.Everaldo_Crystal_Clear_App_x_24;
            this.btReset.Location = new System.Drawing.Point(163, 343);
            this.btReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReset.Name = "btReset";
            this.btReset.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReset.Size = new System.Drawing.Size(82, 67);
            this.btReset.TabIndex = 25;
            this.btReset.Text = "ยกเลิก";
            this.btReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Image = global::CShapeWinFormHomework01.Properties.Resources.Graphicloads_100_Flat_2_Calculator_32;
            this.btCalculate.Location = new System.Drawing.Point(52, 343);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.btCalculate.Size = new System.Drawing.Size(82, 67);
            this.btCalculate.TabIndex = 24;
            this.btCalculate.Text = "คำนวณ";
            this.btCalculate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(67, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "สรุปข้อมูล";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "เข้าอบรมหัวข้อ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lbTotalFee);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbTotalParticipants);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbSelectedCourse);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(439, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 339);
            this.panel1.TabIndex = 29;
            // 
            // lbTotalFee
            // 
            this.lbTotalFee.AutoSize = true;
            this.lbTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFee.ForeColor = System.Drawing.Color.Red;
            this.lbTotalFee.Location = new System.Drawing.Point(85, 261);
            this.lbTotalFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalFee.Name = "lbTotalFee";
            this.lbTotalFee.Size = new System.Drawing.Size(38, 17);
            this.lbTotalFee.TabIndex = 33;
            this.lbTotalFee.Text = "XXX";
            this.lbTotalFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(68, 234);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "ค่าอบรมที่ต้องชำระ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalParticipants
            // 
            this.lbTotalParticipants.AutoSize = true;
            this.lbTotalParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalParticipants.ForeColor = System.Drawing.Color.Red;
            this.lbTotalParticipants.Location = new System.Drawing.Point(86, 178);
            this.lbTotalParticipants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalParticipants.Name = "lbTotalParticipants";
            this.lbTotalParticipants.Size = new System.Drawing.Size(38, 17);
            this.lbTotalParticipants.TabIndex = 31;
            this.lbTotalParticipants.Text = "XXX";
            this.lbTotalParticipants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "จำนวนผู้เข้า";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSelectedCourse
            // 
            this.lbSelectedCourse.AutoSize = true;
            this.lbSelectedCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectedCourse.ForeColor = System.Drawing.Color.Red;
            this.lbSelectedCourse.Location = new System.Drawing.Point(88, 92);
            this.lbSelectedCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSelectedCourse.Name = "lbSelectedCourse";
            this.lbSelectedCourse.Size = new System.Drawing.Size(38, 17);
            this.lbSelectedCourse.TabIndex = 29;
            this.lbSelectedCourse.Text = "XXX";
            this.lbSelectedCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHomework4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbParticipants);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbPHP);
            this.Controls.Add(this.rbIOS);
            this.Controls.Add(this.rbAndroid);
            this.Controls.Add(this.rbJava);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHomework4";
            this.Text = "FrmHomework4";
            this.Load += new System.EventHandler(this.FrmHomework4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbJava;
        private System.Windows.Forms.RadioButton rbAndroid;
        private System.Windows.Forms.RadioButton rbIOS;
        private System.Windows.Forms.RadioButton rbPHP;
        private System.Windows.Forms.TextBox tbParticipants;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSelectedCourse;
        private System.Windows.Forms.Label lbTotalFee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTotalParticipants;
        private System.Windows.Forms.Label label10;
    }
}
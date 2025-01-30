namespace CShapeWinFormHomework01
{
    partial class FrmHomework2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomework2));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAccumScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFinalScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMidtermScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbTotalScore = new System.Windows.Forms.Label();
            this.lbGPA = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(207, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "โปรแกรมผลการเรียน";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAccumScore);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbFinalScore);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbMidtermScore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbFullName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbStudentID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(515, 197);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลนักศึกษา";
            // 
            // tbAccumScore
            // 
            this.tbAccumScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAccumScore.Location = new System.Drawing.Point(182, 158);
            this.tbAccumScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAccumScore.Name = "tbAccumScore";
            this.tbAccumScore.Size = new System.Drawing.Size(282, 19);
            this.tbAccumScore.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "คะแนนเก็บ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFinalScore
            // 
            this.tbFinalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFinalScore.Location = new System.Drawing.Point(182, 125);
            this.tbFinalScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFinalScore.Name = "tbFinalScore";
            this.tbFinalScore.Size = new System.Drawing.Size(282, 19);
            this.tbFinalScore.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "คะแนนปลายภาค";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMidtermScore
            // 
            this.tbMidtermScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMidtermScore.Location = new System.Drawing.Point(182, 92);
            this.tbMidtermScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMidtermScore.Name = "tbMidtermScore";
            this.tbMidtermScore.Size = new System.Drawing.Size(282, 19);
            this.tbMidtermScore.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "คะแนนกลางภาค";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFullName
            // 
            this.tbFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullName.Location = new System.Drawing.Point(182, 58);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(282, 19);
            this.tbFullName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ชื่อ-สกุล";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbStudentID
            // 
            this.tbStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStudentID.Location = new System.Drawing.Point(182, 25);
            this.tbStudentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(282, 19);
            this.tbStudentID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "รหัสนักศึกษา";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 439);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "เกรด";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 412);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "คะแนนรวม";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(154, 385);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "ชื่อ-สกุล";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(134, 358);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "รหัสนักศึกษา";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbStudentID
            // 
            this.lbStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbStudentID.Location = new System.Drawing.Point(229, 354);
            this.lbStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(278, 18);
            this.lbStudentID.TabIndex = 19;
            this.lbStudentID.Text = "xxxxxxxxxx";
            // 
            // btExit
            // 
            this.btExit.Image = global::CShapeWinFormHomework01.Properties.Resources.Kyo_Tux_Aeon_Sign_Shutdown_24;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExit.Location = new System.Drawing.Point(379, 270);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExit.Name = "btExit";
            this.btExit.Padding = new System.Windows.Forms.Padding(4, 15, 4, 4);
            this.btExit.Size = new System.Drawing.Size(82, 67);
            this.btExit.TabIndex = 18;
            this.btExit.Text = "ปิดหน้าจอ";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btReset
            // 
            this.btReset.Image = global::CShapeWinFormHomework01.Properties.Resources.Everaldo_Crystal_Clear_App_x_24;
            this.btReset.Location = new System.Drawing.Point(268, 270);
            this.btReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReset.Name = "btReset";
            this.btReset.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReset.Size = new System.Drawing.Size(82, 67);
            this.btReset.TabIndex = 17;
            this.btReset.Text = "ยกเลิก";
            this.btReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Image = global::CShapeWinFormHomework01.Properties.Resources.Graphicloads_100_Flat_2_Calculator_32;
            this.btCalculate.Location = new System.Drawing.Point(158, 270);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.btCalculate.Size = new System.Drawing.Size(82, 67);
            this.btCalculate.TabIndex = 16;
            this.btCalculate.Text = "คำนวณ";
            this.btCalculate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lbFullName
            // 
            this.lbFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbFullName.Location = new System.Drawing.Point(229, 382);
            this.lbFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(278, 18);
            this.lbFullName.TabIndex = 20;
            this.lbFullName.Text = "xxxxxxxxxx";
            // 
            // lbTotalScore
            // 
            this.lbTotalScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTotalScore.Location = new System.Drawing.Point(229, 410);
            this.lbTotalScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalScore.Name = "lbTotalScore";
            this.lbTotalScore.Size = new System.Drawing.Size(278, 18);
            this.lbTotalScore.TabIndex = 21;
            this.lbTotalScore.Text = "xxxxxxxxxx";
            // 
            // lbGPA
            // 
            this.lbGPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGPA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbGPA.Location = new System.Drawing.Point(229, 437);
            this.lbGPA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGPA.Name = "lbGPA";
            this.lbGPA.Size = new System.Drawing.Size(278, 18);
            this.lbGPA.TabIndex = 22;
            this.lbGPA.Text = "xxxxxxxxxx";
            this.lbGPA.Click += new System.EventHandler(this.label14_Click);
            // 
            // FrmHomework2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 483);
            this.Controls.Add(this.lbGPA);
            this.Controls.Add(this.lbTotalScore);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmHomework2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมการบ้าน 2";
            this.Load += new System.EventHandler(this.FrmHomework2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccumScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFinalScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMidtermScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbTotalScore;
        private System.Windows.Forms.Label lbGPA;
    }
}
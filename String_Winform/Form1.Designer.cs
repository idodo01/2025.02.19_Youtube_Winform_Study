namespace String_Winform
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblContain = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblToLower = new System.Windows.Forms.Label();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.lblTrim = new System.Windows.Forms.Label();
            this.lblToUpper = new System.Windows.Forms.Label();
            this.lblSplit1 = new System.Windows.Forms.Label();
            this.lblSplit2 = new System.Windows.Forms.Label();
            this.lblSplit3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(34, 29);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(137, 15);
            this.lblText.TabIndex = 0;
            this.lblText.Text = " Sample, Test, Text";
            this.lblText.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equals";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Length";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "SubString";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Split";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Replace";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "ToLower";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "ToUpper";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Trim";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblContain
            // 
            this.lblContain.AutoSize = true;
            this.lblContain.Location = new System.Drawing.Point(130, 104);
            this.lblContain.Name = "lblContain";
            this.lblContain.Size = new System.Drawing.Size(15, 15);
            this.lblContain.TabIndex = 10;
            this.lblContain.Text = "-";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(130, 140);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(15, 15);
            this.lblEquals.TabIndex = 11;
            this.lblEquals.Text = "-";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(130, 213);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(15, 15);
            this.lblReplace.TabIndex = 13;
            this.lblReplace.Text = "-";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(130, 177);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(15, 15);
            this.lblLength.TabIndex = 12;
            this.lblLength.Text = "-";
            // 
            // lblToLower
            // 
            this.lblToLower.AutoSize = true;
            this.lblToLower.Location = new System.Drawing.Point(457, 141);
            this.lblToLower.Name = "lblToLower";
            this.lblToLower.Size = new System.Drawing.Size(15, 15);
            this.lblToLower.TabIndex = 15;
            this.lblToLower.Text = "-";
            // 
            // lblSubstring
            // 
            this.lblSubstring.AutoSize = true;
            this.lblSubstring.Location = new System.Drawing.Point(457, 105);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(15, 15);
            this.lblSubstring.TabIndex = 14;
            this.lblSubstring.Text = "-";
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(457, 213);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(15, 15);
            this.lblTrim.TabIndex = 17;
            this.lblTrim.Text = "-";
            // 
            // lblToUpper
            // 
            this.lblToUpper.AutoSize = true;
            this.lblToUpper.Location = new System.Drawing.Point(457, 177);
            this.lblToUpper.Name = "lblToUpper";
            this.lblToUpper.Size = new System.Drawing.Size(15, 15);
            this.lblToUpper.TabIndex = 16;
            this.lblToUpper.Text = "-";
            // 
            // lblSplit1
            // 
            this.lblSplit1.AutoSize = true;
            this.lblSplit1.Location = new System.Drawing.Point(130, 254);
            this.lblSplit1.Name = "lblSplit1";
            this.lblSplit1.Size = new System.Drawing.Size(15, 15);
            this.lblSplit1.TabIndex = 18;
            this.lblSplit1.Text = "-";
            // 
            // lblSplit2
            // 
            this.lblSplit2.AutoSize = true;
            this.lblSplit2.Location = new System.Drawing.Point(130, 293);
            this.lblSplit2.Name = "lblSplit2";
            this.lblSplit2.Size = new System.Drawing.Size(15, 15);
            this.lblSplit2.TabIndex = 19;
            this.lblSplit2.Text = "-";
            // 
            // lblSplit3
            // 
            this.lblSplit3.AutoSize = true;
            this.lblSplit3.Location = new System.Drawing.Point(130, 327);
            this.lblSplit3.Name = "lblSplit3";
            this.lblSplit3.Size = new System.Drawing.Size(15, 15);
            this.lblSplit3.TabIndex = 20;
            this.lblSplit3.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 415);
            this.Controls.Add(this.lblSplit3);
            this.Controls.Add(this.lblSplit2);
            this.Controls.Add(this.lblSplit1);
            this.Controls.Add(this.lblTrim);
            this.Controls.Add(this.lblToUpper);
            this.Controls.Add(this.lblToLower);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblContain);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblContain;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblToLower;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.Label lblToUpper;
        private System.Windows.Forms.Label lblSplit1;
        private System.Windows.Forms.Label lblSplit2;
        private System.Windows.Forms.Label lblSplit3;
    }
}


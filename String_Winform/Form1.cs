using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Winform
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sample, Test, Text
            String strText = lblText.Text;

            // "test"라는 문자열이 포함되어있는지
            lblContain.Text = strText.Contains("Test").ToString(); // True

            // "test"라는 문자열과 일치하는지
            lblEquals.Text = strText.Equals("Test").ToString(); // False

            // 문자열의 길이
            lblLength.Text = strText.Length.ToString();

            // 해당 문자열을 다른 문자열로 바꾸기
            lblReplace.Text = strText.Replace("Test","I Can").ToString();

            // 특정 문자열로 문자열 분리시키기
            string[] strSplit = strText.Split(',');
            lblSplit1.Text = strSplit[0].ToString(); // Sample
            lblSplit2.Text = strSplit[1].ToString(); // Test
            lblSplit3.Text = strSplit[2].ToString(); // Text

            // 해당 인덱스 문자열만 가져오기
            lblSubstring.Text = strText.Substring(3, 5).ToString();

            // 모두 소문자로
            lblToLower.Text = strText.ToLower().ToString();

            // 모두 대문자로
            lblToUpper.Text = strText.ToUpper().ToString();

            // 공백 제거 (문자열 중간이 아닌, 문자열의 앞뒤부분의 공백)
            lblTrim.Text = strText.Trim().ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        
    }
}

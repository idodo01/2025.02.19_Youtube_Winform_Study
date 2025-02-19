using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataType_Winform
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEx_Click(object sender, EventArgs e)
        {

        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                // short 범위 : -32,768 ~ 32,767
                short sNumber = short.Parse(tboxNumber.Text);
                lblShort.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch(Exception ex) {
                lblException.Text = ex.ToString();
            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                // int 범위 : -2,147,483,648 ~ 2,147,483,647
                int iNumber = int.Parse(tboxNumber.Text);
                lblInt.Text = iNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double dNumber = double.Parse(tboxNumber.Text);
                lblDouble.Text = dNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_02
{
    
    public partial class CsharpFm_02 : Form
    {
        string LoanAmount = "100000";
        string DeadLine = "2";
        string InterestRate = "10";
        string DownPayment = "0";

        public CsharpFm_02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("月付額： " + getMonthlyPayment() + " 元 ");
        }
    


    
        public double getMonthlyPayment() //月付額公式
        {
            double LA = double.Parse(LoanAmount);
            double DL = double.Parse(DeadLine);
            double IR = double.Parse(InterestRate);
            double DP = double.Parse(DownPayment);

            double MIR = IR * 0.01 / 12;              //月利率
            double M1 = Math.Pow((1 + MIR), 12 * DL); //(1+月利率)期數次方
            double M2 = M1 * MIR;                     //(1+月利率)期數次方 * 月利率
            double M3 = M1 - 1;                       //(1+月利率)期數次方 - 1
            double M4 = M2 / M3;                      //(1+月利率)期數次方 * 月利率 / 期數次方 - 1
            double M5 = LA - DP;                      //(本金 - 頭期)
            double M6 = M4 * M5;                      //[(1+月利率)期數次方 * 月利率 / 期數次方 - 1] * (本金 - 頭期)

            return M6;
        }

        public double getTotalPaymentAmount()            //總付款公式
        {
            
            double monthlyPayment = getMonthlyPayment();

            double totalPaymentAmount = monthlyPayment * 12 * 2;

            return totalPaymentAmount;
        }

        private void but_02_Click(object sender, EventArgs e)
        {
            LoanAmount = txt_01.Text;
            DeadLine = txt_02.Text;
            InterestRate = txt_03.Text;
            DownPayment = txt_04.Text;
            double totalPaymentAmount = getTotalPaymentAmount();
            MessageBox.Show(" 總付款: " + totalPaymentAmount);
        }
    }
}




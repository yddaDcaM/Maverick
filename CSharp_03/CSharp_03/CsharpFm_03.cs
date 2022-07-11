using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_03
{
    public partial class CsharpFm_03 : Form
    {
        int sum = 0 ;
        int BeerCount = 0;
        int WhiskyCount = 0;
        int TequilaCount = 0;
        int WineCount = 0;
        int BeerPrice = 150;
        int BeerTotalPrice = 0;
        int WhiskyPrice = 450;
        int WhiskyTotalPrice = 0;
        int TequilaPrice = 350;
        int TequilaTotalPrice = 0;
        int WinePrice = 350;
        int WineTotalPrice = 0;



        string total = "";

        public CsharpFm_03()
        {
            InitializeComponent();
        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            
            BeerCount = BeerCount + 1;
            BeerTotalPrice = BeerPrice * BeerCount;
            sum = sum + BeerPrice;
            total = "";

            txt_01.Text = Convert.ToString(" NT$ " + sum);
            
            if (BeerCount > 0)
            {
                total = total + " 啤酒Beer x " + BeerCount + " ,共NT " + BeerTotalPrice + Environment.NewLine;
            }
            if (WhiskyCount > 0)
            {
                total = total + " 威士忌Whisky x " + WhiskyCount + " ,共NT " + WhiskyTotalPrice + Environment.NewLine;
            }
            if (TequilaCount > 0) 
            {
                total = total + " 龍舌蘭Tequila x " + TequilaCount + " ,共NT " + TequilaTotalPrice + Environment.NewLine;
            }
            if (WineCount > 0) 
            {
                total = total + " 紅酒Wine x " + WineCount + " ,共NT " + WineTotalPrice + Environment.NewLine;
            }

            txt_02.Text = total;







        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            
            WhiskyCount = WhiskyCount + 1;
            WhiskyTotalPrice = WhiskyPrice * WhiskyCount;
            sum = sum + WhiskyPrice;
            total = "";

            txt_01.Text = Convert.ToString(" NT$ " + sum);

            if (BeerCount > 0)
            {
                total = total + " 啤酒Beer x " + BeerCount + " ,共NT " + BeerTotalPrice + Environment.NewLine;
            }
            if (WhiskyCount > 0)
            {
                total = total + " 威士忌Whisky x " + WhiskyCount + " ,共NT " + WhiskyTotalPrice + Environment.NewLine;
            }
            if (TequilaCount > 0)
            {
                total = total + " 龍舌蘭Tequila x " + TequilaCount + " ,共NT " + TequilaTotalPrice + Environment.NewLine;
            }
            if (WineCount > 0)
            {
                total = total + " 紅酒Wine x " + WineCount + " ,共NT " + WineTotalPrice + Environment.NewLine;
            }

            txt_02.Text = total;
        }

        private void btn_03_Click(object sender, EventArgs e)
        {

            TequilaCount = TequilaCount + 1;
            TequilaTotalPrice = TequilaPrice * TequilaCount;
            sum = sum + TequilaPrice;
            total = "";

            txt_01.Text = Convert.ToString(" NT$ " + sum);

            if (BeerCount > 0)
            {
                total = total + " 啤酒Beer x " + BeerCount + " ,共NT " + BeerTotalPrice + Environment.NewLine;
            }
            if (WhiskyCount > 0)
            {
                total = total + " 威士忌Whisky x " + WhiskyCount + " ,共NT " + WhiskyTotalPrice + Environment.NewLine;
            }
            if (TequilaCount > 0)
            {
                total = total + " 龍舌蘭Tequila x " + TequilaCount + " ,共NT " + TequilaTotalPrice + Environment.NewLine;
            }
            if (WineCount > 0)
            {
                total = total + " 紅酒Wine x " + WineCount + " ,共NT " + WineTotalPrice + Environment.NewLine;
            }

            txt_02.Text = total;

        }

        private void btn_04_Click(object sender, EventArgs e)
        {

            WineCount = WineCount + 1;
            WineTotalPrice = WinePrice * WineCount;
            sum = sum + WinePrice;
            total = "";

            txt_01.Text = Convert.ToString(" NT$ " + sum);

            if (BeerCount > 0)
            {
                total = total + " 啤酒Beer x " + BeerCount + " ,共NT " + BeerTotalPrice + Environment.NewLine;
            }
            if (WhiskyCount > 0)
            {
                total = total + " 威士忌Whisky x " + WhiskyCount + " ,共NT " + WhiskyTotalPrice + Environment.NewLine;
            }
            if (TequilaCount > 0)
            {
                total = total + " 龍舌蘭Tequila x " + TequilaCount + " ,共NT " + TequilaTotalPrice + Environment.NewLine;
            }
            if (WineCount > 0)
            {
                total = total + " 紅酒Wine x " + WineCount + " ,共NT " + WineTotalPrice + Environment.NewLine;
            }

            txt_02.Text = total;
        }

        private void btn_07_Click(object sender, EventArgs e)
        {

            sum = 0;
            BeerCount = 0;
            WhiskyCount = 0;
            TequilaCount = 0;
            WineCount = 0;
            BeerTotalPrice = 0;
            WhiskyTotalPrice = 0;
            TequilaTotalPrice = 0;
            WineTotalPrice = 0;
            total = "";
            txt_01.Text = " NT$0 ";
            txt_02.Text = " 尚未點餐 ";
        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            
            
            
            if (sum == 0)
            {
                MessageBox.Show(" 尚未點餐 ");
            } 

            else
            {
                MessageBox.Show("總共NT$" + sum);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sum == 0)
            {
                MessageBox.Show(" 尚未點餐 ");
            }

            else {
                MessageBox.Show("總共NT$" + sum + Environment.NewLine + "打折後NT$ " + sum * 0.9 );
            }
        }
    }
}


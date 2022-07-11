using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_08
{
    public partial class CSharpFm_08 : Form
    {
        public CSharpFm_08()
        {
            InitializeComponent();
        }

        double num1 ;
        double num2 ;
        double num3 ;

        //tryparse() { 
        //}

        private void btn_01_Click(object sender, EventArgs e)
        {
            
            //bool number1 = Double.TryParse(textBox1.Text,out num1);

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            
            num3 = num1 + num2;

            textBox3.Text = "" + num3;
        }

        private void btn_04_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);



            num3 = num1 / num2;

            textBox3.Text = "" + num3;
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);



            num3 = num1 - num2;

            textBox3.Text = "" + num3;
        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            


            num3 = num1 + num2;

            textBox3.Text = "" + num3;



            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);



            num3 = num1 * num2;

            textBox3.Text = "" + num3;
        }
    }
}

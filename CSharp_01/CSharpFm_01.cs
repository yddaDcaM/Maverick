using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_01
{
    public partial class CSharpFm_01 : Form
    {
        public CSharpFm_01()
        {
            InitializeComponent();
        }

        

        private void btn_01_Click(object sender, EventArgs e)
        {
            string Name = txt_01.Text;

            string Englishname = txt_02.Text;

            string Sexaul = txt_03.Text;

            string Starsign = txt_04.Text;

            MessageBox.Show(" Hello " + Environment.NewLine
                                      + " My name is" + Name + Environment.NewLine
                                      + " Just call  me " + Englishname + Environment.NewLine
                                      + " I'm " + Sexaul + Environment.NewLine
                                      + " and a  " + Starsign + Environment.NewLine
                                      + " Have a good day. "
                                      );
        }

        private void btn_02_Click_1(object sender, EventArgs e)
        {
            string Name = txt_01.Text;

            string Englishname = txt_02.Text;

            string Sexaul = txt_03.Text;

            string Starsign = txt_04.Text;

            MessageBox.Show(" Hi " + Environment.NewLine
                                      + " My name is" + Name + Environment.NewLine
                                      + " Just call  me " + Englishname + Environment.NewLine
                                      + " I'm " + Sexaul + Environment.NewLine
                                      + " and a  " + Starsign + Environment.NewLine
                                      + " Have a lovley day. "
                                      );
        }
    }
}

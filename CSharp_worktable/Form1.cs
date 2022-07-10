using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_02;
using CSharp_03;
using CSHarp_04;
using CSharp_05;
using CSharp_08;
using CSharp_01;

#region
/*
1.改表單名稱
2.加入現有專案---3
3.worktable加入參考---
4.using每個作業的命名空間
*/
#endregion


namespace CSharp_worktable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            CSharp_01.CSharpFm_01 winFmApp1 = new CSharpFm_01();
            winFmApp1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(winFmApp1);
            winFmApp1.Show();
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            CSharp_02.CsharpFm_02 winFmApp1 = new CsharpFm_02();
            winFmApp1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(winFmApp1);
            winFmApp1.Show();
        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            CSharp_03.CsharpFm_03 winFmApp1 = new CsharpFm_03();
            winFmApp1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(winFmApp1);
            winFmApp1.Show();
        }
    

        private void btn_04_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            CSHarp_04.back_01 winFmApp1 = new back_01();
            winFmApp1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(winFmApp1);
            winFmApp1.Show();
        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            CSharp_05.CSharpFm_05 winFmApp1 = new CSharpFm_05();
            winFmApp1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(winFmApp1);
            winFmApp1.Show();
        }

        private void btn_06_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            CSharp_08.CSharpFm_08 winFmApp1 = new CSharpFm_08();
            winFmApp1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(winFmApp1);
            winFmApp1.Show();
        }
    }
}

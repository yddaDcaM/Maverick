using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHarp_04
{
    public partial class back_01 : Form
    {
        string name;
        int chineseScore;
        int englishScore;
        int mathScore;
            
        public back_01()
        {
            InitializeComponent();
        }
        
        private void btn_01_Click(object sender, EventArgs e)
        {
            name = txt_01.Text;
            chineseScore = int.Parse(txt_02.Text);
            englishScore = int.Parse(txt_03.Text);
            mathScore = int.Parse(txt_04.Text);
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            string allScore = "姓名:" + name + "\n" + "國文:" + chineseScore + "\n" +
                                " 英文:" + englishScore + "\n" + " 數學:" + mathScore +
                                "\n";
            lbl_05.Text= allScore;
        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            int highestScore = -1;
            string highestSubject = "";
            int lowestScore = 101;
            string lowestSubject = "";
            string highLowScore;

            int[] scores = { chineseScore, englishScore, mathScore };
            string[] subjects = { "國文", "英文", "數學" };
            // scores[0], scores[1], scores[2]

            for (int i = 0; i < 3; i++)
            {
                if (scores[i] > highestScore)
                {
                    highestScore = scores[i];
                    highestSubject = subjects[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (scores[i] < lowestScore)
                {
                    lowestScore = scores[i];
                    lowestSubject = subjects[i];
                }
            }

            highLowScore = "最高分科目 " + highestSubject + highestScore + "分" + "\n" +
                "最低分科目" + lowestSubject + lowestScore + "分";

            lbl_06.Text = highLowScore;
        }
    }
}

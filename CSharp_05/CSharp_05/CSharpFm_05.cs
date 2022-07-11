using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_05
{
    public partial class CSharpFm_05 : Form
    {
        public CSharpFm_05()
        {
            InitializeComponent();
        }

        string name;
        int chineseScore;
        int englishScore;
        int mathScore;
        int totalScore;
        int allscore;
        int evenScore;
        int lowestScore;
        string lowestSubject;
        int highestScore;
        string highestSubject;
        string allScore = "";
        int count = 0;
        int chineseScoreSum = 0;
        int englishScoreSum = 0;
        int mathScoreSum = 0;
        int highestChineseScore = 0;
        int highestEnglishScore = 0;
        int highestMathScore = 0;
        int lowestChineseScore = 100;
        int lowestEnglishScore = 100;
        int lowestMathScore = 100;

        private void btn_01_Click(object sender, EventArgs e)
        {       
            name = txt_01.Text;

            chineseScore = int.Parse(txt_02.Text);
            englishScore = int.Parse(txt_03.Text);
            mathScore = int.Parse(txt_04.Text);

            chineseScoreSum = chineseScoreSum + chineseScore;
            englishScoreSum = englishScoreSum + englishScore;
            mathScoreSum = mathScoreSum + mathScore;

            setSubjectsHighestScore(chineseScoreSum, englishScoreSum, mathScoreSum);
            setSubjectsLowestScore(chineseScoreSum, englishScoreSum, mathScoreSum);

            totalScore = chineseScore + englishScore + mathScore;
            evenScore = (chineseScore + englishScore + mathScore) / 3;

            lowestScore = 101;
            lowestSubject = "";
            highestScore = -1;
            highestSubject = "";
            count = count + 1;
            int[] scores = { chineseScore, englishScore, mathScore };
            string[] subject = { "國文", "英文", "數學" };
            //score[0],score[1],score[2]

            for (int i = 0; i < 3; i++)
            {
                if (scores[i] > highestScore)
                {
                    highestScore = scores[i];
                    highestSubject = subject[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (scores[i] < lowestScore)
                {
                    lowestScore = scores[i];
                    lowestSubject = subject[i];
                }
            }

            allScore = allScore + name.PadRight(10)
                        + Convert.ToString(chineseScore).PadRight(10)
                        + Convert.ToString(englishScore).PadRight(10)
                        + Convert.ToString(mathScore).PadRight(8)
                        + Convert.ToString(totalScore).PadRight(9)
                        + Convert.ToString(evenScore).PadRight(10)
                        + Convert.ToString(lowestScore).PadRight(8)
                        + Convert.ToString(highestScore).PadRight(8)
                        + "\n";

            lbl_05.Text = allScore;
        }

        Random ranNumbers = new Random();        //randonNumber亂數
        private void btn_02_Click(object sender, EventArgs e)
        {
            int ran1 = ranNumbers.Next(0, 101);
            int ran2 = ranNumbers.Next(0, 101);
            int ran3 = ranNumbers.Next(0, 101);

            chineseScoreSum = chineseScoreSum + ran1;
            englishScoreSum = englishScoreSum + ran2;
            mathScoreSum = mathScoreSum + ran3;

            setSubjectsHighestScore(ran1, ran2, ran3);
            setSubjectsLowestScore(ran1, ran2, ran3);

            totalScore = ran1 + ran2 + ran3;
            evenScore = (ran1 + ran2 + ran3) / 3;

            lowestScore = 101;
            lowestSubject = "";
            highestScore = -1;
            highestSubject = "";

            int[] scores = { ran1, ran2, ran3 };
            string[] subject = { "國文", "英文", "數學" };
            //score[0],score[1],score[2]

            for (int i = 0; i < 3; i++)
            {
                if (scores[i] > highestScore)
                {
                    highestScore = scores[i];
                    highestSubject = subject[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (scores[i] < lowestScore)
                {
                    lowestScore = scores[i];
                    lowestSubject = subject[i];
                }
            }

            


            //randonNumber 排列公式

            count = count + 1;

            allScore =  allScore
                        + Convert.ToString(count).PadRight(12)
                        + Convert.ToString(ran1).PadRight(9)
                        + Convert.ToString(ran2).PadRight(10)
                        + Convert.ToString(ran3).PadRight(10)
                        + Convert.ToString(ran1 + ran2 + ran3).PadRight(9)
                        + Convert.ToString((ran1 + ran2 + ran3) / 3).PadRight(9)
                        + Convert.ToString(lowestScore).PadRight(8)
                        + Convert.ToString(highestScore).PadRight(8)
                        + "\n";

            lbl_05.Text = allScore;
        }

        private void btn_04_Click(object sender, EventArgs e)
        {
            count = 0;
            allScore = "";
            lbl_05.Text = "";
            lbl_06.Text = "";
            chineseScoreSum = 0;
            englishScoreSum = 0;
            mathScoreSum = 0;
        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            Random ranNumbers = new Random();        //randonNumber亂數
            for (int i = 0; i < 20; i++)
            {
                int ran1 = ranNumbers.Next(0, 101);
                int ran2 = ranNumbers.Next(0, 101);
                int ran3 = ranNumbers.Next(0, 101);

                chineseScoreSum = chineseScoreSum + ran1;
                englishScoreSum = englishScoreSum + ran2;
                mathScoreSum = mathScoreSum + ran3;

                setSubjectsHighestScore(ran1, ran2, ran3);
                setSubjectsLowestScore(ran1, ran2, ran3);

                totalScore = ran1 + ran2 + ran3;
                evenScore = (ran1 + ran2 + ran3) / 3;

                lowestScore = 101;
                lowestSubject = "";
                highestScore = -1;
                highestSubject = "";

                int[] scores = { ran1, ran2, ran3 };
                string[] subject = { "國文", "英文", "數學" };
                //score[0],score[1],score[2]

                for (int z = 0; z < 3; z++)
                {
                    if (scores[z] > highestScore)
                    {
                        highestScore = scores[z];
                        highestSubject = subject[z];
                    }
                }

                for (int z = 0; z < 3; z++)
                {
                    if (scores[z] < lowestScore)
                    {
                        lowestScore = scores[z];
                        lowestSubject = subject[z];
                    }
                }
                count = count + 1;
                allScore = allScore
                            + Convert.ToString(count).PadRight(12)
                            + Convert.ToString(ran1).PadRight(9)
                            + Convert.ToString(ran2).PadRight(10)
                            + Convert.ToString(ran3).PadRight(10)
                            + Convert.ToString(ran1 + ran2 + ran3).PadRight(9)
                            + Convert.ToString((ran1 + ran2 + ran3) / 3).PadRight(9)
                            + Convert.ToString(lowestScore).PadRight(8)
                            + Convert.ToString(highestScore).PadRight(8)
                            + "\n";
            }
            lbl_05.Text = allScore;

        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            lbl_06.Text = "總分 " + chineseScoreSum + " " + englishScoreSum + " " + mathScoreSum + "\n" +
                        "平均 " + chineseScoreSum / count + " " + englishScoreSum / count + " " + mathScoreSum / count + "\n" +
                        "最高分 " + highestChineseScore + " " + highestEnglishScore + " " + highestMathScore + "\n" +
                        "最低分" + lowestChineseScore + " " + lowestEnglishScore + " " + lowestMathScore;
        }

        private void setSubjectsHighestScore(int chineseScore, int englishScore, int mathScore)
        {
            if (chineseScore > highestChineseScore)
            {
                highestChineseScore = chineseScore;
            }
            if (englishScore > highestEnglishScore)
            {
                highestEnglishScore = englishScore;
            }
            if (mathScore > highestMathScore)
            {
                highestMathScore = mathScore;
            }
        }
        private void setSubjectsLowestScore(int chineseScore, int englishScore, int mathScore)
        {
            if (chineseScore < lowestChineseScore)
            {
                lowestChineseScore = chineseScore;
            }
            if (englishScore < lowestEnglishScore)
            {
                lowestEnglishScore = englishScore;
            }
            if (mathScore < lowestMathScore)
            {
                lowestMathScore = mathScore;
            }

        }
    }
}

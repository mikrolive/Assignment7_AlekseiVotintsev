using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            string[] correctArr = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
            string[] stunderArr = new string[20];
            List<string> incorrectList = new List<string>();

            int correct = 0, incorrect = 0, index = 0, question = 0;

            string file = "C:\\Users\\mikro\\OneDrive\\Рабочий стол\\answers.txt";

            try
            {
                StreamReader inputFile = File.OpenText(file);
                while (!inputFile.EndOfStream)
                {
                    stunderArr[index] = inputFile.ReadLine();

                    if (stunderArr[index] == correctArr[index])
                        correct++;
                    else
                    {
                        question = index + 1;
                        incorrectList.Add(question.ToString());
                    }

                    index++;
                }

                inputFile.Close();

                if (correct >= 15)
                {
                    MessageBox.Show("You passed");
                }
                else
                {
                    MessageBox.Show("You failed");
                }
                foreach (string str in incorrectList)
                {
                    listBoxIncorrect.Items.Add(str);
                }
                CorrectCount.Text = correct.ToString();
                incorrect = 20 - correct;
                IncorrectCount.Text = incorrect.ToString();
            }
            catch (Exception)
            {
                
            }
        }
    }
}

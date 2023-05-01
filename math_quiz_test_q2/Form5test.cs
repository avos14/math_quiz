using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_quiz_test_q2
{
    public partial class Form5test : Form
    {
        public int timeLeft;
        protected int[] answers = new int[10];
        protected int[] points = new int[10];
        System.Windows.Forms.TextBox[] userAnswers = new System.Windows.Forms.TextBox[10];

        public Form5test(string testNumber)
        {
            InitializeComponent();
            loadTestData(testNumber);
            userAnswers[0] = textBox1answer;
            userAnswers[1] = textBox2answer;
            userAnswers[2] = textBox3answer;
            userAnswers[3] = textBox4answer;
            userAnswers[4] = textBox5answer;
            userAnswers[5] = textBox6answer;
            userAnswers[6] = textBox7answer;
            userAnswers[7] = textBox8answer;
            userAnswers[8] = textBox9answer;
            userAnswers[9] = textBox10answer;
        }

        protected void loadTestData(string testNumber)
        {
            string filename = "EXAMS\\gameExam" + testNumber + ".txt";
            string[] fileLines = System.IO.File.ReadAllLines(filename);
            // line format is : "num;question;answer;points"
            System.Windows.Forms.Label[] labelQ = new System.Windows.Forms.Label[10];
            labelQ[0] = this.labelQ1;
            labelQ[1] = this.labelQ2;
            labelQ[2] = this.labelQ3;
            labelQ[3] = this.labelQ4;
            labelQ[4] = this.labelQ5;
            labelQ[5] = this.labelQ6;
            labelQ[6] = this.labelQ7;
            labelQ[7] = this.labelQ8;
            labelQ[8] = this.labelQ9;
            labelQ[9] = this.labelQ10;

            int i = 0;
            foreach (string line in fileLines)
            {
                int p1 = line.IndexOf(";");
                int p2 = line.IndexOf(";", p1 + 1);
                int p3 = line.IndexOf(";", p2 + 1);
                string question = line.Substring(p1 + 1, p2 - p1 - 1);
                string answer = line.Substring(p2 + 1, p3 - p2 - 1);
                string point = line.Substring(p3 + 1);

                labelQ[i].Text = question;
                answers[i] = Int32.Parse(answer);
                points[i] = Int32.Parse(point);
                labelQ[i].AutoSize = false;
                labelQ[i].Width = 75;

                i++;
            }
        }


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form2.getTheInstance().Show();
            this.Close();
        }

        private void label5time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                label5time.Text = timeLeft.ToString();
            }
            if (timeLeft == 0)
            {
                buttonDone.Enabled = false;
                buttonStart.Enabled = true;
                buttonPause.Enabled = false;
                buttonExit.Enabled = true;
                buttonresume.Enabled = false;
                timer1.Stop();
                label5time.Text = "";
                MessageBox.Show("Your test time has over");
                onTestEnd();
            }
        }

        private void Form5test_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            buttonDone.Enabled = false;
            buttonStart.Enabled = true;
            buttonPause.Enabled = false;
            buttonExit.Enabled = true;
            buttonresume.Enabled = false;
            timer1.Stop();
            onTestEnd();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timeLeft = 120;
            buttonStart.Enabled = false;
            buttonPause.Enabled = true;
            buttonDone.Enabled = true;
            buttonExit.Enabled = true;
            buttonresume.Enabled = false;
            timer1.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form1.getTheInstance().Close();
            this.Close();
            Form4.RequestClose();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonPause.Enabled = false;
            buttonDone.Enabled = false;
            buttonExit.Enabled = true;
            buttonresume.Enabled = true;
            timer1.Stop();
        }

        private void buttonresume_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttonDone.Enabled = true;
            buttonStart.Enabled = false;
            buttonPause.Enabled = true;
            buttonExit.Enabled = true;
            buttonresume.Enabled = false;
        }

        private void onTestEnd()
        {
            // calc test grade
            int grade = 0;
            for (int i=0; i<10; i++)
            {
                if (Int32.Parse(userAnswers[i].Text) == answers[i])
                    grade += points[i];
            }

            this.labelscore.Text = "" + grade;

            // show message box
            if (grade < 50) {
                MessageBox.Show("You have failed the test, we hope you do better next time");
            }
            else if (grade < 80) {
                MessageBox.Show("You have finished the test, it was ok you can better");
            }
            else
            {
                MessageBox.Show("You have finished the test, it was excellent, very nice!!!");
            }

            // save test stats to file
            saveResultStatistics();
        }

        protected void saveResultStatistics()
        {
            string datestr = DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss");
            string filename = "EXAMS\\examData_" + datestr + ".txt";
            string[] lines = new string[11];

            for (int i = 0; i < 10; i++)
            {
                lines[i] = "user answer = " + userAnswers[i].Text + "; correct answer is :" + answers[i];
            }
            lines[10] = "grade: " + labelscore.Text;
            System.IO.File.WriteAllLines(filename, lines);

            string errors = "";
            for (int i = 0; i < 10; i++)
            {
                if (Int32.Parse(userAnswers[i].Text) != answers[i])
                {
                    errors += "question # " + (i + 1) + " answer was wrong\n";
                }
            }
            System.IO.File.WriteAllText("EXAMS\\errors.txt", errors);
        }
    }
}

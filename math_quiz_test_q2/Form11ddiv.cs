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
    public partial class Form11ddiv : Form
    {
        public int z;
        public int b;
        public int x;
        public int d;
        public int m;
        public int f;
        public int u;
        public int h;
        public int y;
        public int k;
        public int timeLeft;
        public Form11ddiv()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form7d f7d = new Form7d(); // Instantiate a Form7d object.
            f7d.ShowDialog(); // Show Form7d and
            this.Close();
        }

        private void buttonpause_Click(object sender, EventArgs e)
        {
            buttonstart.Enabled = false;
            buttonpause.Enabled = false;
            buttondone.Enabled = false;
            buttonexit.Enabled = true;
            buttonresume.Enabled = true;
            timer1.Stop();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Form1.getTheInstance().Close();
            this.Close();
            Form4.RequestClose();
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            textBox1ab.Text = "";
            textBox2ab.Text = "";
            textBox3ab.Text = "";
            textBox4ab.Text = "";
            textBox5ab.Text = "";
            labelscore.Text = "0";
            timeLeft = 40;
            labeleror1.Visible = false;
            labeleror2.Visible = false;
            labeleror3.Visible = false;
            labeleror4.Visible = false;
            labeleror5.Visible = false;
            Random r = new Random();
            z = r.Next(9) + 1;
            b = r.Next(9) + 1;
            x = r.Next(9) + 1;
            d = r.Next(9) + 1;
            m = r.Next(9) + 1;
            f = r.Next(9) + 1;
            u = r.Next(9) + 1;
            h = r.Next(9) + 1;
            y = r.Next(9) + 1;
            k = r.Next(9) + 1;

            int a = z * b;
            label1a.Text = a.ToString();
            label1b.Text = b.ToString();
            int c = x * d;
            label2a.Text = c.ToString();
            label2b.Text = d.ToString();
            int j = m * f;
            label3a.Text = j.ToString();
            label3b.Text = f.ToString();
            int g = u * h;
            label4a.Text = g.ToString();
            label4b.Text = h.ToString();
            int i = y * k;
            label5a.Text = i.ToString();
            label5b.Text = k.ToString();
            buttonstart.Enabled = false;
            buttonpause.Enabled = true;
            buttondone.Enabled = true;
            buttonexit.Enabled = true;
            buttonresume.Enabled = false;
            timer1.Start();
        }

        private void buttondone_Click(object sender, EventArgs e)

        {
            onPractiveEnd();
        }
        protected void onPractiveEnd()
        {
            string[] statFileLines = new string[6];
            buttondone.Enabled = false;
            buttonstart.Enabled = true;
            buttonpause.Enabled = false;
            buttonexit.Enabled = true;
            buttonresume.Enabled = false;
            timer1.Stop();
            int score = 0;
            statFileLines[0] = textBox1ab.Text;
            if (textBox1ab.Text == z.ToString())
                score += 20;
            else
                score -= 5;
            statFileLines[1] = textBox2ab.Text;
            if (textBox2ab.Text == x.ToString())
                score += 20;
            else
                score -= 5;
            statFileLines[2] = textBox3ab.Text;
            if (textBox3ab.Text == m.ToString())
                score += 20;
            else
                score -= 5;
            statFileLines[3] = textBox4ab.Text;
            if (textBox4ab.Text == u.ToString())
                score += 20;
            else
                score -= 5;
            statFileLines[4] = textBox5ab.Text;
            if (textBox5ab.Text == y.ToString())
                score += 20;
            else
                score -= 5;
            labelscore.Text = "" + score;
            string datestr = DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss");
            string filename = "EXAMS\\tirgulData_" + datestr + ".txt";
            statFileLines[5] = "score: " + labelscore.Text;
            System.IO.File.WriteAllLines(filename, statFileLines);

            // show message box
            if (score < 50)
            {
                MessageBox.Show("You have failed the practice, we hope you do better next time");
            }
            else if (score < 80)
            {
                MessageBox.Show("You have finished the practice, it was ok you can better");
            }
            else
            {
                MessageBox.Show("You have finished the practice, it was excellent, very nice!!!");
            }

            MessageBoxManager.Abort = "Error";
            MessageBoxManager.Retry = "Retry";
            MessageBoxManager.Ignore = "Close";
            MessageBoxManager.Register();
            DialogResult userSelection = MessageBox.Show("Select: show errors, or Retry this practice", "practice Ended", MessageBoxButtons.AbortRetryIgnore);
            MessageBoxManager.Unregister();
            switch (userSelection)
            {
                case DialogResult.Abort:
                    showErrors();
                    break;
                case DialogResult.Retry:
                    retryPractice();
                    break;
                default:
                    Form7d f7d = new Form7d(); // Instantiate a Form7d object.
                    f7d.ShowDialog(); // Show Form7d and
                    this.Close();
                    break;
            }
        }

        private void retryPractice()
        {
            textBox1ab.Text = "";
            textBox2ab.Text = "";
            textBox3ab.Text = "";
            textBox4ab.Text = "";
            textBox5ab.Text = "";
            labelscore.Text = "0";
            timeLeft = 40;
            timer1.Start();
            buttondone.Enabled = true;
        }

        private void showErrors()
        {
            if (textBox1ab.Text.Length > 0 && Int32.Parse(textBox1ab.Text) != (z))
            {
                labeleror5.Text = "Your answer is wrong, the correct answer is " + (z);
                labeleror5.Visible = true;
            }
            if (textBox2ab.Text.Length > 0 && Int32.Parse(textBox2ab.Text) != (x))
            {
                labeleror4.Text = "Your answer is wrong, the correct answer is " + (x);
                labeleror4.Visible = true;
            }
            if (textBox3ab.Text.Length > 0 && Int32.Parse(textBox3ab.Text) != (m))
            {
                labeleror3.Text = "Your answer is wrong, the correct answer is " + (m);
                labeleror3.Visible = true;
            }
            if (textBox4ab.Text.Length > 0 && Int32.Parse(textBox4ab.Text) != (u))
            {
                labeleror2.Text = "Your answer is wrong, the correct answer is " + (u);
                labeleror2.Visible = true;
            }
            if (textBox5ab.Text.Length > 0 && Int32.Parse(textBox5ab.Text) != (y))
            {
                labeleror1.Text = "Your answer is wrong, the correct answer is " + (y);
                labeleror1.Visible = true;
            }
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                labeltime.Text = timeLeft.ToString();
            }
            if (timeLeft == 0)
            {
                onPractiveEnd();
                labeltime.Text = "";
                MessageBox.Show("Your practice time has over");



            }
        }

        private void Form11ddiv_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
        }

        private void buttonresume_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttondone.Enabled = true;
            buttonstart.Enabled = false;
            buttonpause.Enabled = true;
            buttonexit.Enabled = true;
            buttonresume.Enabled = false;
        }
    }
}

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
    public partial class Form3 : Form
    {
        System.Windows.Forms.TextBox[] textBoxQ = new System.Windows.Forms.TextBox[10];
        System.Windows.Forms.TextBox[] textBoxANS = new System.Windows.Forms.TextBox[10];
        System.Windows.Forms.TextBox[] textBoxPoints = new System.Windows.Forms.TextBox[10];

        public Form3()
        {
            InitializeComponent();
            textBoxQ[0] = this.textBoxQ1;
            textBoxQ[1] = this.textBoxQ2;
            textBoxQ[2] = this.textBoxQ3;
            textBoxQ[3] = this.textBoxQ4;
            textBoxQ[4] = this.textBoxQ5;
            textBoxQ[5] = this.textBoxQ6;
            textBoxQ[6] = this.textBoxQ7;
            textBoxQ[7] = this.textBoxQ8;
            textBoxQ[8] = this.textBoxQ9;
            textBoxQ[9] = this.textBoxQ10;

            textBoxANS[0] = this.textBoxANS1;
            textBoxANS[1] = this.textBoxANS2;
            textBoxANS[2] = this.textBoxANS3;
            textBoxANS[3] = this.textBoxANS4;
            textBoxANS[4] = this.textBoxANS5;
            textBoxANS[5] = this.textBoxANS6;
            textBoxANS[6] = this.textBoxANS7;
            textBoxANS[7] = this.textBoxANS8;
            textBoxANS[8] = this.textBoxANS9;
            textBoxANS[9] = this.textBoxANS10;

            textBoxPoints[0] = this.textBoxPQ1;
            textBoxPoints[1] = this.textBoxPQ2;
            textBoxPoints[2] = this.textBoxPQ3;
            textBoxPoints[3] = this.textBoxPQ4;
            textBoxPoints[4] = this.textBoxPQ5;
            textBoxPoints[5] = this.textBoxPQ6;
            textBoxPoints[6] = this.textBoxPQ7;
            textBoxPoints[7] = this.textBoxPQ8;
            textBoxPoints[8] = this.textBoxPQ9;
            textBoxPoints[9] = this.textBoxPQ10;

            for (int i = 0; i < 10; i++)
            {
                this.textBoxQ[i].AutoSize = false;
                this.textBoxQ[i].Size = new System.Drawing.Size(189, 29);
            }
        }

        private void button1Savetest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (textBoxQ[i].Text.Length == 0)
                {
                    MessageBox.Show("please fill questions for all 10 lines");
                    return;
                }
                if (textBoxANS[i].Text.Length == 0)
                {
                    MessageBox.Show("please fill answers for all 10 lines");
                    return;
                }
                if (textBoxPoints[i].Text.Length == 0)
                {
                    MessageBox.Show("please fill points for all 10 lines");
                    return;
                }
            }
            if (!textBox3.Text.Equals("100"))
            {
                MessageBox.Show("Total points must be 100");
                return;
            }
            saveTest();
        }

        private void saveTest()
        {
            // file format is: qNumber; question;Answer; <points>
            string[] filelines = new string[10];
            filelines[0] = "1;" + textBoxQ1.Text + ";" + textBoxANS1.Text + ";" + textBoxPQ1.Text;
            filelines[1] = "2;" + textBoxQ2.Text + ";" + textBoxANS2.Text + ";" + textBoxPQ2.Text;
            filelines[2] = "3;" + textBoxQ3.Text + ";" + textBoxANS3.Text + ";" + textBoxPQ3.Text;
            filelines[3] = "4;" + textBoxQ4.Text + ";" + textBoxANS4.Text + ";" + textBoxPQ4.Text;
            filelines[4] = "5;" + textBoxQ5.Text + ";" + textBoxANS5.Text + ";" + textBoxPQ5.Text;
            filelines[5] = "6;" + textBoxQ6.Text + ";" + textBoxANS6.Text + ";" + textBoxPQ6.Text;
            filelines[6] = "7;" + textBoxQ7.Text + ";" + textBoxANS7.Text + ";" + textBoxPQ7.Text;
            filelines[7] = "8;" + textBoxQ8.Text + ";" + textBoxANS8.Text + ";" + textBoxPQ8.Text;
            filelines[8] = "9;" + textBoxQ9.Text + ";" + textBoxANS9.Text + ";" + textBoxPQ9.Text;
            filelines[9] = "10;" + textBoxQ10.Text + ";" + textBoxANS10.Text + ";" + textBoxPQ10.Text;
            int num = 1;
            string filename = "EXAMS\\gameExam" + num + ".txt";
            while (System.IO.File.Exists(filename))
            {
                num++;
                filename = "EXAMS\\gameExam" + num + ".txt";
            }
            System.IO.File.WriteAllLines(filename, filelines);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // Instantiate a Form2 object.
            this.Hide(); // closes the Form4 instance.
            f2.ShowDialog(); // Show Form2 and
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                textBoxPoints[i].Text = "10";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPQ1_TextChanged(object sender, EventArgs e)
        {
            calc_total_points();
        }

        private void textBoxPQ2_TextChanged(object sender, EventArgs e)
        {
            calc_total_points();
        }

        private void textBoxPQ3_TextChanged(object sender, EventArgs e)
        {
            calc_total_points();
        }

        private void textBoxPQ4_TextChanged(object sender, EventArgs e)
        {
            calc_total_points();
        }

        private void textBoxPQ5_TextChanged(object sender, EventArgs e)
        {
            calc_total_points();
        }

        private void textBoxPQ6_TextChanged(object sender, EventArgs e)
        {
            calc_total_points();
        }

        private void textBoxPQ7_TextChanged(object sender, EventArgs e)
        {
            calc_total_points();
        }

        private void textBoxPQ8_TextChanged(object sender, EventArgs e)
        {
            calc_total_points();
        }

        private void textBoxPQ9_TextChanged(object sender, EventArgs e)
        {
            calc_total_points();
        }

        private void textBoxPQ10_TextChanged(object sender, EventArgs e)
        {
            calc_total_points();
        }

        private void calc_total_points()
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                if (textBoxPoints[i].Text.Length > 0)
                    total += Int32.Parse(textBoxPoints[i].Text);
            }
            textBox3.Text = "" + total;
        }

        private void textBoxQ1_TextChanged(object sender, EventArgs e)
        {
            calc_num_questions();
        }

        private void textBoxQ2_TextChanged(object sender, EventArgs e)
        {
            calc_num_questions();
        }

        private void textBoxQ3_TextChanged(object sender, EventArgs e)
        {
            calc_num_questions();
        }

        private void textBoxQ4_TextChanged(object sender, EventArgs e)
        {
            calc_num_questions();
        }

        private void textBoxQ5_TextChanged(object sender, EventArgs e)
        {
            calc_num_questions();
        }

        private void textBoxQ6_TextChanged(object sender, EventArgs e)
        {
            calc_num_questions();
        }

        private void textBoxQ7_TextChanged(object sender, EventArgs e)
        {
            calc_num_questions();
        }

        private void textBoxQ8_TextChanged(object sender, EventArgs e)
        {
            calc_num_questions();
        }

        private void textBoxQ9_TextChanged(object sender, EventArgs e)
        {
            calc_num_questions();
        }

        private void textBoxQ10_TextChanged(object sender, EventArgs e)
        {
            calc_num_questions();
        }

        private void calc_num_questions()
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
                if (textBoxQ[i].Text.Length > 0)
                    count++;
            textBoxtotalQ.Text = "" + count;
        }

        private void textBoxANS1_TextChanged(object sender, EventArgs e)
        {
            calc_num_ans();
        }

        private void textBoxANS2_TextChanged(object sender, EventArgs e)
        {
            calc_num_ans();
        }

        private void textBoxANS3_TextChanged(object sender, EventArgs e)
        {
            calc_num_ans();
        }

        private void textBoxANS4_TextChanged(object sender, EventArgs e)
        {
            calc_num_ans();
        }

        private void textBoxANS5_TextChanged(object sender, EventArgs e)
        {
            calc_num_ans();
        }

        private void textBoxANS6_TextChanged(object sender, EventArgs e)
        {
            calc_num_ans();
        }

        private void textBoxANS7_TextChanged(object sender, EventArgs e)
        {
            calc_num_ans();
        }

        private void textBoxANS8_TextChanged(object sender, EventArgs e)
        {
            calc_num_ans();
        }

        private void textBoxANS9_TextChanged(object sender, EventArgs e)
        {
            calc_num_ans();
        }

        private void textBoxANS10_TextChanged(object sender, EventArgs e)
        {
            calc_num_ans();
        }
        private void calc_num_ans()
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
                if (textBoxANS[i].Text.Length > 0)
                    count++;
            textBox2.Text = "" + count;
        }
    }
}

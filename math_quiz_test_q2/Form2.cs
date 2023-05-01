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
    public partial class Form2 : Form
    {
        protected static Form2 theInstance;
        public static Form2 getTheInstance()
        {
            return theInstance;
        }

        public Form2()
        {
            InitializeComponent();
            theInstance = this;
            int num = 1;
            string filename = "EXAMS\\gameExam" + num + ".txt";
            while (System.IO.File.Exists(filename))
            {
                listBoxTests.Items.Add("test-" + num);
                num++;
                filename = "EXAMS\\gameExam" + num + ".txt";
            }
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide(); // hides this Form2 instance.
            f6.Show(); // Show Form6
        }

        private void button1addtest_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide(); // hides this Form2 instance.
            f3.Show(); // Show Form3
        }

        private void buttonStudentSignIn_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide(); // hides this Form2 instance.
            f4.Show(); // Show Form4
        }

        internal void NotifyLogin()
        {
            this.buttonTrain.Enabled = true;
            this.listBoxTests.Enabled = true;
            this.labelWelcome.Text = "Welcome, " + Form4.getStudentName();
            this.labelWelcome.Visible = true;
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Form1.getTheInstance().Close();
            this.Close();
            Form4.RequestClose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            string testNumber = this.listBoxTests.SelectedItem.ToString().Substring(5);
            Form5test f5t = new Form5test(testNumber);
            this.Hide();
            f5t.ShowDialog();
            this.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

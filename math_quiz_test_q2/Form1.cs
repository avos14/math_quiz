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
    public partial class Form1 : Form
    {

        static protected Form1 theInstance;
        public static Form1 getTheInstance()
        {
            return theInstance;
        }

        public Form1()
        {
            InitializeComponent();
            theInstance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1play_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // Instantiate a Form2 object.
            this.Hide(); // closes the Form1 instance.
            f2.Show(); // Show Form3 and
        }

        private void button2close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

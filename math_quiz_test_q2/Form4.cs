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
    public partial class Form4 : Form
    {
        protected static Form4 theInstance;

        public static Form4 getTheInstance()
        {
            return theInstance;
        }

        public static string getStudentID()
        {
            return theInstance.textBoxStudentID.Text;
        }

        public static string getStudentName()
        {
            return theInstance.textBoxStudentFirstName.Text;
        }

        public Form4()
        {
            InitializeComponent();
            theInstance = this;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Text = "";
            Form2.getTheInstance().Show(); // show form 2
            this.Hide();
        }

        private void textBoxQ1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQ4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxStudentID.Text.Length == 0)
            {
                MessageBox.Show("Please fill-in the required fields");
                return;
            }
            Form2.getTheInstance().Show(); // show form 2
            Form2.getTheInstance().NotifyLogin();
            this.Hide();
        }

        public static void RequestClose()
        {
            if (theInstance != null)
                theInstance.Close();
        }
    }
}

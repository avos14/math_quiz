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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonSingleDigits_Click(object sender, EventArgs e)
        {
            Form5s f5 = new Form5s(); // Instantiate a Form5 object.
            this.Hide(); // closes the Form6 instance.
            f5.ShowDialog(); // Show Form5 and
            this.Close();
        }

        private void buttonDoubleDigits_Click_1(object sender, EventArgs e)
        {
            Form7d f7 = new Form7d(); // Instantiate a Form7 object.
            this.Hide(); // closes the Form6 instance.
            f7.ShowDialog(); // Show Form7 and
            this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form2.getTheInstance().Show();
            this.Close();
        }
    }
}

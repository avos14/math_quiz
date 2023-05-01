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
    public partial class Form5s : Form
    {
        public Form5s()
        {
            InitializeComponent();
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            Form9spls f9spls = new Form9spls(); // Instantiate a Form9spls object.
            this.Hide(); // closes the Form5s instance.
            f9spls.ShowDialog(); // Show Form9spls and
            this.Close();
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            Form8smin f8smin = new Form8smin(); // Instantiate a Form8smin object.
            this.Hide(); // closes the Form5s instance.
            f8smin.ShowDialog(); // Show Form8smin and
            this.Close();
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            Form10smul f10smul = new Form10smul(); // Instantiate a Form10smul object.
            this.Hide(); // closes the Form5s instance.
            f10smul.ShowDialog(); // Show Form10smul and
            this.Close();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Form11sdiv f11sdiv = new Form11sdiv(); // Instantiate a Form11sdiv object.
            this.Hide(); // closes the Form5s instance.
            f11sdiv.ShowDialog(); // Show Form11sdiv and
            this.Close();
        }

        private void buttonAS_Click(object sender, EventArgs e)
        {
            Form12spm f12spm = new Form12spm(); // Instantiate a Form12spm object.
            this.Hide(); // closes the Form5s instance.
            f12spm.ShowDialog(); // Show Form12spm and
            this.Close();
        }

        private void buttonMD_Click(object sender, EventArgs e)
        {
            Form13smd f13smd = new Form13smd(); // Instantiate a Form13smd object.
            this.Hide(); // closes the Form5s instance.
            f13smd.ShowDialog(); // Show Form13smd and
            this.Close();
        }

        private void buttonAllArithmetic_Click(object sender, EventArgs e)
        {
            Form14smdpm f14smdpm = new Form14smdpm(); // Instantiate a Form14smdpm object.
            this.Hide(); // closes the Form5s instance.
            f14smdpm.ShowDialog(); // Show Form14smdpm and
            this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(); // Instantiate a Form6 object.
            this.Hide(); // closes the Form5s instance.
            f6.ShowDialog(); // Show Form6 and
            this.Close();
        }
    }
}

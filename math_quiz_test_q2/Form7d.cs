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
    public partial class Form7d : Form
    {
        public Form7d()
        {
            InitializeComponent();
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            Form9dpls f9dpls = new Form9dpls(); // Instantiate a Form9dpls object.
            this.Hide(); // closes the Form7d instance.
            f9dpls.ShowDialog(); // Show Form9dpls and
            this.Close();
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            Form8dmin f8dmin = new Form8dmin(); // Instantiate a Form8dmin object.
            this.Hide(); // closes the Form7d instance.
            f8dmin.ShowDialog(); // Show Form8dmin and
            this.Close();

        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            Form10dmul f10dmul = new Form10dmul(); // Instantiate a Form10dmul object.
            this.Hide(); // closes the Form7d instance.
            f10dmul.ShowDialog(); // Show Form10dmul and
            this.Close();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Form11ddiv f11ddiv = new Form11ddiv(); // Instantiate a Form11ddiv object.
            this.Hide(); // closes the Form7d instance.
            f11ddiv.ShowDialog(); // Show Form11ddiv and
            this.Close();
        }

        private void buttonAS_Click(object sender, EventArgs e)
        {
            Form12dpm f12dpm = new Form12dpm(); // Instantiate a Form12dpm object.
            this.Hide(); // closes the Form7d instance.
            f12dpm.ShowDialog(); // Show Form12dpm and
            this.Close();

        }

        private void buttonMD_Click(object sender, EventArgs e)
        {
            Form13dmd f13dmd = new Form13dmd(); // Instantiate a Form13dmd object.
            this.Hide(); // closes the Form7d instance.
            f13dmd.ShowDialog(); // Show Form13dmd and
            this.Close();

        }

        private void buttonAllArithmetic_Click(object sender, EventArgs e)
        {
            Form14dmdpm f14dmdpm = new Form14dmdpm(); // Instantiate a Form14dmdpm object.
            this.Hide(); // closes the Form7d instance.
            f14dmdpm.ShowDialog(); // Show Form14dmdpm and
            this.Close();

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(); // Instantiate a Form6 object.
            this.Hide(); // closes the Form7d instance.
            f6.ShowDialog(); // Show Form6 and
            this.Close();
        }
    }
}

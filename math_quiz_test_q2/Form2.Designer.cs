namespace math_quiz_test_q2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTrain = new System.Windows.Forms.Button();
            this.button1addtest = new System.Windows.Forms.Button();
            this.buttonStudentSignIn = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTrain
            // 
            this.buttonTrain.BackColor = System.Drawing.Color.Orange;
            this.buttonTrain.Enabled = false;
            this.buttonTrain.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrain.Location = new System.Drawing.Point(12, 172);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(160, 44);
            this.buttonTrain.TabIndex = 1;
            this.buttonTrain.Text = "Practice";
            this.buttonTrain.UseVisualStyleBackColor = false;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // button1addtest
            // 
            this.button1addtest.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1addtest.Location = new System.Drawing.Point(12, 12);
            this.button1addtest.Name = "button1addtest";
            this.button1addtest.Size = new System.Drawing.Size(160, 44);
            this.button1addtest.TabIndex = 2;
            this.button1addtest.Text = "Add Test";
            this.button1addtest.UseVisualStyleBackColor = true;
            this.button1addtest.Click += new System.EventHandler(this.button1addtest_Click);
            // 
            // buttonStudentSignIn
            // 
            this.buttonStudentSignIn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentSignIn.Location = new System.Drawing.Point(12, 79);
            this.buttonStudentSignIn.Name = "buttonStudentSignIn";
            this.buttonStudentSignIn.Size = new System.Drawing.Size(160, 44);
            this.buttonStudentSignIn.TabIndex = 3;
            this.buttonStudentSignIn.Text = "Student Sign In";
            this.buttonStudentSignIn.UseVisualStyleBackColor = true;
            this.buttonStudentSignIn.Click += new System.EventHandler(this.buttonStudentSignIn_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(781, 445);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(160, 44);
            this.buttonexit.TabIndex = 22;
            this.buttonexit.Text = "exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // listBoxTests
            // 
            this.listBoxTests.Enabled = false;
            this.listBoxTests.FormattingEnabled = true;
            this.listBoxTests.Location = new System.Drawing.Point(27, 272);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(122, 251);
            this.listBoxTests.TabIndex = 23;
            this.listBoxTests.SelectedIndexChanged += new System.EventHandler(this.listBoxTests_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tests";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(767, 57);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 13);
            this.labelWelcome.TabIndex = 25;
            this.labelWelcome.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::math_quiz_test_q2.Properties.Resources._5f9adf1546a741f6bff344c194e74dd9_cartoon_vector_material_mathematics_symbol_math_hot_air_balloon__650_565;
            this.ClientSize = new System.Drawing.Size(953, 547);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTests);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonStudentSignIn);
            this.Controls.Add(this.button1addtest);
            this.Controls.Add(this.buttonTrain);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Button button1addtest;
        private System.Windows.Forms.Button buttonStudentSignIn;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.ListBox listBoxTests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWelcome;
    }
}
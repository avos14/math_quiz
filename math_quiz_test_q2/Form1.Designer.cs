namespace math_quiz_test_q2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1play = new System.Windows.Forms.Button();
            this.button2close = new System.Windows.Forms.Button();
            this.label1user_interface = new System.Windows.Forms.Label();
            this.label3user_interface = new System.Windows.Forms.Label();
            this.label2user_interface = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1play
            // 
            this.button1play.BackColor = System.Drawing.Color.ForestGreen;
            this.button1play.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1play.Location = new System.Drawing.Point(611, 439);
            this.button1play.Margin = new System.Windows.Forms.Padding(2);
            this.button1play.Name = "button1play";
            this.button1play.Size = new System.Drawing.Size(100, 44);
            this.button1play.TabIndex = 0;
            this.button1play.Text = "play";
            this.button1play.UseVisualStyleBackColor = false;
            this.button1play.Click += new System.EventHandler(this.button1play_Click);
            // 
            // button2close
            // 
            this.button2close.BackColor = System.Drawing.Color.BlueViolet;
            this.button2close.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2close.Location = new System.Drawing.Point(783, 439);
            this.button2close.Margin = new System.Windows.Forms.Padding(2);
            this.button2close.Name = "button2close";
            this.button2close.Size = new System.Drawing.Size(100, 44);
            this.button2close.TabIndex = 1;
            this.button2close.Text = "close";
            this.button2close.UseVisualStyleBackColor = false;
            this.button2close.Click += new System.EventHandler(this.button2close_Click);
            // 
            // label1user_interface
            // 
            this.label1user_interface.AutoSize = true;
            this.label1user_interface.BackColor = System.Drawing.Color.White;
            this.label1user_interface.Font = new System.Drawing.Font("Copperplate Gothic Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1user_interface.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1user_interface.Location = new System.Drawing.Point(218, 37);
            this.label1user_interface.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1user_interface.Name = "label1user_interface";
            this.label1user_interface.Size = new System.Drawing.Size(470, 31);
            this.label1user_interface.TabIndex = 3;
            this.label1user_interface.Text = "Welcome to the math center ";
            // 
            // label3user_interface
            // 
            this.label3user_interface.AutoSize = true;
            this.label3user_interface.BackColor = System.Drawing.Color.White;
            this.label3user_interface.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3user_interface.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3user_interface.Location = new System.Drawing.Point(354, 205);
            this.label3user_interface.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3user_interface.Name = "label3user_interface";
            this.label3user_interface.Size = new System.Drawing.Size(278, 24);
            this.label3user_interface.TabIndex = 4;
            this.label3user_interface.Text = "Click play to continue";
            // 
            // label2user_interface
            // 
            this.label2user_interface.AutoSize = true;
            this.label2user_interface.BackColor = System.Drawing.Color.White;
            this.label2user_interface.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2user_interface.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2user_interface.Location = new System.Drawing.Point(186, 132);
            this.label2user_interface.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2user_interface.Name = "label2user_interface";
            this.label2user_interface.Size = new System.Drawing.Size(603, 24);
            this.label2user_interface.TabIndex = 5;
            this.label2user_interface.Text = " Here you can Practice and test your skils in math";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(953, 547);
            this.Controls.Add(this.label2user_interface);
            this.Controls.Add(this.label3user_interface);
            this.Controls.Add(this.label1user_interface);
            this.Controls.Add(this.button2close);
            this.Controls.Add(this.button1play);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1play;
        private System.Windows.Forms.Button button2close;
        private System.Windows.Forms.Label label1user_interface;
        private System.Windows.Forms.Label label3user_interface;
        private System.Windows.Forms.Label label2user_interface;
    }
}


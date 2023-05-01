namespace math_quiz_test_q2
{
    partial class Form6
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
            this.buttonDoubleDigits = new System.Windows.Forms.Button();
            this.buttonSingleDigits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDoubleDigits
            // 
            this.buttonDoubleDigits.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDoubleDigits.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoubleDigits.Location = new System.Drawing.Point(577, 251);
            this.buttonDoubleDigits.Name = "buttonDoubleDigits";
            this.buttonDoubleDigits.Size = new System.Drawing.Size(160, 44);
            this.buttonDoubleDigits.TabIndex = 8;
            this.buttonDoubleDigits.Text = " Double Digits";
            this.buttonDoubleDigits.UseVisualStyleBackColor = false;
            this.buttonDoubleDigits.Click += new System.EventHandler(this.buttonDoubleDigits_Click_1);
            // 
            // buttonSingleDigits
            // 
            this.buttonSingleDigits.BackColor = System.Drawing.Color.Orange;
            this.buttonSingleDigits.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingleDigits.Location = new System.Drawing.Point(230, 251);
            this.buttonSingleDigits.Name = "buttonSingleDigits";
            this.buttonSingleDigits.Size = new System.Drawing.Size(160, 44);
            this.buttonSingleDigits.TabIndex = 9;
            this.buttonSingleDigits.Text = "Single Digits";
            this.buttonSingleDigits.UseVisualStyleBackColor = false;
            this.buttonSingleDigits.Click += new System.EventHandler(this.buttonSingleDigits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(282, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Click On what You Wont To Practice";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Lavender;
            this.buttonReturn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(397, 416);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(160, 44);
            this.buttonReturn.TabIndex = 259;
            this.buttonReturn.Text = "Return ";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::math_quiz_test_q2.Properties.Resources.pngtree_landscape_vector_illustration_with_funny_design_suitable_for_kids_background_image_318964;
            this.ClientSize = new System.Drawing.Size(953, 547);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSingleDigits);
            this.Controls.Add(this.buttonDoubleDigits);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDoubleDigits;
        private System.Windows.Forms.Button buttonSingleDigits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
    }
}
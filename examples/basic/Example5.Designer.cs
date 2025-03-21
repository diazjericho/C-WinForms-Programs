namespace C__WinForms_Programs.examples.basic {
    partial class Example5 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.radioButtonCpE = new System.Windows.Forms.RadioButton();
            this.radioButtonECE = new System.Windows.Forms.RadioButton();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelResultValue2 = new System.Windows.Forms.Label();
            this.labelResultValue1 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Location = new System.Drawing.Point(12, 39);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(63, 22);
            this.radioButtonNone.TabIndex = 0;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonCpE
            // 
            this.radioButtonCpE.AutoSize = true;
            this.radioButtonCpE.Location = new System.Drawing.Point(12, 67);
            this.radioButtonCpE.Name = "radioButtonCpE";
            this.radioButtonCpE.Size = new System.Drawing.Size(58, 22);
            this.radioButtonCpE.TabIndex = 1;
            this.radioButtonCpE.TabStop = true;
            this.radioButtonCpE.Text = "CpE";
            this.radioButtonCpE.UseVisualStyleBackColor = true;
            // 
            // radioButtonECE
            // 
            this.radioButtonECE.AutoSize = true;
            this.radioButtonECE.Location = new System.Drawing.Point(12, 95);
            this.radioButtonECE.Name = "radioButtonECE";
            this.radioButtonECE.Size = new System.Drawing.Size(60, 22);
            this.radioButtonECE.TabIndex = 2;
            this.radioButtonECE.TabStop = true;
            this.radioButtonECE.Text = "ECE";
            this.radioButtonECE.UseVisualStyleBackColor = true;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(12, 9);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(183, 18);
            this.labelInstructions.TabIndex = 3;
            this.labelInstructions.Text = "Select one of the options:";
            // 
            // labelResultValue2
            // 
            this.labelResultValue2.AutoSize = true;
            this.labelResultValue2.Location = new System.Drawing.Point(227, 76);
            this.labelResultValue2.Name = "labelResultValue2";
            this.labelResultValue2.Size = new System.Drawing.Size(137, 18);
            this.labelResultValue2.TabIndex = 6;
            this.labelResultValue2.Text = "result2Placeholder";
            // 
            // labelResultValue1
            // 
            this.labelResultValue1.AutoSize = true;
            this.labelResultValue1.Location = new System.Drawing.Point(227, 41);
            this.labelResultValue1.Name = "labelResultValue1";
            this.labelResultValue1.Size = new System.Drawing.Size(137, 18);
            this.labelResultValue1.TabIndex = 5;
            this.labelResultValue1.Text = "result1Placeholder";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(227, 9);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(63, 18);
            this.labelResults.TabIndex = 4;
            this.labelResults.Text = "Results:";
            // 
            // Example5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 141);
            this.Controls.Add(this.labelResultValue2);
            this.Controls.Add(this.labelResultValue1);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.radioButtonECE);
            this.Controls.Add(this.radioButtonCpE);
            this.Controls.Add(this.radioButtonNone);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Example5";
            this.Text = "Example5";
            this.Load += new System.EventHandler(this.Example5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.RadioButton radioButtonCpE;
        private System.Windows.Forms.RadioButton radioButtonECE;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelResultValue2;
        private System.Windows.Forms.Label labelResultValue1;
        private System.Windows.Forms.Label labelResults;
    }
}
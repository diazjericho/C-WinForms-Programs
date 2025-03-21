namespace C__WinForms_Programs.examples.basic {
    partial class Example4 {
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
            this.comboBoxOptions = new System.Windows.Forms.ComboBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelResultValue1 = new System.Windows.Forms.Label();
            this.labelResultValue2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxOptions
            // 
            this.comboBoxOptions.FormattingEnabled = true;
            this.comboBoxOptions.Location = new System.Drawing.Point(13, 13);
            this.comboBoxOptions.Name = "comboBoxOptions";
            this.comboBoxOptions.Size = new System.Drawing.Size(320, 26);
            this.comboBoxOptions.TabIndex = 0;
            this.comboBoxOptions.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptions_SelectedIndexChanged);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(12, 61);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(63, 18);
            this.labelResults.TabIndex = 1;
            this.labelResults.Text = "Results:";
            // 
            // labelResultValue1
            // 
            this.labelResultValue1.AutoSize = true;
            this.labelResultValue1.Location = new System.Drawing.Point(12, 93);
            this.labelResultValue1.Name = "labelResultValue1";
            this.labelResultValue1.Size = new System.Drawing.Size(137, 18);
            this.labelResultValue1.TabIndex = 2;
            this.labelResultValue1.Text = "result1Placeholder";
            // 
            // labelResultValue2
            // 
            this.labelResultValue2.AutoSize = true;
            this.labelResultValue2.Location = new System.Drawing.Point(12, 128);
            this.labelResultValue2.Name = "labelResultValue2";
            this.labelResultValue2.Size = new System.Drawing.Size(137, 18);
            this.labelResultValue2.TabIndex = 3;
            this.labelResultValue2.Text = "result2Placeholder";
            // 
            // Example4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 194);
            this.Controls.Add(this.labelResultValue2);
            this.Controls.Add(this.labelResultValue1);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.comboBoxOptions);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Example4";
            this.Text = "Example4";
            this.Load += new System.EventHandler(this.Example4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOptions;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelResultValue1;
        private System.Windows.Forms.Label labelResultValue2;
    }
}
namespace C__WinForms_Programs.examples.intermediate {
    partial class IExample1 {
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
            this.checkBoxCpE = new System.Windows.Forms.CheckBox();
            this.checkBoxECE = new System.Windows.Forms.CheckBox();
            this.checkBoxCE = new System.Windows.Forms.CheckBox();
            this.checkBoxArchi = new System.Windows.Forms.CheckBox();
            this.labelResultValue = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // checkBoxCpE
            // 
            this.checkBoxCpE.AutoSize = true;
            this.checkBoxCpE.Location = new System.Drawing.Point(12, 12);
            this.checkBoxCpE.Name = "checkBoxCpE";
            this.checkBoxCpE.Size = new System.Drawing.Size(59, 22);
            this.checkBoxCpE.TabIndex = 0;
            this.checkBoxCpE.Text = "CpE";
            this.checkBoxCpE.UseVisualStyleBackColor = true;
            // 
            // checkBoxECE
            // 
            this.checkBoxECE.AutoSize = true;
            this.checkBoxECE.Location = new System.Drawing.Point(12, 40);
            this.checkBoxECE.Name = "checkBoxECE";
            this.checkBoxECE.Size = new System.Drawing.Size(61, 22);
            this.checkBoxECE.TabIndex = 1;
            this.checkBoxECE.Text = "ECE";
            this.checkBoxECE.UseVisualStyleBackColor = true;
            // 
            // checkBoxCE
            // 
            this.checkBoxCE.AutoSize = true;
            this.checkBoxCE.Location = new System.Drawing.Point(12, 68);
            this.checkBoxCE.Name = "checkBoxCE";
            this.checkBoxCE.Size = new System.Drawing.Size(50, 22);
            this.checkBoxCE.TabIndex = 2;
            this.checkBoxCE.Text = "CE";
            this.checkBoxCE.UseVisualStyleBackColor = true;
            // 
            // checkBoxArchi
            // 
            this.checkBoxArchi.AutoSize = true;
            this.checkBoxArchi.Location = new System.Drawing.Point(12, 96);
            this.checkBoxArchi.Name = "checkBoxArchi";
            this.checkBoxArchi.Size = new System.Drawing.Size(63, 22);
            this.checkBoxArchi.TabIndex = 3;
            this.checkBoxArchi.Text = "Archi";
            this.checkBoxArchi.UseVisualStyleBackColor = true;
            // 
            // labelResultValue
            // 
            this.labelResultValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultValue.AutoSize = true;
            this.labelResultValue.Location = new System.Drawing.Point(12, 152);
            this.labelResultValue.Name = "labelResultValue";
            this.labelResultValue.Size = new System.Drawing.Size(89, 18);
            this.labelResultValue.TabIndex = 4;
            this.labelResultValue.Text = "placeholder";
            this.labelResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(224, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 107);
            this.progressBar1.TabIndex = 5;
            // 
            // IExample1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 186);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelResultValue);
            this.Controls.Add(this.checkBoxArchi);
            this.Controls.Add(this.checkBoxCE);
            this.Controls.Add(this.checkBoxECE);
            this.Controls.Add(this.checkBoxCpE);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "IExample1";
            this.Text = "Example1";
            this.Load += new System.EventHandler(this.Example1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCpE;
        private System.Windows.Forms.CheckBox checkBoxECE;
        private System.Windows.Forms.CheckBox checkBoxCE;
        private System.Windows.Forms.CheckBox checkBoxArchi;
        private System.Windows.Forms.Label labelResultValue;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
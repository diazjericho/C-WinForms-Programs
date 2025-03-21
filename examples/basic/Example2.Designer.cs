namespace C__WinForms_Programs.examples.basic {
    partial class Example2 {
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
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonCombineText = new System.Windows.Forms.Button();
            this.labelResultValue = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.textBoxInputTextOne = new System.Windows.Forms.TextBox();
            this.labelInstructionsOne = new System.Windows.Forms.Label();
            this.textBoxInputTextTwo = new System.Windows.Forms.TextBox();
            this.labelInstructionsTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonClearAll.Location = new System.Drawing.Point(264, 85);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(220, 43);
            this.buttonClearAll.TabIndex = 15;
            this.buttonClearAll.Text = "CLEAR ALL";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonCombineText
            // 
            this.buttonCombineText.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonCombineText.Location = new System.Drawing.Point(12, 85);
            this.buttonCombineText.Name = "buttonCombineText";
            this.buttonCombineText.Size = new System.Drawing.Size(220, 43);
            this.buttonCombineText.TabIndex = 14;
            this.buttonCombineText.Text = "COMBINE TEXT";
            this.buttonCombineText.UseVisualStyleBackColor = true;
            this.buttonCombineText.Click += new System.EventHandler(this.buttonShowText_Click);
            // 
            // labelResultValue
            // 
            this.labelResultValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultValue.AutoSize = true;
            this.labelResultValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultValue.Location = new System.Drawing.Point(9, 176);
            this.labelResultValue.Name = "labelResultValue";
            this.labelResultValue.Size = new System.Drawing.Size(128, 18);
            this.labelResultValue.TabIndex = 13;
            this.labelResultValue.Text = "resultPlaceholder";
            this.labelResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.Location = new System.Drawing.Point(9, 143);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(63, 18);
            this.labelResults.TabIndex = 11;
            this.labelResults.Text = "Results:";
            // 
            // textBoxInputTextOne
            // 
            this.textBoxInputTextOne.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxInputTextOne.Location = new System.Drawing.Point(176, 9);
            this.textBoxInputTextOne.Name = "textBoxInputTextOne";
            this.textBoxInputTextOne.Size = new System.Drawing.Size(308, 26);
            this.textBoxInputTextOne.TabIndex = 10;
            // 
            // labelInstructionsOne
            // 
            this.labelInstructionsOne.AutoSize = true;
            this.labelInstructionsOne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructionsOne.Location = new System.Drawing.Point(14, 12);
            this.labelInstructionsOne.Name = "labelInstructionsOne";
            this.labelInstructionsOne.Size = new System.Drawing.Size(131, 18);
            this.labelInstructionsOne.TabIndex = 9;
            this.labelInstructionsOne.Text = "Enter the first text:";
            // 
            // textBoxInputTextTwo
            // 
            this.textBoxInputTextTwo.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxInputTextTwo.Location = new System.Drawing.Point(176, 44);
            this.textBoxInputTextTwo.Name = "textBoxInputTextTwo";
            this.textBoxInputTextTwo.Size = new System.Drawing.Size(308, 26);
            this.textBoxInputTextTwo.TabIndex = 17;
            // 
            // labelInstructionsTwo
            // 
            this.labelInstructionsTwo.AutoSize = true;
            this.labelInstructionsTwo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructionsTwo.Location = new System.Drawing.Point(14, 47);
            this.labelInstructionsTwo.Name = "labelInstructionsTwo";
            this.labelInstructionsTwo.Size = new System.Drawing.Size(157, 18);
            this.labelInstructionsTwo.TabIndex = 16;
            this.labelInstructionsTwo.Text = "Enter the second text:";
            // 
            // Example2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(499, 246);
            this.Controls.Add(this.textBoxInputTextTwo);
            this.Controls.Add(this.labelInstructionsTwo);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonCombineText);
            this.Controls.Add(this.labelResultValue);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.textBoxInputTextOne);
            this.Controls.Add(this.labelInstructionsOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Example2";
            this.Text = "Combining two strings";
            this.Load += new System.EventHandler(this.ExampleTwo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonCombineText;
        private System.Windows.Forms.Label labelResultValue;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.TextBox textBoxInputTextOne;
        private System.Windows.Forms.Label labelInstructionsOne;
        private System.Windows.Forms.TextBox textBoxInputTextTwo;
        private System.Windows.Forms.Label labelInstructionsTwo;
    }
}
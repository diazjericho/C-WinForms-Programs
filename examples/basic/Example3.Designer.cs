namespace C__WinForms_Programs.examples.basic {
    partial class Example3 {
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
            this.textBoxInputTextTwo = new System.Windows.Forms.TextBox();
            this.labelInstructionsTwo = new System.Windows.Forms.Label();
            this.buttonResults = new System.Windows.Forms.Button();
            this.labelResultValue = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.textBoxInputTextOne = new System.Windows.Forms.TextBox();
            this.labelInstructionsOne = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInputTextTwo
            // 
            this.textBoxInputTextTwo.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxInputTextTwo.Location = new System.Drawing.Point(203, 44);
            this.textBoxInputTextTwo.Name = "textBoxInputTextTwo";
            this.textBoxInputTextTwo.Size = new System.Drawing.Size(187, 26);
            this.textBoxInputTextTwo.TabIndex = 24;
            this.textBoxInputTextTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputTextTwo_KeyPress);
            // 
            // labelInstructionsTwo
            // 
            this.labelInstructionsTwo.AutoSize = true;
            this.labelInstructionsTwo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructionsTwo.Location = new System.Drawing.Point(12, 44);
            this.labelInstructionsTwo.Name = "labelInstructionsTwo";
            this.labelInstructionsTwo.Size = new System.Drawing.Size(185, 18);
            this.labelInstructionsTwo.TabIndex = 23;
            this.labelInstructionsTwo.Text = "Enter the second number:";
            // 
            // buttonResults
            // 
            this.buttonResults.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonResults.Location = new System.Drawing.Point(10, 82);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(187, 43);
            this.buttonResults.TabIndex = 22;
            this.buttonResults.Text = "COMPUTE NUMBERS";
            this.buttonResults.UseVisualStyleBackColor = true;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // labelResultValue
            // 
            this.labelResultValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResultValue.AutoSize = true;
            this.labelResultValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultValue.Location = new System.Drawing.Point(7, 173);
            this.labelResultValue.Name = "labelResultValue";
            this.labelResultValue.Size = new System.Drawing.Size(128, 18);
            this.labelResultValue.TabIndex = 21;
            this.labelResultValue.Text = "resultPlaceholder";
            this.labelResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.Location = new System.Drawing.Point(7, 140);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(63, 18);
            this.labelResults.TabIndex = 20;
            this.labelResults.Text = "Results:";
            // 
            // textBoxInputTextOne
            // 
            this.textBoxInputTextOne.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxInputTextOne.Location = new System.Drawing.Point(203, 9);
            this.textBoxInputTextOne.Name = "textBoxInputTextOne";
            this.textBoxInputTextOne.Size = new System.Drawing.Size(187, 26);
            this.textBoxInputTextOne.TabIndex = 19;
            this.textBoxInputTextOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputTextOne_KeyPress);
            // 
            // labelInstructionsOne
            // 
            this.labelInstructionsOne.AutoSize = true;
            this.labelInstructionsOne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructionsOne.Location = new System.Drawing.Point(12, 9);
            this.labelInstructionsOne.Name = "labelInstructionsOne";
            this.labelInstructionsOne.Size = new System.Drawing.Size(159, 18);
            this.labelInstructionsOne.TabIndex = 18;
            this.labelInstructionsOne.Text = "Enter the first number:";
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonClearAll.Location = new System.Drawing.Point(203, 82);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(187, 43);
            this.buttonClearAll.TabIndex = 25;
            this.buttonClearAll.Text = "CLEAR ALL";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // Example3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 210);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.textBoxInputTextTwo);
            this.Controls.Add(this.labelInstructionsTwo);
            this.Controls.Add(this.buttonResults);
            this.Controls.Add(this.labelResultValue);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.textBoxInputTextOne);
            this.Controls.Add(this.labelInstructionsOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Example3";
            this.Text = "Number Expressions";
            this.Load += new System.EventHandler(this.ExampleThree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputTextTwo;
        private System.Windows.Forms.Label labelInstructionsTwo;
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.Label labelResultValue;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.TextBox textBoxInputTextOne;
        private System.Windows.Forms.Label labelInstructionsOne;
        private System.Windows.Forms.Button buttonClearAll;
    }
}
namespace C__WinForms_Programs.examples.basic {
    partial class Example1 {
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
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.labelResultValue = new System.Windows.Forms.Label();
            this.buttonShowText = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxInputText.Location = new System.Drawing.Point(290, 6);
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.Size = new System.Drawing.Size(308, 26);
            this.textBoxInputText.TabIndex = 3;
            this.textBoxInputText.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(12, 9);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(272, 18);
            this.labelInstructions.TabIndex = 2;
            this.labelInstructions.Text = "Enter the text you want to appear here:";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.Location = new System.Drawing.Point(12, 112);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(63, 18);
            this.labelResults.TabIndex = 4;
            this.labelResults.Text = "Results:";
            // 
            // textBoxResults
            // 
            this.textBoxResults.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxResults.Location = new System.Drawing.Point(12, 133);
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.Size = new System.Drawing.Size(586, 26);
            this.textBoxResults.TabIndex = 5;
            this.textBoxResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResultValue
            // 
            this.labelResultValue.AutoSize = true;
            this.labelResultValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultValue.Location = new System.Drawing.Point(12, 173);
            this.labelResultValue.Name = "labelResultValue";
            this.labelResultValue.Size = new System.Drawing.Size(128, 18);
            this.labelResultValue.TabIndex = 6;
            this.labelResultValue.Text = "resultPlaceholder";
            this.labelResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShowText
            // 
            this.buttonShowText.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonShowText.Location = new System.Drawing.Point(15, 54);
            this.buttonShowText.Name = "buttonShowText";
            this.buttonShowText.Size = new System.Drawing.Size(288, 43);
            this.buttonShowText.TabIndex = 7;
            this.buttonShowText.Text = "SHOW TEXT";
            this.buttonShowText.UseVisualStyleBackColor = true;
            this.buttonShowText.Click += new System.EventHandler(this.buttonShowText_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonClearAll.Location = new System.Drawing.Point(309, 54);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(288, 43);
            this.buttonClearAll.TabIndex = 8;
            this.buttonClearAll.Text = "CLEAR ALL";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // Example1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 221);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonShowText);
            this.Controls.Add(this.labelResultValue);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.textBoxInputText);
            this.Controls.Add(this.labelInstructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Example1";
            this.Text = "Setting Text to another Textbox or Label";
            this.Load += new System.EventHandler(this.ExampleOne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputText;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Label labelResultValue;
        private System.Windows.Forms.Button buttonShowText;
        private System.Windows.Forms.Button buttonClearAll;
    }
}
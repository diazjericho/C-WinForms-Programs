namespace C__WinForms_Programs {
    partial class WinFormEntry {
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
            this.labelInstructions = new System.Windows.Forms.Label();
            this.buttonActivitySimpleExampleOne = new System.Windows.Forms.Button();
            this.buttonActivitySimpleExampleTwo = new System.Windows.Forms.Button();
            this.buttonActivitySimpleExampleThree = new System.Windows.Forms.Button();
            this.buttonActivitySimpleExampleFour = new System.Windows.Forms.Button();
            this.buttonActivitySimpleExampleFive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(12, 9);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(293, 18);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "Welcome! Click what you want to appear:";
            // 
            // buttonActivitySimpleExampleOne
            // 
            this.buttonActivitySimpleExampleOne.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonActivitySimpleExampleOne.Location = new System.Drawing.Point(15, 45);
            this.buttonActivitySimpleExampleOne.Name = "buttonActivitySimpleExampleOne";
            this.buttonActivitySimpleExampleOne.Size = new System.Drawing.Size(140, 45);
            this.buttonActivitySimpleExampleOne.TabIndex = 1;
            this.buttonActivitySimpleExampleOne.Text = "Example One (Simple)";
            this.buttonActivitySimpleExampleOne.UseVisualStyleBackColor = true;
            this.buttonActivitySimpleExampleOne.Click += new System.EventHandler(this.buttonActivitySimpleExampleOne_Click);
            // 
            // buttonActivitySimpleExampleTwo
            // 
            this.buttonActivitySimpleExampleTwo.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonActivitySimpleExampleTwo.Location = new System.Drawing.Point(161, 45);
            this.buttonActivitySimpleExampleTwo.Name = "buttonActivitySimpleExampleTwo";
            this.buttonActivitySimpleExampleTwo.Size = new System.Drawing.Size(140, 45);
            this.buttonActivitySimpleExampleTwo.TabIndex = 2;
            this.buttonActivitySimpleExampleTwo.Text = "Example Two (Simple)";
            this.buttonActivitySimpleExampleTwo.UseVisualStyleBackColor = true;
            this.buttonActivitySimpleExampleTwo.Click += new System.EventHandler(this.buttonActivitySimpleExampleTwo_Click);
            // 
            // buttonActivitySimpleExampleThree
            // 
            this.buttonActivitySimpleExampleThree.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonActivitySimpleExampleThree.Location = new System.Drawing.Point(307, 45);
            this.buttonActivitySimpleExampleThree.Name = "buttonActivitySimpleExampleThree";
            this.buttonActivitySimpleExampleThree.Size = new System.Drawing.Size(140, 45);
            this.buttonActivitySimpleExampleThree.TabIndex = 3;
            this.buttonActivitySimpleExampleThree.Text = "Example Three (Simple)";
            this.buttonActivitySimpleExampleThree.UseVisualStyleBackColor = true;
            this.buttonActivitySimpleExampleThree.Click += new System.EventHandler(this.buttonActivitySimpleExampleThree_Click);
            // 
            // buttonActivitySimpleExampleFour
            // 
            this.buttonActivitySimpleExampleFour.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonActivitySimpleExampleFour.Location = new System.Drawing.Point(453, 45);
            this.buttonActivitySimpleExampleFour.Name = "buttonActivitySimpleExampleFour";
            this.buttonActivitySimpleExampleFour.Size = new System.Drawing.Size(140, 45);
            this.buttonActivitySimpleExampleFour.TabIndex = 4;
            this.buttonActivitySimpleExampleFour.Text = "Example Four (Simple)";
            this.buttonActivitySimpleExampleFour.UseVisualStyleBackColor = true;
            this.buttonActivitySimpleExampleFour.Click += new System.EventHandler(this.buttonActivitySimpleExampleFour_Click);
            // 
            // buttonActivitySimpleExampleFive
            // 
            this.buttonActivitySimpleExampleFive.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonActivitySimpleExampleFive.Location = new System.Drawing.Point(599, 45);
            this.buttonActivitySimpleExampleFive.Name = "buttonActivitySimpleExampleFive";
            this.buttonActivitySimpleExampleFive.Size = new System.Drawing.Size(140, 45);
            this.buttonActivitySimpleExampleFive.TabIndex = 5;
            this.buttonActivitySimpleExampleFive.Text = "Example Five (Simple)";
            this.buttonActivitySimpleExampleFive.UseVisualStyleBackColor = true;
            this.buttonActivitySimpleExampleFive.Click += new System.EventHandler(this.buttonActivitySimpleExampleFive_Click);
            // 
            // WinFormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 123);
            this.Controls.Add(this.buttonActivitySimpleExampleFive);
            this.Controls.Add(this.buttonActivitySimpleExampleFour);
            this.Controls.Add(this.buttonActivitySimpleExampleThree);
            this.Controls.Add(this.buttonActivitySimpleExampleTwo);
            this.Controls.Add(this.buttonActivitySimpleExampleOne);
            this.Controls.Add(this.labelInstructions);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinFormEntry";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WinForms Entry Point";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Button buttonActivitySimpleExampleOne;
        private System.Windows.Forms.Button buttonActivitySimpleExampleTwo;
        private System.Windows.Forms.Button buttonActivitySimpleExampleThree;
        private System.Windows.Forms.Button buttonActivitySimpleExampleFour;
        private System.Windows.Forms.Button buttonActivitySimpleExampleFive;
    }
}


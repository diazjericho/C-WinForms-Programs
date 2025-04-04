namespace C__WinForms_Programs.activities.basic {
    partial class Activity1 {
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
            this.labelInsName = new System.Windows.Forms.Label();
            this.labelInsAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.radioButtonCpE = new System.Windows.Forms.RadioButton();
            this.radioButtonECE = new System.Windows.Forms.RadioButton();
            this.radioButtonCE = new System.Windows.Forms.RadioButton();
            this.radioButtonArchi = new System.Windows.Forms.RadioButton();
            this.buttonGenerateDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInsName
            // 
            this.labelInsName.AutoSize = true;
            this.labelInsName.Location = new System.Drawing.Point(12, 11);
            this.labelInsName.Name = "labelInsName";
            this.labelInsName.Size = new System.Drawing.Size(154, 18);
            this.labelInsName.TabIndex = 0;
            this.labelInsName.Text = "Enter your first name:";
            // 
            // labelInsAge
            // 
            this.labelInsAge.AutoSize = true;
            this.labelInsAge.Location = new System.Drawing.Point(12, 80);
            this.labelInsAge.Name = "labelInsAge";
            this.labelInsAge.Size = new System.Drawing.Size(150, 18);
            this.labelInsAge.TabIndex = 1;
            this.labelInsAge.Text = "Enter your birth year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select your course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your last name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(172, 8);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(189, 26);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(171, 40);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(189, 26);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(171, 80);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(189, 26);
            this.textBoxAge.TabIndex = 6;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // radioButtonCpE
            // 
            this.radioButtonCpE.AutoSize = true;
            this.radioButtonCpE.Location = new System.Drawing.Point(386, 40);
            this.radioButtonCpE.Name = "radioButtonCpE";
            this.radioButtonCpE.Size = new System.Drawing.Size(183, 22);
            this.radioButtonCpE.TabIndex = 7;
            this.radioButtonCpE.TabStop = true;
            this.radioButtonCpE.Text = "Computer Engineering";
            this.radioButtonCpE.UseVisualStyleBackColor = true;
            // 
            // radioButtonECE
            // 
            this.radioButtonECE.AutoSize = true;
            this.radioButtonECE.Location = new System.Drawing.Point(386, 68);
            this.radioButtonECE.Name = "radioButtonECE";
            this.radioButtonECE.Size = new System.Drawing.Size(191, 22);
            this.radioButtonECE.TabIndex = 8;
            this.radioButtonECE.TabStop = true;
            this.radioButtonECE.Text = "Electronics Engineering";
            this.radioButtonECE.UseVisualStyleBackColor = true;
            // 
            // radioButtonCE
            // 
            this.radioButtonCE.AutoSize = true;
            this.radioButtonCE.Location = new System.Drawing.Point(585, 40);
            this.radioButtonCE.Name = "radioButtonCE";
            this.radioButtonCE.Size = new System.Drawing.Size(144, 22);
            this.radioButtonCE.TabIndex = 9;
            this.radioButtonCE.TabStop = true;
            this.radioButtonCE.Text = "Civil Engineering";
            this.radioButtonCE.UseVisualStyleBackColor = true;
            // 
            // radioButtonArchi
            // 
            this.radioButtonArchi.AutoSize = true;
            this.radioButtonArchi.Location = new System.Drawing.Point(585, 68);
            this.radioButtonArchi.Name = "radioButtonArchi";
            this.radioButtonArchi.Size = new System.Drawing.Size(109, 22);
            this.radioButtonArchi.TabIndex = 10;
            this.radioButtonArchi.TabStop = true;
            this.radioButtonArchi.Text = "Architecture";
            this.radioButtonArchi.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateDetails
            // 
            this.buttonGenerateDetails.Location = new System.Drawing.Point(15, 123);
            this.buttonGenerateDetails.Name = "buttonGenerateDetails";
            this.buttonGenerateDetails.Size = new System.Drawing.Size(716, 38);
            this.buttonGenerateDetails.TabIndex = 11;
            this.buttonGenerateDetails.Text = "GENERATE YOUR DETAILS";
            this.buttonGenerateDetails.UseVisualStyleBackColor = true;
            this.buttonGenerateDetails.Click += new System.EventHandler(this.buttonGenerateDetails_Click);
            // 
            // Activity1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 177);
            this.Controls.Add(this.buttonGenerateDetails);
            this.Controls.Add(this.radioButtonArchi);
            this.Controls.Add(this.radioButtonCE);
            this.Controls.Add(this.radioButtonECE);
            this.Controls.Add(this.radioButtonCpE);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInsAge);
            this.Controls.Add(this.labelInsName);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Activity1";
            this.Text = "Activity 1";
            this.Load += new System.EventHandler(this.Activity1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInsName;
        private System.Windows.Forms.Label labelInsAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.RadioButton radioButtonCpE;
        private System.Windows.Forms.RadioButton radioButtonECE;
        private System.Windows.Forms.RadioButton radioButtonCE;
        private System.Windows.Forms.RadioButton radioButtonArchi;
        private System.Windows.Forms.Button buttonGenerateDetails;
    }
}
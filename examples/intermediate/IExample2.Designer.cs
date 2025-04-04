namespace C__WinForms_Programs.examples.intermediate {
    partial class IExample2 {
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelResultsDateTime = new System.Windows.Forms.Label();
            this.labelResultsMonthPicker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 50);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // labelResultsDateTime
            // 
            this.labelResultsDateTime.AutoSize = true;
            this.labelResultsDateTime.Location = new System.Drawing.Point(325, 18);
            this.labelResultsDateTime.Name = "labelResultsDateTime";
            this.labelResultsDateTime.Size = new System.Drawing.Size(98, 18);
            this.labelResultsDateTime.TabIndex = 2;
            this.labelResultsDateTime.Text = "placeholder1";
            // 
            // labelResultsMonthPicker
            // 
            this.labelResultsMonthPicker.AutoSize = true;
            this.labelResultsMonthPicker.Location = new System.Drawing.Point(325, 50);
            this.labelResultsMonthPicker.Name = "labelResultsMonthPicker";
            this.labelResultsMonthPicker.Size = new System.Drawing.Size(98, 18);
            this.labelResultsMonthPicker.TabIndex = 3;
            this.labelResultsMonthPicker.Text = "placeholder2";
            // 
            // IExample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 231);
            this.Controls.Add(this.labelResultsMonthPicker);
            this.Controls.Add(this.labelResultsDateTime);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IExample2";
            this.Text = "IExample2";
            this.Load += new System.EventHandler(this.IExample2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelResultsDateTime;
        private System.Windows.Forms.Label labelResultsMonthPicker;
    }
}
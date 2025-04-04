using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__WinForms_Programs.activities.basic {
    public partial class Activity1 : Form {

        public string courseSelected = string.Empty;

        public Activity1() {
            InitializeComponent();

            textBoxFirstName.TextChanged += Input_TextChanged;
            textBoxLastName.TextChanged += Input_TextChanged;
            textBoxAge.TextChanged += Input_TextChanged;

            radioButtonCpE.CheckedChanged += radioButton_CheckedChanged;
            radioButtonECE.CheckedChanged += radioButton_CheckedChanged;
            radioButtonCE.CheckedChanged += radioButton_CheckedChanged;
            radioButtonArchi.CheckedChanged += radioButton_CheckedChanged;
        }

        private void Activity1_Load(object sender, EventArgs e) {
            buttonGenerateDetails.Enabled = false;
        }

        private void Input_TextChanged(object sender, EventArgs e) {
            buttonGenerateDetails.Enabled = !string.IsNullOrWhiteSpace(textBoxFirstName.Text) &&
                                            !string.IsNullOrWhiteSpace(textBoxLastName.Text) &&
                                            !string.IsNullOrWhiteSpace(textBoxAge.Text);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonCpE.Checked) {
                courseSelected = "Computer Engineering";
            } else if (radioButtonECE.Checked) {
                courseSelected = "Electronics Engineering";
            } else if (radioButtonCE.Checked) {
                courseSelected = "Civil Engineering";
            } else if (radioButtonArchi.Checked) {
                courseSelected = "Architecture";
            } else {
                courseSelected = "None";
            }
        }

        private void buttonGenerateDetails_Click(object sender, EventArgs e) {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string fullName = $"{firstName} {lastName}";

            // Assuming today's year is 2025
            string age = textBoxAge.Text;
            if (int.Parse(age) > 1995 && int.Parse(age) < 2025) {
                int finalAge = 2025 - int.Parse(age);

                if (courseSelected != "None") {
                    MessageBox.Show($"Hello, {fullName}! Your age is {finalAge} and you didn't selected any courses!");
                } else {
                    MessageBox.Show($"Hello, {fullName}! Your age is {finalAge} and your course is {courseSelected}!");
                }
            } else {
                MessageBox.Show($"Are you even human?!");
            }
            
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e) {
            // Allow digits (0-9), backspace, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true; // Block invalid input
            }
        }
    }
}

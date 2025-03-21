using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__WinForms_Programs.examples.basic {
    public partial class Example3 : Form {
        public Example3() {
            InitializeComponent();

            textBoxInputTextOne.TextChanged += Input_TextChanged;
            textBoxInputTextTwo.TextChanged += Input_TextChanged;
        }

        private void Input_TextChanged(object sender, EventArgs e) {
            // Enable the button only if BOTH textboxes contain non-empty text
            buttonResults.Enabled = !string.IsNullOrWhiteSpace(textBoxInputTextOne.Text) &&
                                        !string.IsNullOrWhiteSpace(textBoxInputTextTwo.Text);
            buttonClearAll.Enabled = !string.IsNullOrWhiteSpace(textBoxInputTextOne.Text) &&
                                        !string.IsNullOrWhiteSpace(textBoxInputTextTwo.Text);
        }

        private void ExampleThree_Load(object sender, EventArgs e) {
            buttonResults.Enabled = false;
            buttonClearAll.Enabled = false;

            labelResultValue.Text = string.Empty;
        }

        private void buttonResults_Click(object sender, EventArgs e) {
            string input1 = textBoxInputTextOne.Text;
            string input2 = textBoxInputTextTwo.Text;
            if (float.TryParse(input1, out float number1) && float.TryParse(input2, out float number2)) {
                float result = number1 + number2;

                labelResultValue.Text = result.ToString();
            } else {
                MessageBox.Show("You entered invalid input!");
            }
        }

        private void textBoxInputTextOne_KeyPress(object sender, KeyPressEventArgs e) {
            // Allow digits (0-9), backspace, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true; // Block invalid input
            }

            // Ensure only one decimal point is allowed
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains(".")) {
                e.Handled = true; // Block second decimal point
            }
        }

        private void textBoxInputTextTwo_KeyPress(object sender, KeyPressEventArgs e) {
            // Allow digits (0-9), backspace, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true; // Block invalid input
            }

            // Ensure only one decimal point is allowed
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains(".")) {
                e.Handled = true; // Block second decimal point
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e) {
            textBoxInputTextOne.Clear();
            textBoxInputTextTwo.Clear();

            labelResultValue.Text = string.Empty;

            MessageBox.Show("All fields have been cleared.");
        }
    }
}

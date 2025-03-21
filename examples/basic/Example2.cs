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
    public partial class Example2 : Form {
        public Example2() {
            InitializeComponent();

            textBoxInputTextOne.TextChanged += Input_TextChanged;
            textBoxInputTextTwo.TextChanged += Input_TextChanged;
        }

        private void ExampleTwo_Load(object sender, EventArgs e) {
            // Disable the buttons
            buttonCombineText.Enabled = false;
            buttonClearAll.Enabled = false;

            // Show initial text
            labelResultValue.Text = "The combined text will show in this label.";
        }

        private void Input_TextChanged(object sender, EventArgs e) {
            // Enable the button only if BOTH textboxes contain non-empty text
            buttonCombineText.Enabled = !string.IsNullOrWhiteSpace(textBoxInputTextOne.Text) &&
                                        !string.IsNullOrWhiteSpace(textBoxInputTextTwo.Text);

            buttonClearAll.Enabled = !string.IsNullOrWhiteSpace(textBoxInputTextOne.Text) &&
                                        !string.IsNullOrWhiteSpace(textBoxInputTextTwo.Text);
        }

        private void buttonShowText_Click(object sender, EventArgs e) {
            string textOne = textBoxInputTextOne.Text;
            string textTwo = textBoxInputTextTwo.Text;
            string results = $"{textOne} {textTwo}";

            // show the results
            labelResultValue.Text = results;
        }

        private void buttonClearAll_Click(object sender, EventArgs e) {
            textBoxInputTextOne.Clear();
            textBoxInputTextTwo.Clear();

            labelResultValue.Text = "The label has been cleared!";
        }
    }
}

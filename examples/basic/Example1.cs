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
    public partial class Example1 : Form {
        public Example1() {
            InitializeComponent();

            // Attaching the text change event everytime that the action runs
            textBoxInputText.TextChanged += textBoxInput_TextChanged;
        } 

        private void ExampleOne_Load(object sender, EventArgs e) {
            // Disable the buttons
            buttonShowText.Enabled = false;
            buttonClearAll.Enabled = false;

            // Show initial text
            textBoxResults.Text = "The text will show in this text box.";
            labelResultValue.Text = "The text will show in this label.";
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e) {
            // Check if they are null, spaces only, or not
            buttonShowText.Enabled = !string.IsNullOrWhiteSpace(textBoxInputText.Text);
            buttonClearAll.Enabled = !string.IsNullOrWhiteSpace(textBoxInputText.Text);
        }

        private void buttonShowText_Click(object sender, EventArgs e) {
            // Get the value of the textbox
            string input = textBoxInputText.Text;

            // Show the value of the entered input
            textBoxResults.Text = input;
            labelResultValue.Text = input;
        }

        private void buttonClearAll_Click(object sender, EventArgs e) {
            // Clear the text in the input field
            textBoxInputText.Clear();

            // Show cleared text results
            textBoxResults.Text = "The text has been cleared in this text box!";
            labelResultValue.Text = "The text has been cleared in this label!";
        }
    }
}

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
    public partial class Example4 : Form {
        public Example4() {
            InitializeComponent();

            // Add options to ComboBox
            comboBoxOptions.Items.Add("None");
            comboBoxOptions.Items.Add("CpE");
            comboBoxOptions.Items.Add("ECE"); 

            // Set the texts depending on the selected options
            comboBoxOptions.SelectedIndexChanged += comboBoxOptions_SelectedIndexChanged;
        }

        private void Example4_Load(object sender, EventArgs e) {
            labelResultValue1.Text = string.Empty;
            labelResultValue2.Text = string.Empty;
        }

        private void comboBoxOptions_SelectedIndexChanged(object sender, EventArgs e) {
            string optionSelected = comboBoxOptions.SelectedItem.ToString();

            switch (optionSelected) { 
                case "None":
                    labelResultValue1.Text = "You selected 'None'.";
                    labelResultValue2.Text = "This will show no text.";
                    break;
                case "CpE":
                    labelResultValue1.Text = "You selected 'CpE'.";
                    labelResultValue2.Text = "Computer Engineering.";
                    break;
                case "ECE":
                    labelResultValue1.Text = "You selected 'ECE'.";
                    labelResultValue2.Text = "Electronics and Communications Engineering.";
                    break;
            }
        }
    }
}

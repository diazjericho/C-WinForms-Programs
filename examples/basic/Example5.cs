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
    public partial class Example5 : Form {
        public Example5() {
            InitializeComponent();

            radioButtonNone.CheckedChanged += radioButton_CheckedChanged;
            radioButtonCpE.CheckedChanged += radioButton_CheckedChanged;
            radioButtonECE.CheckedChanged += radioButton_CheckedChanged;
        }

        private void Example5_Load(object sender, EventArgs e) {
            labelResultValue1.Text = string.Empty;
            labelResultValue2.Text = string.Empty;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonNone.Checked) {
                labelResultValue1.Text = "You selected 'None'.";
                labelResultValue2.Text = "This will show no text.";
            } else if (radioButtonCpE.Checked) {
                labelResultValue1.Text = "You selected 'CpE'.";
                labelResultValue2.Text = "Computer Engineering.";
            } else if (radioButtonECE.Checked) {
                labelResultValue1.Text = "You selected 'ECE'.";
                labelResultValue2.Text = "Electronics and Communications Engineering.";
            }
        }
    }
}

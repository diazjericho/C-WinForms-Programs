using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C__WinForms_Programs.examples.basic;

namespace C__WinForms_Programs {
    public partial class WinFormEntry : Form {
        public WinFormEntry() {
            InitializeComponent();
        } 

        private void buttonActivitySimpleExampleOne_Click(object sender, EventArgs e) {
            // Show the first form
            Example1 exampleOne = new Example1();

            // This will disable the main form
            exampleOne.ShowDialog();

            // This will enable the main form
            //exampleOne.Show();
        }

        private void buttonActivitySimpleExampleTwo_Click(object sender, EventArgs e) {
            // Show the second form
            Example2 exampleTwo = new Example2();

            // This will disable the main form
            exampleTwo.ShowDialog();

            // This will enable the main form
            //exampleOne.Show();
        }

        private void buttonActivitySimpleExampleThree_Click(object sender, EventArgs e) {
            Example3 exampleThree = new Example3();
            exampleThree.ShowDialog();
        }

        private void buttonActivitySimpleExampleFour_Click(object sender, EventArgs e) {
            Example4 exampleFour = new Example4();
            exampleFour.ShowDialog();
        }

        private void buttonActivitySimpleExampleFive_Click(object sender, EventArgs e) {
            Example5 exampleFive = new Example5();
            exampleFive.ShowDialog();
        }
    }
}

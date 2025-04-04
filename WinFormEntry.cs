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
using C__WinForms_Programs.activities.basic;
using C__WinForms_Programs.examples.intermediate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace C__WinForms_Programs {
    public partial class WinFormEntry : Form {
        public WinFormEntry() {
            InitializeComponent();

            comboBoxOptionList.Items.Add("Examples (Simple)");
            comboBoxOptionList.Items.Add("Examples (Intermediate)");
            comboBoxOptionList.Items.Add("Activities");

            comboBoxOptionList.SelectedIndexChanged += comboBoxOptionList_SelectedIndexChanged;

            // Set initial visibility
            SetButtonVisibility("Examples");
        }

        private void comboBoxOptionList_SelectedIndexChanged(object sender, EventArgs e) {
            // Change button visibility based on selection
            string selectedOption = comboBoxOptionList.SelectedItem.ToString();
            SetButtonVisibility(selectedOption);
        }

        private void SetButtonVisibility(string category) {
            switch (category) {
                case "Examples (Simple)":
                    buttonActivitySimpleExampleOne.Visible = true;
                    buttonActivitySimpleExampleOne.Text = "Example One (Simple)";

                    buttonActivitySimpleExampleTwo.Visible = true;
                    buttonActivitySimpleExampleThree.Visible = true;
                    buttonActivitySimpleExampleFour.Visible = true;
                    buttonActivitySimpleExampleFive.Visible = true;
                    break;
                case "Examples (Intermediate)":
                    buttonActivitySimpleExampleOne.Visible = true;
                    buttonActivitySimpleExampleOne.Text = "Example One (Intermediate)";

                    buttonActivitySimpleExampleTwo.Visible = true;
                    buttonActivitySimpleExampleTwo.Text = "Example Two (Intermediate)";

                    buttonActivitySimpleExampleThree.Visible = true;
                    buttonActivitySimpleExampleThree.Text = "Example Three (Intermediate)";

                    buttonActivitySimpleExampleFour.Visible = false;
                    buttonActivitySimpleExampleFive.Visible = false;
                    break;
                case "Activities":
                    buttonActivitySimpleExampleOne.Visible = true;
                    buttonActivitySimpleExampleOne.Text = "Activity 1 (Simple)";

                    buttonActivitySimpleExampleTwo.Visible = false;
                    buttonActivitySimpleExampleThree.Visible = false;
                    buttonActivitySimpleExampleFour.Visible = false;
                    buttonActivitySimpleExampleFive.Visible = false;
                    break;
            }
        }

        private void buttonActivitySimpleExampleOne_Click(object sender, EventArgs e) {
            // Open different forms based on the selected category
            string selectedOption = comboBoxOptionList.SelectedItem?.ToString(); // Handle null

            switch (selectedOption) {
                case "Examples (Simple)":
                    Example1 exampleOne = new Example1();

                    exampleOne.ShowDialog();
                    break;
                case "Examples (Intermediate)":
                    IExample1 IexampleOne = new IExample1();

                    IexampleOne.ShowDialog();
                    break;
                case "Activities":
                    Activity1 activityOne = new Activity1();
                    activityOne.ShowDialog();
                    break;
            }
        }

        private void buttonActivitySimpleExampleTwo_Click(object sender, EventArgs e) {
            // Open different forms based on the selected category
            string selectedOption = comboBoxOptionList.SelectedItem?.ToString(); // Handle null
            switch (selectedOption) {
                case "Examples (Simple)":
                    Example2 exampleTwo = new Example2();

                    exampleTwo.ShowDialog();
                    break;
                case "Examples (Intermediate)":
                    IExample2 IexampleTwo = new IExample2();

                    IexampleTwo.ShowDialog();
                    break;
                case "Activities":
                   
                    break;
            }
        }

        private void buttonActivitySimpleExampleThree_Click(object sender, EventArgs e) {
            // Open different forms based on the selected category
            string selectedOption = comboBoxOptionList.SelectedItem?.ToString(); // Handle null
            switch (selectedOption) {
                case "Examples (Simple)":
                    Example3 exampleThree = new Example3();

                    exampleThree.ShowDialog();
                    break;
                case "Examples (Intermediate)":
                    IExample3 IexampleThree = new IExample3();

                    IexampleThree.ShowDialog();
                    break;
                case "Activities":

                    break;
            }
        }

        private void buttonActivitySimpleExampleFour_Click(object sender, EventArgs e) {
            Example4 exampleFour = new Example4();
            exampleFour.ShowDialog();
        }

        private void buttonActivitySimpleExampleFive_Click(object sender, EventArgs e) {
            Example5 exampleFive = new Example5();
            exampleFive.ShowDialog();
        }

        private void WinFormEntry_Load(object sender, EventArgs e) {
            // Set initial visibility
            SetButtonVisibility("Examples (Simple)");
            comboBoxOptionList.SelectedText = "Examples (Simple)";
        }
    }
}

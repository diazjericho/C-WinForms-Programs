using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__WinForms_Programs.examples.intermediate {
    public partial class IExample1 : Form {

        private List<string> selectedCourses = new List<string>();
        private Dictionary<string, string> courseMap = new Dictionary<string, string>() {
                { "CpE", "Computer Engineering" },
                { "ECE", "Electronics Engineering" },
                { "CE", "Civil Engineering" },
                { "Archi", "Architecture" }
        };

        public IExample1() {
            InitializeComponent();

            checkBoxCpE.CheckedChanged += checkBoxCpE_CheckedChanged;
            checkBoxECE.CheckedChanged += checkBoxCpE_CheckedChanged;
            checkBoxCE.CheckedChanged += checkBoxCpE_CheckedChanged;
            checkBoxArchi.CheckedChanged += checkBoxCpE_CheckedChanged;
        }

        private void checkBoxCpE_CheckedChanged(object sender, EventArgs e) {
            int totalCheckboxes = 4; // Total number of checkboxes
            int checkedCount = 0;

            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked) {
                // Add the full course name if not already in the list
                if (!selectedCourses.Contains(courseMap[checkBox.Text])) {
                    selectedCourses.Add(courseMap[checkBox.Text]);
                }
            }
            else {
                // Properly remove the full course name from the list
                selectedCourses.Remove(courseMap[checkBox.Text]);
            }

            // Properly count ALL checked checkboxes
            foreach (Control control in this.Controls) {
                if (control is CheckBox cb && cb.Checked) // Check ALL checkboxes
                {
                    checkedCount++;
                }
            }

            // Correct percentage calculation
            int progressPercentage = (checkedCount * 100) / totalCheckboxes;

            // Prevent progress bar overflow
            progressBar1.Value = Math.Min(progressPercentage, progressBar1.Maximum);

            // Update label
            labelResultValue.Text = selectedCourses.Count > 0
                ? $"You selected {string.Join(", ", selectedCourses)}."
                : "Select one!";

        }

        private void Example1_Load(object sender, EventArgs e) {
            labelResultValue.Text = string.Empty;
            progressBar1.Value = 0;
        }
    }
}

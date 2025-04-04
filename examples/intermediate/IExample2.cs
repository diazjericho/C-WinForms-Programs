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
    public partial class IExample2 : Form {
        public IExample2() {
            InitializeComponent();
        }

        private void IExample2_Load(object sender, EventArgs e) {
            labelResultsDateTime.Text = string.Empty;
            labelResultsMonthPicker.Text = string.Empty;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            DateTime selectedDate = dateTimePicker1.Value; // Gets the selected date
            labelResultsDateTime.Text = "Selected Date: " + selectedDate.ToString("MMMM dd, yyyy");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            labelResultsMonthPicker.Text = "Selected Date: " + selectedDate.ToShortDateString();
        }
    }
}

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
    public partial class IExample3 : Form {
        public IExample3() {
            InitializeComponent();
        }

        private void buttonGetImage_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    // Get the path of selected image
                    string imagePath = openFileDialog.FileName;

                    // Show the image in PictureBox
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Optional: Show image path in label or textbox
                    labelResults.Text = imagePath;
                }
            }
        }

        private void IExample3_Load(object sender, EventArgs e) {
            labelResults.Text = string.Empty;
        }
    }
}

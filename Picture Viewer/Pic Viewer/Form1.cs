using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pic_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            // When you double-clicked the Show a picture button in Windows Forms Designer, the IDE automatically added a method to your program's code.
            //•Methods are how you organize your code: It's how your code is grouped together.
            //•Most of the time, a method does a small number of things in a specific order, like how your showButton_Click() method shows a dialog box and then loads a picture.A method is made up of code statements, or lines of code.Think of a method as a way to bundle code statements together.
            //When a method is executed, or called, the statements in the method are executed in order, one after another, starting with the first one.
            //Show the Open File dialog. If the user clicks OK, load the
            //picture in that mode



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            //Clear the image.
            pictureBox1.Image = null;
        }

        private void backgroundbutton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            //Close form...
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

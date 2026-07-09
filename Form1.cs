using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingStartedWithSourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Collect values from the user
            int valueOne = Convert.ToInt32(valueOneTextBox.Text);
            int valueTwo = Convert.ToInt32(valueTwoTextBox.Text);

            // Decide operation to be performed

            // Perform Operation (call method from math class)

            // Display results to the user

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Logic to clear the textbox's and combo box
        }
    }
}

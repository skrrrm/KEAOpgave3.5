using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Udarbejd et lille program, hvor brugeren får besked på om et indtastet tal ligger mellem 10 og 20

namespace KEAOpgave3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelInfo.Text = "Write a number between 10 and 20.";
        }

        // Variables 
        double result;

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                result = Convert.ToDouble(textBoxNumber.Text); // Converts to double
            }
            catch
            {
                labelInfo.Text = "Numbers only"; // error 
                
            }

            if (result >= 10 && result <= 20) // if number is or over 10 and if number is below 20
                labelRes.Text = "Correct!";
            else
                labelRes.Text = "Incorrect!";
        }
    }
}

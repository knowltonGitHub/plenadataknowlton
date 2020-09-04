using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlenaDataTest
{
    public partial class RewriteString : Form
    {
        //Class instance that will do all the string analysis and manipulation
        StringManip _sm;
        public RewriteString()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void buttonEvaluateString_Click(object sender, EventArgs e)
        {
            //Initialize StringManip variable with original string to evaluate
            _sm = new StringManip(textBoxStringToEvaluate.Text);


            //Using the user’s inputted string, find the first letter that is not repeated.
            _sm.AnalyzeLetterRepetition();


            //For example: If given the string ‘Bubble’, the letter ‘u’ would be the 
            //first character returned from the program.Once the first character is 
            //found and displayed back to the user, rewrite the string in order of 
            //number of occurrences and order from the inputted string.In the above 
            //example ‘Bubble’ would then be rewritten as ‘uleBbb’. Display this to the user.

            textBoxResults.Text = "First non-repeating character:  " + _sm.GetFirstNonRepeatingChar().ToString() + System.Environment.NewLine + System.Environment.NewLine;

            textBoxResults.Text +="Rewritten string according to rules given:  " + _sm.RewriteTheString();                     
        }

        private void ClearAndReset()
        {
            textBoxStringToEvaluate.Text = "";
            textBoxResults.Text = "";
            textBoxStringToEvaluate.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAndReset();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10gtelte30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MatchCollection numsInString = Regex.Matches(textBox1.Text, @"[0-9]+");
            labelOutput.Text = "Numbers are: ";
            foreach (Match s in numsInString)
            {
                int num = int.Parse(s.Value.ToString());

                if (num >= 10 && num <= 30)
                {
                    labelOutput.Text += $"{num}  ";
                }
            }


        }
    }
}

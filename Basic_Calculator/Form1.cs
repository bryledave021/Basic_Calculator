using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        string Basic_Operations;
        double FirstVariable;
        
        public Form1()
        {
            InitializeComponent();
           
        }


 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            
            double SecondVariable;
            string AnswersCalc;
            SecondVariable = double.Parse(Screen_.Text);
            if (Basic_Operations == "Addition") {
                AnswersCalc  = (FirstVariable + SecondVariable).ToString();
                Screen_.Text = AnswersCalc;
                Basic_Operations = "Equals";
            }
            if (Basic_Operations == "Subtraction")
            {
                AnswersCalc = (FirstVariable - SecondVariable).ToString();
                Screen_.Text = AnswersCalc;
                Basic_Operations = "Equals";
            }
            if (Basic_Operations == "Multiplication")
            {
                AnswersCalc = (FirstVariable * SecondVariable).ToString();
                Screen_.Text = AnswersCalc;
                Basic_Operations = "Equals";
            }
            if (Basic_Operations == "Division")
            {
                AnswersCalc = (FirstVariable / SecondVariable).ToString();
                Screen_.Text = AnswersCalc;
                Basic_Operations = "Equals";
            }
            
        }

        private void num0_Click(object sender, EventArgs e)
        {
            int num_0 = 0;
            if (Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += num_0;
            }
            else
            {
                Screen_.Text += num_0;
            }
        }

       
        private void num1_Click(object sender, EventArgs e)
        {
            int num_1 = 1;
            if (Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += num_1;
            }
            else
            {
                Screen_.Text += num_1;
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            int num_2 = 2;
            if (Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += num_2;
            }
            else
            {
                Screen_.Text += num_2;
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            int num_3 = 3;
            if (Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += num_3;
            }
            else
            {
                Screen_.Text += num_3;
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            int num_4 = 4;
            if(Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += num_4;
            }
            else
            {
                Screen_.Text += num_4;
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            int num_5 = 5;
            if (Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += num_5;
            }
            else
            {
                Screen_.Text += num_5;
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            int num_6 = 6;
            if (Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += num_6;
            }
            else
            {
                Screen_.Text += num_6;
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            int num_7 = 7;
            if (Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += num_7;
            }
            else
            {
                Screen_.Text += num_7;
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            int num_8 = 8;
            if (Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += num_8;
            }
            else
            {
                Screen_.Text += num_8;
            }

        }

        private void num9_Click(object sender, EventArgs e)
        {
            int num_9 = 9;
            if (Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += num_9;
            }
            else {
                Screen_.Text += num_9;
            }
        }

        
        private void Sum_btn_Click(object sender, EventArgs e)
        {
            FirstVariable = double.Parse(Screen_.Text);
            Screen_.Text = "";
            Basic_Operations = "Addition";
           
           
        }

        private void Subtract_btn_Click(object sender, EventArgs e)
        {
            FirstVariable = double.Parse(Screen_.Text);
            Screen_.Text = "";
            Basic_Operations = "Subtraction";
        }

        private void Multiplication_btn_Click(object sender, EventArgs e)
        {
            FirstVariable = double.Parse(Screen_.Text);
            Screen_.Text = "";
            Basic_Operations = "Multiplication";
        }

        private void Divide_btn_Click(object sender, EventArgs e)
        {
            FirstVariable = double.Parse(Screen_.Text);
            Screen_.Text = "";
            Basic_Operations = "Division";
        }

        private void Decimal_btn_Click(object sender, EventArgs e)
        {

        
            if (Basic_Operations == "Equals")
            {
                Screen_.Text = "";
                Screen_.Text += ".";
            }
            else
            {
                Screen_.Text += ".";
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Screen_.Text = "";
            Basic_Operations = "";

        }
    }
}

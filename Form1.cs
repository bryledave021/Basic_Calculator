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

        public Form1()
        {
            InitializeComponent();
        }


 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
          

        }

        private void num0_Click(object sender, EventArgs e)
        {
            int num_0 = 0;
            Screen_.Text += num_0;
        }

       
        private void num1_Click(object sender, EventArgs e)
        {
            int num_1 = 1;
            Screen_.Text += num_1;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            int num_2 = 2;
            Screen_.Text += num_2;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            int num_3 = 3;
            Screen_.Text += num_3;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            int num_4 = 4; 
            Screen_.Text += num_4;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            int num_5 = 5;
            Screen_.Text += num_5;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            int num_6 = 6;
            Screen_.Text += num_6;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            int num_7 = 7;
            Screen_.Text += num_7;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            int num_8 = 8;
            Screen_.Text += num_8;
            
        }

        private void num9_Click(object sender, EventArgs e)
        {
            int num_9 = 9;
           Screen_.Text += num_9;
           
        }

        
        private void Sum_btn_Click(object sender, EventArgs e)
        {
            int variable1 = int.Parse(Screen_.Text);
            int variable2 = int.Parse(Screen_2.Text);
            Screen_Answer.Text = (variable1 + variable2).ToString();
           
        }

        private void Subtract_btn_Click(object sender, EventArgs e)
        {
            int variable1 = int.Parse(Screen_.Text);
            int variable2 = int.Parse(Screen_2.Text);
            Screen_Answer.Text = (variable1 - variable2).ToString();
        }

        private void Multiplication_btn_Click(object sender, EventArgs e)
        {
            int variable1 = int.Parse(Screen_.Text);
            int variable2 = int.Parse(Screen_2.Text);
            Screen_Answer.Text = (variable1 * variable2).ToString();
        }

        private void Divide_btn_Click(object sender, EventArgs e)
        {
            int variable1 = int.Parse(Screen_.Text);
            int variable2 = int.Parse(Screen_2.Text);
            Screen_Answer.Text = (variable1 / variable2).ToString();
        }
    }
}

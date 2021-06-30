using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Basic_Calculator
{
    public partial class MyCalculator : Form
    {
        

        Methods Calculate = new Methods();
        public MyCalculator()
        {
            InitializeComponent();
        }

        private void NumberInput(String number) {
            if (Calculate.Basic_Operations1 == "Equals")
            {
                txtbx_Answer.Text = "";
                txtbx_Screen.Text = "";
                Calculate.Basic_Operations1 = "";
                txtbx_Answer.Text += number;
            }
            else
            {
                txtbx_Answer.Text += number;
            }
        }
        private void TryCatchCycle(String Num_Operations, String Basic_Op) {
            try
            {
                Calculate.FirstVariable1 = double.Parse(txtbx_Answer.Text);
                txtbx_Screen.Text = txtbx_Answer + Num_Operations;
                txtbx_Answer.Text = "";
                Calculate.Basic_Operations1 = Basic_Op;
            }
            catch
            {
                MessageBox.Show("Input a number First!");
            }
        }

        private void btn_Zero_Click(object sender, EventArgs e)
        {
            NumberInput("0");
        }

        private void btn_num1_Click(object sender, EventArgs e)
        {
            NumberInput("1");
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            NumberInput("2");
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            NumberInput("3");
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            NumberInput("4");
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            NumberInput("5");
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            NumberInput("6");
        }

        private void btn_Num7_Click(object sender, EventArgs e)
        {
            NumberInput("7");
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            NumberInput("8");
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            NumberInput("9");
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            NumberInput(".");
        }

      

        private void btn_Equal_Click(object sender, EventArgs e)
        {
           Calculate.SecondVariable1 = double.Parse(txtbx_Answer.Text);
            if (Calculate.Basic_Operations1 == "Addition")
            {
                Calculate.Addition();
                txtbx_Answer.Text = Calculate.AnswerCalc1;
                txtbx_Screen.Text = txtbx_Screen.Text + Calculate.SecondVariable1.ToString() + "=";
            
            }
            if (Calculate.Basic_Operations1 == "Subtraction")
            {
                Calculate.Subtraction();
                txtbx_Answer.Text = Calculate.AnswerCalc1;
                txtbx_Screen.Text = txtbx_Screen.Text + Calculate.SecondVariable1.ToString() + "=";
            }
            if (Calculate.Basic_Operations1 == "Multiplication")
            {
                Calculate.Multiplication();
                txtbx_Answer.Text = Calculate.AnswerCalc1;
                txtbx_Screen.Text = txtbx_Screen.Text + Calculate.SecondVariable1.ToString() + "=";
            }
            if (Calculate.Basic_Operations1 == "Division")
            {
                Calculate.Division();
                txtbx_Answer.Text = Calculate.AnswerCalc1;
                txtbx_Screen.Text = txtbx_Screen.Text + Calculate.SecondVariable1.ToString() + "=";
            }
        }

        private void btn_Subtraction_Click(object sender, EventArgs e)
        {
            TryCatchCycle("-", "Subtraction");
        }

        private void btn_Multiplication_Click(object sender, EventArgs e)
        {
            TryCatchCycle("*", "Multiplication");
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            TryCatchCycle("/", "Division");
        }
        private void btn_Addition_Click(object sender, EventArgs e)
        {

            TryCatchCycle("+", "Addition");
        }

        private void btn_PrevAns_Click(object sender, EventArgs e)
        {
            int CalculatedAnswer;

            CalculatedAnswer = int.Parse(Calculate.AnswerCalc1);
            Calculate.SecondVariable1 = CalculatedAnswer;

            if (Calculate.Basic_Operations1 == "Equals")
            {
                txtbx_Answer.Text = "";
                txtbx_Screen.Text = "";
                Calculate.Basic_Operations1 = "";
                txtbx_Answer.Text += Calculate.SecondVariable1;
            }
            else
            {
                txtbx_Answer.Text += Calculate.SecondVariable1;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbx_Answer.Text = "";
            txtbx_Screen.Text = "";
            Calculate.Basic_Operations1 = "";
        }
    }
}

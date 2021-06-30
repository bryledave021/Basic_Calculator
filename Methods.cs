using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Basic_Calculator
{
    class Methods
    {
        private double FirstVariable;

        public double FirstVariable1 { get => FirstVariable; set => FirstVariable = value; }
        public double SecondVariable1 { get => SecondVariable; set => SecondVariable = value; }
        public string Basic_Operations1 { get => Basic_Operations; set => Basic_Operations = value; }
        public string AnswerCalc1 { get => AnswerCalc; set => AnswerCalc = value; }

        private double SecondVariable;

        private string Basic_Operations;
        private string AnswerCalc;

        public void Addition() {
            AnswerCalc = (FirstVariable1 + SecondVariable1).ToString();
            Basic_Operations1 = "Equals";

        }
        public void Subtraction() {
            AnswerCalc = (FirstVariable1 - SecondVariable1).ToString();
            Basic_Operations1 = "Equals";
        }
        public void Multiplication() {
            AnswerCalc = (FirstVariable1 * SecondVariable1).ToString();
            Basic_Operations1 = "Equals";
        }
        public void Division() {
            AnswerCalc = (FirstVariable1 / SecondVariable1).ToString();
            Basic_Operations1 = "Equals";
        }
    }
}

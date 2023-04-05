using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cv9
{
    internal class Calculator
    {
        public CalcState calcState;
        public Operation operation;
        public string Value;
        public string ValuePast;
        public Calculator()
        {
            operation = Operation.None;
            calcState = CalcState.FirstNum;
            Value = "";
            ValuePast = "";

        }
        public enum CalcState
        {
            FirstNum,
            Operation,
            SecondNum,
            Result,

        }
        public enum Operation
        {
            None,
            Addition,
            Subtraction,
            Multiplication,
            Division,
            Exponentiation,
            Equals,

        }
        public void Click(string content)
        {

            switch (content)
            {
                case "+":
                    if (Value == "") { Value = "0"; }
                    operation = Operation.Addition;
                    calcState = CalcState.SecondNum;
                    ValuePast = Value;
                    Value = "";
                    break;

                case "-":
                    if (Value == "") { Value = "0"; }
                    operation = Operation.Subtraction;
                    calcState = CalcState.SecondNum;
                    ValuePast = Value;
                    Value = "";
                    break;

                case "*":
                    if (Value == "") { Value = "0"; }
                    operation = Operation.Multiplication;
                    calcState = CalcState.SecondNum;
                    ValuePast = Value;
                    Value = "";
                    break;

                case "/":
                    if (Value == "") { Value = "0"; }
                    operation = Operation.Division;
                    calcState = CalcState.SecondNum;
                    ValuePast = Value;
                    Value = "";
                    break;

                case "^":
                    if (Value == "") { Value = "0"; }
                    operation = Operation.Exponentiation;
                    calcState = CalcState.SecondNum;
                    ValuePast = Value;
                    Value = "";
                    break;

                case "+/-":
                    if (Value == "") { Value = "0"; }
                    Value = Negate();
                    break;

                case "CE":
                    Value = "";
                    break;

                case "C":
                    Value = "";
                    ValuePast = "";
                    calcState = CalcState.FirstNum;
                    operation = Operation.None;
                    break;

                case "=":
                    if (Value == "") { Value = "0"; }
                    calcState = CalcState.Result;
                    switch (operation)
                    {
                        case Operation.Addition:
                            Value = Addition();
                            break;

                        case Operation.Subtraction:
                            Value = Subtraction();
                            break;

                        case Operation.Multiplication:
                            Value = Multiplication();
                            break;

                        case Operation.Division:
                            Value = Division();
                            break;

                        case Operation.Exponentiation:
                            Value = Exponentiation();
                            break;

                        default:
                            break;
                    }

                    break;


                case "<-":
                    if (Value.Length > 0)
                    {
                        Value = Value.Substring(0, Value.Length - 1);
                    }
                    break;


                default:
                    if (calcState == CalcState.Result)
                    {
                        calcState = CalcState.FirstNum;
                        Value = "";
                    }
                    if (calcState == CalcState.FirstNum)
                    {
                        Value = Value + content;
                    }
                    if (calcState == CalcState.SecondNum)
                    {
                        Value = Value + content;
                    }
                    break;
            }
            
            
        }
        public string GetOperation()
        {
            if (operation == Operation.Addition) { return " +"; }
            if (operation == Operation.Subtraction) { return " -"; }
            if (operation == Operation.Multiplication) { return " *"; }
            if (operation == Operation.Division) { return " /"; }
            if (operation == Operation.Exponentiation) { return " ^"; }
            if (operation == Operation.Equals) { return " = "; }
            return "";
        }
        private string Addition()
        {
            if (Value == "") {Value = "0";}
            if (ValuePast == "") { ValuePast = "0"; }
            double first_num = Double.Parse(Value);
            double second_num = Double.Parse(ValuePast);
            double result = first_num + second_num;
            string return_string = result.ToString();
            return return_string;
        }
        private string Subtraction()
        {
            if (Value == "") { Value = "0"; }
            if (ValuePast == "") { ValuePast = "0"; }
            double first_num = Double.Parse(ValuePast);
            double second_num = Double.Parse(Value);
            double result = first_num - second_num;
            string return_string = result.ToString();
            return return_string;
        }
        private string Multiplication()
        {
            if (Value == "") { Value = "0"; }
            if (ValuePast == "") { ValuePast = "0"; }
            double first_num = Double.Parse(ValuePast);
            double second_num = Double.Parse(Value);
            double result = first_num * second_num;
            string return_string = result.ToString();
            return return_string;
        }
        private string Division()
        {
            if (Value == "") { Value = "0"; }
            if (ValuePast == "") { ValuePast = "0"; }
            if (Value == "0") { return "DIVISION BY 0!"; }
            double first_num = Double.Parse(ValuePast);
            double second_num = Double.Parse(Value);
            double result = first_num / second_num;
            string return_string = result.ToString();
            return return_string;
        }
        private string Negate()
        {
            if (Value == "") { Value = "0"; }
            if (ValuePast == "") { ValuePast = "0"; }
            double first_num = Double.Parse(Value);
            double result = first_num * (-1);
            string return_string = result.ToString();
            return return_string;
        }
        private string Exponentiation()
        {
            if (Value == "") { Value = "0"; }
            if (ValuePast == "") { ValuePast = "0"; }
            double first_num = Double.Parse(Value);
            double second_num = Double.Parse(ValuePast);
            double result = Math.Pow(first_num, second_num);
            string return_string = result.ToString();
            return return_string;
        }
    }
}

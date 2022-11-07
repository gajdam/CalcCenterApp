using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CalcCenterApp
{
    public partial class SimpleCalcWindow : Window
    {
        double firstNumber = 0, secondNumber = 0;
        string firstNumberStr = "", secondNumberStr = "", previousEquation="";
        string operation = "";
        bool firstNumberStrNoMoreSpace = false, secondNumberStrNoMoreSpace = false;
        bool hasUsedDotForDecimal = false;
        public SimpleCalcWindow()
        {
            InitializeComponent();
        }

        private void DecimalButtonClick(object sender, RoutedEventArgs e)
        {
            if (TextDisplay.Text == "0" && operation == "")
            {
                firstNumberStr += "0,";
                hasUsedDotForDecimal = true;
                TextDisplay.Text = firstNumberStr;
            }
            else if (TextDisplay.Text == "0" && operation != "")
            {
                secondNumberStr += "0,";
                hasUsedDotForDecimal = true;
                TextDisplay.Text = secondNumberStr;
            }
            else if (operation == "" && firstNumberStr.Length <= 9 && hasUsedDotForDecimal == false)
            {
                firstNumberStr += ',';
                hasUsedDotForDecimal = true;
                TextDisplay.Text = firstNumberStr;
            }
            else if (operation != "" && secondNumberStr.Length <= 9 && hasUsedDotForDecimal == false)
            {
                secondNumberStr += ',';
                hasUsedDotForDecimal = true;
                TextDisplay.Text = secondNumberStr;
            }
        }

        private void NegPosButtonClick(object sender, RoutedEventArgs e)
        {
            if(firstNumberStr != "" && operation == "" && firstNumberStr[0] == '-')
            {
                firstNumberStr = firstNumberStr.Substring(1);
                TextDisplay.Text = firstNumberStr;
            }
            else if(secondNumberStr != "" && operation != "" && secondNumberStr[0] == '-')
            {
                secondNumberStr = secondNumberStr.Substring(1);
                TextDisplay.Text = secondNumberStr;
            }
            else if(firstNumberStr != "" && operation == "" && firstNumberStr[0] != '-')
            {
                firstNumberStr = "-" + firstNumberStr;
                TextDisplay.Text = firstNumberStr;
            }
            else if (secondNumberStr != "" && operation != "" && secondNumberStr[0] != '-')
            {
                secondNumberStr = "-" + secondNumberStr;
                TextDisplay.Text = secondNumberStr;
            }
        }

        private void PlusButtonClick(object sender, RoutedEventArgs e)
        {
            operation = "+";
            TextDisplay.Text = "0";
            hasUsedDotForDecimal = false;
            BackTextDisplay.Text = firstNumberStr + " " + operation;
        }

        private void MinusButtonClick(object sender, RoutedEventArgs e)
        {
            operation = "-";
            TextDisplay.Text = "0";
            hasUsedDotForDecimal = false;
            BackTextDisplay.Text = firstNumberStr + " " + operation;
        }

        private void MultiplyButtonClick(object sender, RoutedEventArgs e)
        {
            operation = "*";
            TextDisplay.Text = "0";
            hasUsedDotForDecimal = false;
            BackTextDisplay.Text = firstNumberStr + " " + operation;
        }

        private void DivideButtonClick(object sender, RoutedEventArgs e)
        {
            operation = "/";
            TextDisplay.Text = "0";
            hasUsedDotForDecimal = false;
            BackTextDisplay.Text = firstNumberStr + " " + operation;
        }

        private void ModuloButtonClick(object sender, RoutedEventArgs e)
        {
            operation = "%";
            TextDisplay.Text = "0";
            hasUsedDotForDecimal=false;
            BackTextDisplay.Text = firstNumberStr + " " + operation;
        }

        private void EqualsButtonClick(object sender, RoutedEventArgs e)
        {
            if(firstNumberStr != "" && operation != "" && secondNumberStr != "")
            {
                firstNumber = double.Parse(firstNumberStr);
                secondNumber = double.Parse(secondNumberStr);
                switch (operation)
                {
                    case "+":
                        TextDisplay.Text = (firstNumber + secondNumber).ToString();
                        break;

                    case "-":
                        TextDisplay.Text = (firstNumber - secondNumber).ToString();
                        break;

                    case "*":
                        TextDisplay.Text = (firstNumber * secondNumber).ToString();
                        break;

                    case "/":
                        TextDisplay.Text = (firstNumber / secondNumber).ToString();
                        break;

                    case "%":
                        TextDisplay.Text = (firstNumber % secondNumber).ToString();
                        break;
                }
                BackTextDisplay.Text = BackTextDisplay.Text + " " + secondNumberStr + " =";
                firstNumberStr = "";
                secondNumberStr = "";
                operation = "";
                hasUsedDotForDecimal = false;
                previousEquation = TextDisplay.Text;
            }
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            TextDisplay.Text = "0";
            BackTextDisplay.Text = "";
            previousEquation = "";
            firstNumberStr = "";
            secondNumberStr = "";
            operation = "";
            hasUsedDotForDecimal = false;
        }

        private void ClearEquationButtonClick(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumberStr = "";
                TextDisplay.Text = "0";
            }
            else
            {
                secondNumberStr = "";
                TextDisplay.Text = "0";
            }   
        }

        private void TextDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(firstNumberStr.Length == 11)
                firstNumberStrNoMoreSpace = true;
            else
                firstNumberStrNoMoreSpace = false;
            if(secondNumberStr.Length == 11)
                secondNumberStrNoMoreSpace = true;
            else
                secondNumberStrNoMoreSpace = false;
            if(previousEquation != "" && operation == "")
            {
                BackTextDisplay.Text = previousEquation;
            }
        }

        private void DigitButtonClick(object sender, RoutedEventArgs e)
        {
            Button digitButton = (Button)sender;
            if(operation == "" && !firstNumberStrNoMoreSpace)
            {
                firstNumberStr += digitButton.Content;
                TextDisplay.Text = firstNumberStr;
            }
            else if(operation != "" && !secondNumberStrNoMoreSpace)
            {
                secondNumberStr += digitButton.Content;
                TextDisplay.Text = secondNumberStr;
            }
        }

        private void ZeroButtonClick(object sender, RoutedEventArgs e)
        {
            Button digitButton = (Button)sender;
            if (operation == "" && firstNumberStr != "" && !secondNumberStrNoMoreSpace)
            {
                firstNumberStr += digitButton.Content;
                TextDisplay.Text = firstNumberStr;
            }
            else if (operation != "" && secondNumberStr != "" && !secondNumberStrNoMoreSpace)
            {
                secondNumberStr += digitButton.Content;
                TextDisplay.Text = secondNumberStr;
            }
        }
    }
}

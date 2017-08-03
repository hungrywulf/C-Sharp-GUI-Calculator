using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1 = 0;
        double number2 = 0;
        string operation = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string buttonText = button.Name.ToString();

            // Calls different buttons based on the button's name
            switch (buttonText)
            {
                // Digits
                case "Zero":
                    if (operation == null)
                    {
                        number1 = (number1 * 10);
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 * 10);
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "One":
                    if (operation == null)
                    {
                        number1 = (number1 * 10) + 1;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 * 10) + 1;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Two":
                    if (operation == null)
                    {
                        number1 = (number1 * 10) + 2;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 * 10) + 2;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Three":
                    if (operation == null)
                    {
                        number1 = (number1 * 10) + 3;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 * 10) + 3;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Four":
                    if (operation == null)
                    {
                        number1 = (number1 * 10) + 4;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 * 10) + 4;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Five":
                    if (operation == null)
                    {
                        number1 = (number1 * 10) + 5;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 * 10) + 5;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Six":
                    if (operation == null)
                    {
                        number1 = (number1 * 10) + 6;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 * 10) + 6;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Seven":
                    if (operation == null)
                    {
                        number1 = (number1 * 10) + 7;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 * 10) + 7;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Eight":
                    if (operation == null)
                    {
                        number1 = (number1 * 10) + 8;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 * 10) + 8;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Nine":
                    if (operation == null)
                    {
                        number1 = (number1 * 10) + 9;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 * 10) + 9;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;

                // Functions
                case "ClearEdit":
                    if (operation == null)
                    {
                        number1 = 0;
                    }
                    else
                    {
                        number2 = 0;
                    }
                    TextDisplay.Text = "0";
                    break;
                case "Clear":
                    number1 = 0;
                    number2 = 0;
                    operation = null;
                    TextDisplay.Text = "0";
                    break;
                case "Delete":
                    if (operation == null)
                    {
                        number1 = (number1 / 10);
                        number1 = Math.Truncate(number1);
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = (number2 / 10);
                        number2 = Math.Truncate(number2);
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Negate":
                    if (operation == null)
                    {
                        number1 *= -1;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 *= -1;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Sqrt":
                    if (operation == null)
                    {
                        number1 = Math.Sqrt(number1);
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = Math.Sqrt(number2);
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Power":
                    if (operation == null)
                    {
                        number1 = Math.Pow(number1, 2);
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = Math.Pow(number2, 2);
                        TextDisplay.Text = number2.ToString();
                    }
                    break;
                case "Decimal":
                    if (operation == null)
                    {
                        number1 = number1 / 10;
                        TextDisplay.Text = number1.ToString();
                    }
                    else
                    {
                        number2 = number2 / 10;
                        TextDisplay.Text = number2.ToString();
                    }
                    break;

                // Operations
                case "Plus":
                    operation = "+";
                    TextDisplay.Text = "0";
                    break;
                case "Minus":
                    operation = "-";
                    TextDisplay.Text = "0";
                    break;
                case "Times":
                    operation = "*";
                    TextDisplay.Text = "0";
                    break;
                case "Divide":
                    operation = "/";
                    TextDisplay.Text = "0";
                    break;
                case "PowerToN":
                    operation = "^";
                    TextDisplay.Text = "0";
                    break;
                case "Equals":
                    {
                        switch (operation)
                        {
                            case "+":
                                TextDisplay.Text = (number1 + number2).ToString();
                                break;
                            case "-":
                                TextDisplay.Text = (number1 - number2).ToString();
                                break;
                            case "*":
                                TextDisplay.Text = (number1 * number2).ToString();
                                break;
                            case "/":
                                TextDisplay.Text = (number1 / number2).ToString();
                                break;
                            case "^":
                                TextDisplay.Text = Math.Pow(number1, number2).ToString();
                                break;
                        }
                        number1 = 0;
                        number2 = 0;
                        operation = null;
                    }
                    break;
            }
        }
    }
}

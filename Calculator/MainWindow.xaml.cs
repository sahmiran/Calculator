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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        double number3 = 0;
        long result = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                ciktiEkrani.Text = number2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                ciktiEkrani.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                ciktiEkrani.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                ciktiEkrani.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                ciktiEkrani.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                ciktiEkrani.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                ciktiEkrani.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                ciktiEkrani.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                ciktiEkrani.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                ciktiEkrani.Text = number2.ToString();
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            ciktiEkrani.Text = "0";
        }

        private void YuzdeBtn_Click(object sender, RoutedEventArgs e)
        {
            number3 = Convert.ToDouble(number1);
            number3 /= 100;
            ciktiEkrani.Text = number3.ToString();
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            ciktiEkrani.Text = "0";
            if (!(result == 0))
            {
                number1 = result;
                result = 0;
            }
        }

        private void MultplyBtn_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            ciktiEkrani.Text = "0";
            if (!(result == 0))
            {
                number1 = result;
                result = 0;
            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            ciktiEkrani.Text = "0";
            if (!(result == 0))
            {
                number1 = result;
                result = 0;
            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            ciktiEkrani.Text = "0";
            if (!(result == 0))
            {
                number1 = result;
                result = 0;
            }
        }

        private void EquelBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    ciktiEkrani.Text = (number1 + number2).ToString();
                    result = number1+number2;
                    number2 = 0;
                    operation = "";
                    break;

                case "-":
                    ciktiEkrani.Text = (number1 - number2).ToString();
                    result = number1 - number2;
                    number2 = 0;
                    operation = "";
                    break;

                case "*":
                    ciktiEkrani.Text = (number1 * number2).ToString();
                    result = number1 * number2;
                    number2 = 0;
                    operation = "";
                    break;

                case "/":
                    if (number2 != 0)
                    {
                        ciktiEkrani.Text = (number1 / number2).ToString();
                        result = number1 / number2;
                        number2 = 0;
                        operation = "";
                    }
                    else ciktiEkrani.Text = "Sifira bölmeye çalıştınız";
                    break;
            }
                
        }

        private void PlusMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            number1 *= -1;
            ciktiEkrani.Text= number1.ToString();
        }

        private void BackspaceBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                ciktiEkrani.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                ciktiEkrani.Text = number2.ToString();
            }
        }
    }
}

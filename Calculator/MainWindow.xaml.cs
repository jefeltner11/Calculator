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
        Calculations calculator = new Calculations();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = calculator;
        }

        private void modulus_Click(object sender, RoutedEventArgs e)
        {
            calculator.StoreTemp();
            calculator.Operator = "%";
        }


        private void clearEntry_Click(object sender, RoutedEventArgs e)
        {
            calculator.Display = 0;
        }

        private void clearAll_Click(object sender, RoutedEventArgs e)
        {
            calculator.Display = 0;
            calculator.Temporary = 0;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            calculator.Concatenate(7);
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            calculator.Concatenate(8);
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            calculator.Concatenate(9);
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            calculator.Concatenate(4);
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            calculator.Concatenate(5);
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            calculator.Concatenate(6);
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            calculator.Concatenate(1);
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            calculator.Concatenate(2);
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            calculator.Concatenate(3);
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            calculator.Concatenate(0);
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            calculator.Equals();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            calculator.StoreTemp();
            calculator.Operator = "+";
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            calculator.StoreTemp();
            calculator.Operator = "-";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            calculator.StoreTemp();
            calculator.Operator = "/";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            calculator.StoreTemp();
            calculator.Operator = "*";
        }

        private void backspace_Click(object sender, RoutedEventArgs e)
        {
            double remainder;
            remainder = calculator.Display % 10;
            calculator.Display -= remainder;
            calculator.Display /= 10;
        }

        private void decimal_Click(object sender, RoutedEventArgs e)
        {
            calculator.Display = double.Parse(calculator.Display.ToString() + ".");
        }

        private void positiveNegative_Click(object sender, RoutedEventArgs e)
        {
            calculator.Display *= -1;
        }

        private void oneOver_Click(object sender, RoutedEventArgs e)
        {
            calculator.Display = 1 / calculator.Display;
        }

        private void squared_Click(object sender, RoutedEventArgs e)
        {
            calculator.Display *= calculator.Display;
        }

        private void squareRoot_Click(object sender, RoutedEventArgs e)
        {
            calculator.Display = Math.Sqrt(calculator.Display);
        }
    }
}

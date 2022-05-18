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
        Calculator calculator = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = calculator;
        }

        private void modulus_Click(object sender, RoutedEventArgs e)
        {

        }


        private void clearEntry_Click(object sender, RoutedEventArgs e)
        {

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


    }
}

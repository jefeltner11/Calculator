using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator
{
    public class Calculations : INotifyPropertyChanged
    {

        private double _display = 0;
        private double _temporary = 0;
        private string _operator = "";
        public double Display
        {
            get { return _display; }
            set
            {
                _display = value;
                OnPropertyChanged("Display");
            }
        }

        public double Temporary
        {
            get { return _temporary; }
            set
            {
                _temporary = value;
                OnPropertyChanged("Temporary");
            }
        }

        public string Operator
        {
            get { return _operator; }
            set
            {
                _operator = value;
            }
        }

        public void Concatenate(double lastDigit)
        {
            Display = double.Parse(Display.ToString() + lastDigit.ToString()); 
        }

        public void StoreTemp()
        {
            Temporary = Display;
            Display = 0;
        }

        public void Equals()
        {
            switch (Operator)
            {
                case "%":
                    Display %= Temporary;
                    break;
                case "+":
                    Display += Temporary;
                    break;
                case "-":
                    Display = Temporary - Display;
                    break;
                case "*":
                    Display *= Temporary;
                    break;
                case "/":
                    Display = Temporary/Display;
                    break;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}

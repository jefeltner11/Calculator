using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator
{
    public class Calculator : INotifyPropertyChanged
    {

        private int _display = 0;
        private int _temporary = 0;
        private string _operator = "";
        public int Display
        {
            get { return _display; }
            set
            {
                _display = value;
                OnPropertyChanged("Display");
            }
        }

        public int Temporary
        {
            get { return _temporary; }
            set
            {
                _temporary = value;
                OnPropertyChanged("Display");
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

        public void Concatenate(int lastDigit)
        {
            Display = int.Parse(Display.ToString() + lastDigit.ToString());
        }

        public void StoreTemp()
        {
            Temporary = Display;
        }

        public void Modulus()
        {
            StoreTemp();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}

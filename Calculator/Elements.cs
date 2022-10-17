using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


namespace Calculator
{
 
    public enum Operation
    {
        plus, minus, divide, multiply
    }
    internal class Elements : INotifyPropertyChanged
    {
        
        private double element1;
        private double element2;
        private Operation operation;

        public double Element1
        {
            get => element1;
            set
            {
                element1 = value;
                if (PropertyChanged != null) { 
                    PropertyChanged(this, new PropertyChangedEventArgs("Element1")); 
                    PropertyChanged(this, new PropertyChangedEventArgs("Result"));
                }
            }
        }
        public double Element2 { get => element2; set { element2 = value; if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs("Element2")); PropertyChanged(this, new PropertyChangedEventArgs("Result")); } } }
        public Operation Operation { get => operation; set { operation = value; if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs("Operation")); PropertyChanged(this, new PropertyChangedEventArgs("Result")); } } }
        public double Result
        {
            get
            {
                switch (this.Operation)
                {
                    case Operation.plus: return Element1 + Element2;
                    case Operation.minus: return Element1 - Element2;
                    case Operation.divide: return Element1 / Element2;
                    case Operation.multiply: return Element1 * Element2;
                    default: return double.NaN;


                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

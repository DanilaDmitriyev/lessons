using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            elementsBindingSource.DataSource = new Elements();
            actionBox.DataSource = Enum.GetValues(typeof(Operation));
        }

        private void actionBox_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value is Operation)
            {
                switch((Operation)e.Value)
                {
                    case Operation.plus: e.Value = "+";
                        break;
                        case Operation.minus: e.Value = "-";
                        break;
                        case Operation.multiply: e.Value = "*";
                        break;
                        case Operation.divide: e.Value = "/";
                        break;
                                        }
            }
        }
    }
}

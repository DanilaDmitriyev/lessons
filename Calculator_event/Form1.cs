using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            operation.SelectedItem = "+";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double fig1_val = Double.Parse(fig1.Text);
            double fig2_val = Double.Parse(fig2.Text);
            switch (operation.Text[0])
            {
                case '+': result.Text = (fig1_val+fig2_val).ToString(); break; 
                    case '-': result.Text = (fig1_val-fig2_val).ToString(); break;
                case '/': result.Text = (fig1_val/fig2_val).ToString(); break;
                case '*': result.Text = (fig1_val*fig2_val).ToString(); break;  
            }
        }

        private void fig1_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !double.TryParse(fig1.Text, out double _);
        }
    }
}

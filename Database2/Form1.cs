using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double data1, data2;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            data2 = Double.Parse(dataBox2.Text);
            resultBox.Text = (data1 * data2).ToString();
        }
                

        private void dataBox1_TextChanged(object sender, EventArgs e)
        {
            data1 = Double.Parse(dataBox1.Text);
            resultBox.Text = (data1 * data2).ToString();
        }
    }
}

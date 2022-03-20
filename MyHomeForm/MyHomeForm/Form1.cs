using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyHomeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void calcButton_Click(object sender, EventArgs e)
        {
            int x = int.Parse(priceBox.Text);
            int y = int.Parse(vatBox.Text);
            float z = (x / (100 + y)) * y;
            string zz = z.ToString();
            //resultBox.Text.Insert(0, zz);
            //resultBox.Paste(zz);
          
            

        }
        



    }
}

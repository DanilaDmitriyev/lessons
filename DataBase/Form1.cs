using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double tb1, tb2;
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try{
                tb2 = Double.Parse(textBox2.Text);
                result.Text = (tb2 + tb1).ToString();
            }
            catch { result.Text = "Ошибка формата"; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //tb1 = Double.Parse(((TextBox)sender).Text);
            
            try{
                tb1 = Double.Parse(textBox1.Text);
                result.Text = (tb1 + tb2).ToString();
            }
            catch {}
        }
    

    }
}

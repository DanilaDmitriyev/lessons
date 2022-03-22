using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



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
            float x = float.Parse(priceBox.Text);
            int y = int.Parse(vatBox.Text);
            float z = (x / (100f + y)) * y;
            string zz = z.ToString();
            resultBox.Text = zz;
            //resultBox.Paste(zz);
         

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog=new SaveFileDialog())
            {
                //фильтр для saveFileDialog
                saveFileDialog.Filter = "txt file|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                    File.WriteAllText(saveFileDialog.FileName, resultBox.Text);            
                        
            }
            
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Txt file|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    
                priceBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
    }
}

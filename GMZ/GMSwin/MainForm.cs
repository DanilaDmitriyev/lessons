using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMSwin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ItemComponents_Click(object sender, EventArgs e)
        {
            ComponentsForm componentsForm = this.MdiChildren.OfType<ComponentsForm>().FirstOrDefault();
            if (componentsForm == null)
            {
                componentsForm = new ComponentsForm();
                componentsForm.MdiParent = this;
                componentsForm.Show();
            }
            else componentsForm.Activate();
        }
    }
}

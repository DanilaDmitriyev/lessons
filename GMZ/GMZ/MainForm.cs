using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMZ
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

        private void m_cmd_product_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = this.MdiChildren.OfType<ProductsForm>().FirstOrDefault();
            if (productsForm == null)
            {
                productsForm = new ProductsForm();
                productsForm.MdiParent = this;
                productsForm.Show();
            }
            else productsForm.Activate();
        }
    }
}

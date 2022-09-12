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
    public partial class ProductsForm : Form
    {
        
        private DataRepository dataRepository = DataRepository.GetRepository();
        public ProductsForm()
        {
            InitializeComponent();
            productBindingSource.DataSource = new BindingList<Product>(dataRepository.Products);
            dimensionBox.DataSource = Enum.GetValues(typeof(Dimension));
        }

        private void dimensionBox_Format(object sender, ListControlConvertEventArgs e)
        {
            switch ((Dimension)e.ListItem)
            {
                case Dimension.Kg: e.Value = "Кг"; break;
                case Dimension.gr: e.Value = "гр"; break;
                case Dimension.L: e.Value = "Литр"; break;
                case Dimension.item: e.Value = "Шт."; break;


            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            DataRepository.SaveData(dataRepository);
        }

        private void productBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            tableLayoutPanel1.Enabled = productBindingSource.Count > 0;
        }
    }
}

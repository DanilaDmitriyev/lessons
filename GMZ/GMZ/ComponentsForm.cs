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
    public partial class ComponentsForm : Form
    {
        public ComponentsForm()
        {
            InitializeComponent();
            dataComponentBindingSource.DataSource = new BindingList<DataComponent>(dataRepository.Components);
            dimensionBox.DataSource = Enum.GetValues(typeof(Dimension));
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            DataRepository.SaveData(dataRepository);
        }

        private DataRepository dataRepository = DataRepository.GetRepository();
       

        
        private void dataComponentBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            tableLayoutPanel1.Enabled = dataComponentBindingSource.Count > 0;
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
    }
}

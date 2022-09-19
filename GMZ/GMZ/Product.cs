using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


namespace GMZ
{
    public class Product : INotifyPropertyChanged
    {
        public String Article { get; set; }
        public String Name { get; set; } = "Продукт";
        public Dimension Dimension { get; set; }
        private decimal directCosts;
        private decimal indirectCosts;
        private decimal extraCharge;

        public event PropertyChangedEventHandler PropertyChanged;

        public Product()
        {
            this.ProductComponents.ListChanged += (o, e) => 
            {
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Price"));
            };
        }

        public decimal DirectCosts
        {
            get { return directCosts; }
            set { directCosts = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DirectCosts"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Price"));
                }
            }
        }    
        public decimal IndirectCosts
        {
            get { return indirectCosts; }
            set { indirectCosts = value;
                if (PropertyChanged != null)
                { 
                    PropertyChanged(this, new PropertyChangedEventArgs("IndirectCosts"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Price"));
                }
            }
        }
        public decimal ExtraCharge
        {
            get { return extraCharge; }
            set { extraCharge = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ExtraCharge"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Price"));
                }
            }
        }
        public string [] Annotation { get; set; }
        public BindingList<ProductComponent> ProductComponents { get; } = new BindingList<ProductComponent>();

        public decimal Price
        {
            get { return (ProductComponents.Sum(x => 
            DataRepository.GetRepository().Components.Where(y =>
            y.Article == x.ComponentArticle).Select(y => y.Price).FirstOrDefault() * 
            x.ComponentQuantity)+DirectCosts + IndirectCosts)*(1+ExtraCharge/100); }
        }
    }

    public class ProductComponent : INotifyPropertyChanged
    {
        private string componentArticle;
        private decimal componentQuantity;
        public String ComponentArticle 
        {
            get { return componentArticle; }
            set { componentArticle = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("ComponentArticle"));
            }
            
        }
        public decimal ComponentQuantity
        {
            get { return componentQuantity; }
            set { componentQuantity = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("ComponentQuantity"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

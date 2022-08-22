using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMZ
{
    public class Product
    {
        public String Article { get; set; }
        public String Name { get; set; } = "Продукт";
        public Dimension Dimension { get; set; }
        public decimal DirectCosts { get; set; }
        public decimal IndirectCosts { get; set; }
        public decimal ExtraCharge { get; set; }
        public string[] Annotation { get; set; }
    }

    public class ProductComponent
    {
        public String ComponentArticle { get; set; }
        public float ComponentQuantity { get; set; }
    }
}

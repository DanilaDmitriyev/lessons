using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMZ
{
    public enum Dimension
    {
        Kg,
        T,
        gr,
        L,
        item
    }
    public class DataComponent
    {
        public string Name { get; set; } = "Компонент";
        public string Article { get; set; }
        public decimal Price { get; set; }
        public Dimension Dimension { get; set; }
        public string [] Annotation { get; set; }
    }
}

using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MyHouse
{
    class Material
    {
        private float size, weight;
        private string material, color;
        public float Size
        {
            get { return size; }
            set { size = value; }
        }
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string MaterialType
        {
            get { return material; }
            set { material = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Material[] materials = new Material[]
            {
                new Material
                {
                    Size = 1000,
                    Weight = 100,
                    Color = "Red",
                    MaterialType = "Wood"
                    
                },

                new Material
                {
                    Size = 2000,
                    Weight = 20,
                    Color = "Black",
                    MaterialType = "Metal"

                },
                 new Material
                 {
                    Size = 50,
                    Weight = 20,
                    Color = "Blue",
                    MaterialType = "Metal"

                },

                new Material
                {
                    Size = 2000,
                    Weight = 60,
                    Color = "Black",
                    MaterialType = "Metal"
                }

            };

            materials.Where(m => m.Color == "red");
            materials.OrderByDescending(m => m.Weight).First();
            materials.All(m => m.Weight <= 40);
            materials.Any(m => m.Weight > 40);
            materials.GroupBy(m => m.MaterialType).Count();
            materials.GroupBy(m => m.MaterialType);
        }
    }
}
 
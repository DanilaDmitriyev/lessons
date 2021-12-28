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
        public override string ToString()
        {
            return $"size {size} weight {weight} MaterialType {MaterialType}  color {color}";
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
                    Color = "Red",
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

            foreach (Material x in materials.Where(m => m.Color == "Red")) Console.WriteLine(x);
            materials.OrderByDescending(m => m.Weight).First();
            materials.All(m => m.Weight <= 40);
            materials.Any(m => m.Weight > 40);
            Console.WriteLine(materials.GroupBy(m => m.MaterialType).Count());
            foreach (var x in materials.GroupBy(m => m.MaterialType).Select(g => new {Quantity= g.Count(), material_type = g.Key })) Console.WriteLine(x);
            foreach (Material x in (from e in materials where e.Color =="Red" select e)) Console.WriteLine(x);
            (from e in materials orderby e.Weight descending select e).First();
            Console.ReadKey();

        }
    }

}


/*Entity[] array = GetAllEntities();

var ids = (from e in array
           where e.Category == "Shoes"
           orderby e.Price
           select e.ID).ToList();*/


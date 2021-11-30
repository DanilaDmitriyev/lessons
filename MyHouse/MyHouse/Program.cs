using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Material[] materials = new Material [0];
            materials.Where(m => m.Color == "red");
            materials.OrderByDescending(m => m.Weight).First();
        }
    }
}

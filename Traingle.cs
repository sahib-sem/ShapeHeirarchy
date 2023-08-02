using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHeirarchy
{
    internal class Traingle : IShape
    {

        public double T_base;
        public double Height;
        private string _name;

        public Traingle(string name , double t_base , double height)
        {
            Name = name;
            Height = height;
            T_base = t_base;
        }
        public string Name { get => _name; set => _name = value; }

        public double CalculateArea()
        {
            return 0.5 * Height * T_base;
        }
    }
}

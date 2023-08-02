using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHeirarchy
{
    internal class Rectangle : IShape
    {

        private string _name;
        public double Width;
        public double Height;

        public string Name { 
            get { return _name; }
            set { _name = value; }
        
        }

        public Rectangle(string name, double width , double height)
        {
            Name = name;
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}

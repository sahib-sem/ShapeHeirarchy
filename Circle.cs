using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHeirarchy
{
    internal class Circle : IShape

    {
        private string _name;
        public double _radius;

        public string Name{
            get
            {
                return _name;
            }
            set { _name =  value; }

            }
        public Circle(string name , double raduis) {
            
            Name = name;
            _radius = raduis;
        }
        public double CalculateArea()
        {
            return Math.PI *  _radius * _radius;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleExample
{
    class InheritedClassOfRectangle : Rectangle
    {
        public double cost;
        public InheritedClassOfRectangle(double l, double w): base(l, w)
        {
        }
        public double costcal()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", costcal());
        }
    }
    
}

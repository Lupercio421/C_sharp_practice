using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Shape
{
    class RegularPolygon
    {
        public void calculatePerimeter(int length, int sides)
        {

            int result = length * sides;
            Console.WriteLine("Perimeter: " + result);
        }
    }

    class Square : RegularPolygon
    {
        public int length = 200;
        public int sides = 4;
        public void calculateArea()
        {

            int area = length * length;
            Console.WriteLine("Area of Square: " + area);
        }
    }
    class Rectangle : RegularPolygon
    {

        public int length = 100;
        public int breadth = 200;
        public int sides = 4;

        public void calculateArea()
        {

            int area = length * breadth;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFDesign
{
    //LSP states that the child class should be perfectly substitutable for their parent class. If class C is derived from P then C should be substitutable for P.
    
    public abstract class Shape
    {
        public abstract string GetShape();
    }
    public class Triangle : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }
    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}

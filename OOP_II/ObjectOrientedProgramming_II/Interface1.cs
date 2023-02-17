using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface
{
    //unlike abstract classes, all methods of an interface are fully abstract (method without body)
    internal interface Interface1
    {
        //all members of an interface are public by default
        //an interface doesn't allow fields
    }
    interface IPolygon
    {
        //method without body
        //hides the implementation details of the method
        //This is like setting a rule that we should calculate the area of every polygon.
        void calculateArea();
    }
    interface IColor
    {
        void getColor();
    }
    //class Rectangle : IPolygon, IColor
    //{
    //    //implementation of methods inside interface
    //    //Implementation of IPolygon interface
    //    public void calculateArea(int l, int b) 
    //    {
    //        int area = l * b;
    //        Console.WriteLine("Area of Rectangle: " + area);
    //    }
    //    public void getColor() 
    //    {
    //        Console.WriteLine("Green Rectangle");
    //    }
    //}

    //implements interface
    //Now any class that implements the IPolygon interface must provide an implementation for the calculateArea() method.
    class Rectangle : IPolygon 
    {
        //implementation of IPolygon interface
        public void calculateArea() 
        {
            int l = 30;
            int b = 90;
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
    class Square : IPolygon
    {
        public void calculateArea() 
        { 
            int l = 30;
            int area = l * l;
            Console.WriteLine("Area of Square: " + area);
        }
    }

}

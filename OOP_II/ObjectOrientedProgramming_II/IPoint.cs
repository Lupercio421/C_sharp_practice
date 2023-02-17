using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface
namespace ObjectOrientedProgramming_II
{
    internal interface IPoint
    {
        int X { get; set; }
        int Y { get; set; }
        double Distance { get; }
    }
    class Point : IPoint
    {
        //Constructor:
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        //Property implementation:
        public int X { get; set; }
        public int Y { get; set; }
        //Property implementations
        public double Distance =>
            Math.Sqrt(X * X + Y * Y);
    }
    class MainClass
    {
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y = {1}", p.X, p.Y);
        }
        //static void 
        //{
        //    IPoint p = new Point(2,3);
        //    Console.Write("My Point: ");
        //    PrintPoint(p);
        //}
    }
}

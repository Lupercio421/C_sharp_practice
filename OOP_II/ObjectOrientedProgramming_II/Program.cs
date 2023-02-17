// See https://aka.ms/new-console-template for more information
using Inheritance_Lesson;
using Inheritance_Shape;
using CSharpInterface;

namespace MainProgram
{
    class Program
    {
        //static void Main(string[] args) 
        //{
        //    //object of derived class
        //    Dog labrador = new Dog();

        //    //acces field and method of base class
        //    labrador.name = "Goku";
        //    labrador.display();
        //    //This is possible because the derived class inherits all fields and methods of the base class.

        //    //access method from own class
        //    labrador.getName();
        //    Console.ReadLine();
        //}

        //static void Main(string[] args) 
        //{
        //    //object of derived class
        //    Dog labrador = new Dog();

        //    //access overriden method
        //    labrador.eat();
        //}

        //static void Main(string[] args)
        //{

        //    Square s1 = new Square();
        //    s1.calculateArea();
        //    s1.calculatePerimeter(s1.length, s1.sides);


        //    Rectangle t1 = new Rectangle();
        //    t1.calculateArea();
        //    t1.calculatePerimeter(t1.length, t1.sides);
        //}
        //static void Main(string[] args) 
        //{
        //    CSharpInterface.Rectangle r1 = new CSharpInterface.Rectangle();
        //    r1.calculateArea(100,200);
        //    r1.getColor();
        //}
        static void Main(string[] args) 
        {
            CSharpInterface.Rectangle r1 = new CSharpInterface.Rectangle();
            r1.calculateArea();

            CSharpInterface.Square s1 = new CSharpInterface.Square();
            s1.calculateArea();
        }
    }
}
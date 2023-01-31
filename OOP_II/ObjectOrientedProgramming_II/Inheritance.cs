using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Inheritance_Lesson
{
    //public class Animal
    //{
    //    public string name;
    //    public void display()
    //    {
    //        Console.WriteLine("I am an animal");
    //    }

    //}
    ////derived class of Animal
    //class Dog : Animal 
    //{
    //    public void getName() 
    //    {
    //        Console.WriteLine("My name is " + name);
    //    }
    //}

    //when we declare a field or method as protected, it can only be accessed from the same class and its derived classes
    //class Animal
    //{
    //    protected void eat()
    //    {
    //        Console.WriteLine("I can eat");
    //    }
    //}
    //class Dog : Animal
    //{
    //    static void Main(string[] args)
    //    {
    //        Dog labrador = new Dog();
    //        labrador.eat();
    //        //Since the protected method can be accessed from derived classes, we are able to access the eat() method from the Dog class.
    //        Console.ReadLine();
    //    }
    //}
    
    //base class
    class Animal 
    {
        public virtual void eat() 
        {
            Console.WriteLine("I eat food");
        }
    }

    //derived class of Animal
    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("I eat dog food");
        }
    }
}

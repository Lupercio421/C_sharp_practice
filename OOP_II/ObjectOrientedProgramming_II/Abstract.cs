using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_II
{
    //The abstract keyword enables you to create classes
    //and class members that are incomplete and must be implemented in a derived class

    //We can use abstract class only as a base class. This is why abstract classes cannot be sealed.
    abstract class Language
    {
        public void display()
        {
            Console.WriteLine("Non abstract method");
        }
    }
    abstract class Animal
    {
        //A protected member is accessible within its class and by derived class instances.
        protected string name;

        public abstract string Name
        {
            get;
            set;
        }

    }
    class Dog : Animal
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set 
            { 
                name = value;
            }
        }
    }
}

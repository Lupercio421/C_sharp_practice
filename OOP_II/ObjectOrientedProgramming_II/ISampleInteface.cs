using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_II
{
    internal interface ISampleInterface
    {
        void SampleMethod();
    }
    class ImplementationClass : ISampleInterface
    {
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("How does this work?");
        }
        static void Main()
        {
            //Declare an interface instance.
            ISampleInterface obj = new ImplementationClass();
            //Call the member
            obj.SampleMethod();
        }
    }
}

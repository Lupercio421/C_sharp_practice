using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_II
{
    internal class Partial
    {
        //The partial keyword specify that other parts of the class can be defined in the namespace.
        //It is mandatory to use the partial keyword if we are trying to make a class partial
        //All parts of a partial class should be in the same namespace.
        //Things to remember about Partial Method
        //partial keyword.
        //return type void.
        //implicitly private.
        //and cannot be virtual.
    }

    internal class Sealed
    {
        //We use sealed classes to prevent inheritance. As we cannot inherit from a sealed class,
        //the methods in the sealed class cannot be manipulated from other classes.

        //One of the best uses of sealed classes is when you have a class with static members.

    }
}

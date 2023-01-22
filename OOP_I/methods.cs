// using System;

// namespace Method {
//     class Program {
//         // method declaration
//         public void display() {
//             Console.WriteLine("Hello World");
//         }

//         static void Main(string[] args) {

//             // create class object
//             Program p1 = new Program();

//             // call method
//             p1.display();

//             Console.ReadLine();
//         }

//     }
// }

// A C# method may or may not return a value. If the method doesn't return any value, we use the void keyword.

// using System;

// namespace Method {
//     class Program{
//         // method declaration

//         static int addNumbers() {
//             int sum = 5+12;
//             return sum;
//         }

//         static void Main(string[] args) {
//             // call method
//             int sum = addNumbers();

//             Console.WriteLine(sum);
//             Console.ReadLine();
        
//         }
//     }
// }

// using System;

// namespace Method {
//     class Program {
//         int addNumber (int a, int b) {
//             int sum1 = a + b;

//             return sum1;
//         }

//         static void Main(string[] args) {

//             // create class object
//             Program p1 = new Program();

//             //call method
//             int sum = p1.addNumber(100,100);

//             Console.WriteLine("Sum: " + sum);

//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace Method {
//     class Program{
//         string work(string work) {
//             return work;
//         }

//         static void Main(string[] args) {

//             // create class object
//             Program p1 = new Program();

//             // call method
//             string work = p1.work("Cleaning");

//             Console.WriteLine("Work: "+ work);

//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace Method {
//     class Program {
//         static void Main(string[] args) {

//             //Built in method
//             double a = Math.Sqrt(9);
//             Console.WriteLine("Square root of 9: " + a);
//         }

//     }
// }

// Method Overloading in C#

using System;

namespace MethodOverload {
    class Program {

        // method with one parameter

        void display(int a) {
            Console.WriteLine("Arguments: " + a);
        }

        // method with two parameters
        void display(int a, int b) {
            Console.WriteLine("Arguments: " + a + " and " + b);
        }
        static void Main(string[] args) {

            Program p1 = new Program();
            p1.display(100,200);
            p1.display(100);
            Console.ReadLine();
        }
    }
}
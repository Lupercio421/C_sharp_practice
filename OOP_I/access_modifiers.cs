// In C# there are 4 basic types of acces modifiers: public, private, protected and internal

// When we declare a type or type member public, it can be accessed from anywhere. For example

// using System;
// namespace MyApplication {
//     class Student {
//         //creating the field
//         public string name = "Sheeran";

//         // public print method
//         public void print() {
//             Console.WriteLine("Hello from Student Class");
//         }
//     }

//     class Program {
//         static void Main(string[] args) {

//             // creating object of Student class

//             Student student1 = new Student();

//             // accessing name field and printing it
//             Console.WriteLine("Name: " + student1.name);

//             // accessing print method from Student
//             student1.print();
//             Console.ReadLine();
//         }
//     }
// }

// private access modifier

// a private access modifier can only be accessed within the same class or struct
// using System;

// namespace MyApplication {

//     class Student {
//         private string name = "Sheeran";

//         private void print() {
//             Console.WriteLine("Hello");
//         }
//     }

//     class Program {
//         static void Main(string[] args) {

//             // creating object of Student class
//             Student student1 = new Student();   

//             // accessing name field and printing it
//             Console.WriteLine("Name: "+ student1.name);

//             // accessing print method from Student
//             student1.print();

//             Console.ReadLine();
//         }
//     }
// }

// protected access modifiers can only be accessed from the same class and its derived classes

// using System;

// namespace MyApplication {

//     class Student {

//         protected string name = "Sheeran";
//     }

//     // derived class
//     class Program : Student {
//         static void Main(string[] args) {

//             // creating object of derived class
//             Program program = new Program();

//             // accessing name field and printing it
//             Console.WriteLine("Name: " + program.name);
//             Console.ReadLine();
//         }
//     }
// }

// Since the protected member can be accessed from derived classes, we are able to access name from the Program class

// internal access modifiers can be accessed only within the same assembly

// an assembly is a collection of types(classes, interfaces, etc...) and resources (data). They are built
// to work together and form a logical unit of functionality.

// If we use internal within a single assembly, it works just like the public access modifier

// Code on Assembly2

// using System;

// // access Assembly1
// using Assembly1;

// namespace Assembly2 {
//     class Program {
//         static void Main(string[] args) {
//             StudentName student = new StudentName();

//             // accessing name field from Assembly1
//             Console.Write(student.name);
//             Console.ReadLine();
//         }
//     }
// }

// ---

// The protected internal is a combination of protected and internal access modifiers

// // Code on Assembly1
// using System;

// namespace Assembly1 {
//     public class Greet {
//         protected internal string msg = "Hello";
//     }

//     class Program {
//         static void Main(string[] args) {
//             Greet greet = new Greet();

//             Console.WriteLine(greet.msg);
//             Console.ReadLine();
//         }
//     }
// }

// Code on Assembly2
using System;

// access Assembly1;
using Assembly1;

namespace Assembly2 {
    // derived class of Greet
    class Program:Greet {
        static void Main(string[] args) {
            Program greet = new Program();

            // accessing name field from Assembly1
            Console.Write(greet.msg);
            Console.ReadLine();
        }
    }
}
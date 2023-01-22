// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// using System;

// namespace StaticKeyword 
// {
//     class student 
//     {
//         public static string department = "Computer Science";
//     }
    
//     class program
//     {
//         static void Main(string[] argos)
//         {
//             Console.WriteLine("Department: " + student.department);
//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace StaticKeyword 
// {
//     class Student
//     {
//         static public string schoolName = "Programiz School";
//         public string studentName;
//     }
    
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student s1 = new Student();
//             s1.studentName = "Rammi";
            
//             // calls instance variable
//             Console.WriteLine("Name: " + s1.studentName);
//             // calls static variable
//             Console.WriteLine("School: " + Student.schoolName);
            
//             Student s2 = new Student();
//             s2.studentName = "Shyam";
            
//             // calls instance variable
//             Console.WriteLine("Name: " + s2.studentName);
//             // calls static variable
//             Console.WriteLine("School: " + Student.schoolName);

//         }
//     }
// }

// Example: C# Static and Non-static Methods

using System;

namespace StaticKeyword 
{
    class Test 
    {
        public void display1()
        {
            Console.WriteLine("Non static method");
        }
        public static void display2()
        {
            Console.WriteLine("Static method");
        }
    }
    
    class Program 
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            //access the non-static method using s1 object
            t1.display1();
            // access the static method using the class name Test
            Test.display2();
            Console.ReadLine();
        }
    }
}

//In C#, the Main method is static. So, we can call it without creating the object.


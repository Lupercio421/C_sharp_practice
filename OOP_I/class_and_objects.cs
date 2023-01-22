// using System;

// namespace ClassObject {
//     class Dog {
//         string breed;
        
//         public void bark() {
//             Console.WriteLine("Bark Bark!!");
//         }
//         static void Main(string[] args) {
            
//             // create object from the Dog class
//             Dog bullDog = new Dog();
            
//             // access breed of the Dog
//             // using the object name and the "."
//             // to access the 'breed' field
//             bullDog.breed = "Bull Dog";
//             Console.WriteLine(bullDog.breed);
            
//             // access method of the Dog
//             bullDog.bark();
            
//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace ClassObject {
//     class Employee {
//         string department;

//         static void Main(string[] args) {

//             // create Employee object
//             Employee sheeran = new Employee();

//             // set department for sheeran
//             sheeran.department = "Development";
//             Console.WriteLine("Sheeran works in the: " + sheeran.department + " department");

//             // create second object of Employee

//             Employee taylor = new Employee();

//             // set department for taylor
//             taylor.department = "Content Writing";
//             Console.WriteLine("Taylor works in the: " + taylor.department + " department");

//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace ClassObject {
//     class Employee {
//         public string name;

//         public void work(string work) {
//             Console.WriteLine("Work: " + work);
//         }
//     }

//     class EmployeeDrive {
//         static void Main(string[] args) {

//             // create Employee object
//             Employee e1 = new Employee();
//             Console.WriteLine("Employee 1");

//             // set name of the Employee
//             e1.name = "Gloria";
//             Console.WriteLine("Name: " + e1.name);

//             // call method of the Employee
//             e1.work("Coding");

//             Console.ReadLine();
//         }
//     }
// }

using System;

namespace ClassObject {
    class Employee {
        public string name;

        public void work(string work) {
            Console.WriteLine("Work: " + work);
        }
    }

    class EmployeeDrive {
        static void Main(string[] args) {

            // create Employee object
            Employee e1 = new Employee();
            Console.WriteLine("Employee 1");

            // set name of the Employee
            e1.name = "Gloria";
            Console.WriteLine("Name: " + e1.name);

            // call method of the Employee
            e1.work("Coding");

            Console.ReadLine();
        }
    }
}
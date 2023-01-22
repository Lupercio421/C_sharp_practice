// In C#, a constructor is similar to a method that is invoked when an object of the class is created.

// There are three types of constructors: parameterless, parameterized, default

// using System;
// namespace Constructor{
//     class Car {
//         // parameterless constructor
//         Car() {
//             Console.WriteLine("Car Constructor");
//         }
        
//         static void Main(string[] args) {
//             // call constructor
//             new Car(); // call a constructor by ading a 'new' keyword to the constructor name
//             Console.ReadLine();
//         }
//     }
// }

// --Parameterized Constructor--

// using System;

// namespace Constructor {
    
//     class Car {
//         string brand;
//         int price;
        
//         //creating parameterized constructor
//         Car(string theBrand, int thePrice) {
//             brand = theBrand;
//             price = thePrice;
//         }
        
//         static void Main(string[] args) {
//             // call paramterized constructor
//             // passing two values to the constructor
//             Car car1 = new Car("Bugatti", 50000);
            
//             Console.WriteLine("Brand: " + car1.brand);
//             Console.WriteLine("Price: " + car1.price);
//             Console.ReadLine();
//         }
//     }
// }

// --Default Constructor--

// using System;

// namespace Constructor{
//     class Program {
//         int a;
        
//         static void Main(string[] args) {
//             // call default constructor
//             // while creating an object, we are calling the constructor
//             Program p1 = new Program();
            
//             Console.WriteLine("Default value of a: " + p1.a);
//             Console.ReadLine();
//         }
//     }
// }

// we have not created any constructor in the Program class.
// Here, C# automatically creates a default constructor. The default constructor initializes any uninitialized variable with the default value.

// --Copy Constructor--

// We use a copy constructor to create an object by copying data from another object

// using System;

// namespace Constructor {
//     class Car {
//         string brand;
        
//         // constructor
//         Car (string theBrand) {
//             brand = theBrand;
//         }
        
//         // create the copy constructor
//         Car(Car c1) {
//             brand = c1.brand;
//         }
        
//         static void Main(string[] args) {
//             // call constructor
//             Car car1 = new Car("Bugatti");
            
//             Console.WriteLine("Brand of car1: " + car1.brand);
            
//             // call the copy constructor
//             // we have passed the car1 object as an argument to the copy constructor
//             Car car2 = new Car(car1);
//             //we have assigned the value of the brand for car1 object to the brand variable for car2 object. 
//             Console.WriteLine("Brand of car2: "+ car2.brand);
            
//             Console.ReadLine();
//         }
//     }
// }

// --Private Constructor--

// Once the constructor is declared private, we cannot create objects of the class in other classes.

// using System;

// namespace Constructor {

//   class Car {  
  
//   // private constructor
//   private Car () {
//     Console.WriteLine("Private Constructor");    
//     }
//   }
    
//     class CarDrive {

//       static void Main(string[] args) {

//       // call private constructor
//       Car car1 = new Car();
//       Console.ReadLine();
//     }
//   }
// }

// Since private members are not accessed outside of the class, when we try to create an object of Car, we get an error. 
// --Static Constructor--

// using System;

// namespace Constructor {

//   class Car {  
  
//   // create the static constructor
//   static Car () {
//     Console.WriteLine("Static Constructor");    
//   }

//     // parameterless constructor
//     Car() {
//      Console.WriteLine("Default Constructor");
//   } 

//     static void Main(string[] args) {

//       // when we call a regular parameterless constructor, the static constructor gets called
//       Car car1 = new Car();

//       // call parameterless constructor again
//       Car car2 = new Car();

//       Console.ReadLine();
//     }
//   }
// }

// --Constructor Overloading--

// using System;

// namespace ConstructorOverload {

//   class Car {   
    
//     // constructor with no parameter
//     Car() {
//       Console.WriteLine("Car constructor");
//     }
     
//     // constructor with one parameter
//     Car(string brand) {
//       Console.WriteLine("Car constructor with one parameter");
//       Console.WriteLine("Brand: " + brand);
//     }

//     static void Main(string[] args) {

//       // call constructor with no parameter
//       Car car = new Car();

//       Console.WriteLine();

//       // call constructor with parameter
//       Car car2 =  new Car("Bugatti");
     
//       Console.ReadLine();
//     }
//   }
// }

// In C#, we can create two or more constructor in a class. It is known as constructor overloading. 

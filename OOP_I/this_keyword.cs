// using System;

// namespace ThisKeyword {
//     class Test {
//         int num;
//         Test(int num) {
//             // this.num refers to the instance field
//             this.num = num;
//             Console.WriteLine("object of this:" + this);
//         }
//         static void Main(string[] args) {
//             // t1 object from Test class
//             Test t1 = new Test(10);
//             Console.WriteLine("object of t1: " + t1);
//             Console.ReadLine();
//         }
//     }
// }

// --C# this with Same Name Variables--

// using System;

// namespace ThisKeyword {
//     class Test {
//         int num;
//         Test(int num) {
//             // this.num refers to the instance variable of the class
//             this.num = num;
//         }
//         static void Main(string[] args) {
//             Test t1 = new Test(44);
//             Console.WriteLine("value of num: " + t1.num);
//             Console.ReadLine();
//         }
//     }
// }

// --C# this as an object argument--
// using System;
 
// namespace ThisKeyword {
//   class Test {
//     int num1;
//     int num2;
      
//     Test() {
//       num1 = 22;
//       num2 = 33;
//     }

//     // method that accepts this as argument   
//     void passParameter(Test t1) {
//       Console.WriteLine("num1: " + num1);
//       Console.WriteLine("num2: " + num2);
//     }

//     void display() {
//       // accepts the object of the class as an argument
//       passParameter(this);
//       // this refers to the instance of the class, we are able to access the value of num1 and num2
//     }
  
//     public static void Main(String[] args) {
//       Test t1 = new Test();
//       t1.display();
//       Console.ReadLine();
//     }
//   }
// }

// --this to declare a C# indexer --
// using System;
// namespace ThisKeyword {
      
//   class Student {
      
//     private string[] name = new string[3];
  
//     // creating an indexer
//     public string this[int index] {

//       // returns value of array element
//       get {
//         return name[index];
//       }
      
//       // sets value of array element
//       set { 
//         name[index] = value;
//       }
//     }
//   }
  
//   class Program {
  
//     public static void Main() {
//       Student s1 = new Student();
//       s1[0] = "Ram";
//       s1[1] = "Shyam";
//       s1[2] = "Gopal";

//       for (int i = 0; i < 3; i++) {

//         Console.WriteLine(s1[i] + " ");
//       }
//     }
//   }
// }

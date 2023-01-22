// --Method Level Variable--

// using System;

// namespace VariableScope {
//     class Program {
//         public void method1() {
//             // display variable inside method
//             string str = "method level";
//         }
//         public void method2() {
//             //accessing str inside method2()
//             Console.WriteLine(str); //error code
//         }

//         static void Main(string[] args) {
//             Program ps = new Program();
//             ps.method2();

//             Console.ReadLine();
//         }
//     }
// }

// using System;
// namespace VariableScope {
//     class Program {
//         public void display() {
//             string str = "inside method";

//             // accessing method level variable
//             Console.WriteLine(str);
//         }

//         static void Main(string[] args) {
//             Program ps = new Program();
//             ps.display();

//             Console.ReadLine();
//         }
//     }
// }

// Here we have created str variable and accessed it within the same method display(). Hence, the code runs without any error.

// --Block Level Variable Scope--
// using System;

// namespace VariableScope {
//     class Program {
//         public void display() {
//             for (int i = 0; i <= 3; i++) {

//             }
//     // outside for loop
//     Console.WriteLine(i); //error: 'i' does not exist in current context    
//         }
//     static void Main(string[] args) {
//         Program ps = new Program();
//         ps.display();

//         Console.ReadLine();
//     }    
//     }
// }

// using System;  
// namespace CsharpString {  
//   class Test {
//     public static void Main(string [] args) {
      
//       // create string
//       string str = "C# Programming";
//       //string str2 = "Programiz";
//       Console.WriteLine("string: " + str);
      
//       // get length of string
//       int length = str.Length;
//       Console.WriteLine("Length: " + length);

//       Console.ReadLine();
//     }
//   } 
// }

// using System;  
// namespace CsharpString {  
//   class Test {
//     public static void Main(string [] args) {

//       // create string
//       string str1 = "C# Programming";
//       string str2 = "C# Programming";
//       string str3 = "Programiz";
      
//       // compare str1 and str2
//       //create a boolean variable
//       Boolean result1 = str1.Equals(str2);
//       Console.WriteLine("string str1 and str2 are equal: " + result1);

//       //compare str1 and str3
//       Boolean result2 = str1.Equals(str3);
//       Console.WriteLine("string str1 and str3 are equal: " + result2);     

//       Console.ReadLine();
//     }
//   } 
// }

// -- string interpolation --
using System;
namespace CsharpString 
{
    class test
    {
        public static void Main(string [] args)
        {
            //creating the string
            string name = "Programiz";
            
            // string interpolation
            string message = $"Welcome to {name}";
            Console.WriteLine(message);
        }
    }
}

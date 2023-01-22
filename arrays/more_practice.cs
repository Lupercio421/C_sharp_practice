// In C#, we can declare an array by: datatype[] arrayName;

// // declare an array
// int[] age;

// // allocate memory for array
// age = new int[5];

// // We can also declare and allocate the memory of an array in a single line
// int[] age = new int[5];

// // in C#, we can intialize an array during the declaration

// int [] numbers = {1,2,3,4,5};

// // declare an array
// int[] age = new int[5];

// // initializng array
// age[0] = 12;
// age[1] = 4;
// age[2] = 5;

//using System;

// namespace AccesArray{
//     class Program {
//         static void Main(string[] args) {
//             // create an array
//             int[] numbers = {1,2,3};
            
//             // access first element
//             Console.WriteLine("Element in first index : " + numbers[0]);
            
//             // access second element
//             Console.WriteLine("Element in second index : " + numbers[1]);
            
//             // access third element
//             Console.WriteLine("Element in third index : " + numbers[2]);
            
//             Console.ReadLine();
//         }
//     }
// }
//using System;

// namespace ChangeArray{
//     class Program {
//         static void Main(string[] args) {
//             //create an array
//             int[] numbers = {1,2,3};
            
//             Console.WriteLine("Old Value at index 0: " + numbers[0]);
            
//             //changing the value at index 0
//             numbers[0] = 11;
            
//             //print new value
//             Console.WriteLine("New Value at index 0: " + numbers[0]);
            
//             Console.ReadLine();
//         }
//     }
// }

using System;

// namespace AccessArrayFor {
//   class Program {
//     static void Main(string[] args) {

//       int[] numbers = { 1, 2, 3};
 	 
//       for(int i=0; i < numbers.Length; i++) {
//         Console.WriteLine("Element in index " + i + ": " + numbers[i]);
//       }

//       Console.ReadLine();
//     }
//   }
// }

// using System;

// namespace AccessArrayForeach {
//   class Program {
//     static void Main(string[] args) {
//         int[] numbers = {1,2,3};
        
//         Console.WriteLine("Array Elements: ");
        
//         foreach(int num in numbers) {
//             Console.WriteLine(num);
//         }
//         Console.ReadLine();
//       }
//     }
//   }

// using System;

// // provides us various methods to use in an array
// using System.Linq;

// namespace ArrayMinMax {
//     class Program {
//         static void Main(string[] args) {
            
//             int[] numbers = {51, 1,3,4,98};
            
//             // get the minimum element
//             Console.WriteLine("Smallest Element: " + numbers.Min());
            
//             // Max() returns the largest number in array
            
//             Console.WriteLine("Largest Element: " + numbers.Max());
            
//             Console.ReadLine();
//         }
//     }
// }

// using System;

// // provides us various methods to use in an array
// using System.Linq;

// namespace ArrayMinMax {
//     class Program {
//         static void Main(string[] args) {
            
//             int[] numbers = {51, 31, 94, 86, 55};
            
//             // get the sum of all array elements
            
//             float sum = numbers.Sum();
            
//             // get the total number of elements present in the array
//             int count = numbers.Count();
            
//             float average = sum/count;
            
//             Console.WriteLine("Average : " + average);
            
//             // compute the average
//             Console.WriteLine("Average using Average() : " + numbers.Average());
            
//             Console.ReadLine();
//         }
//     }
// }
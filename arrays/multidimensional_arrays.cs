// Here, x is a two dimensional array with 2 elements. And each element is also an array with 3 elements.

// int[,] x = new int[2,3];

// we can also specify the number of rows and columns during the initialization. For example

// int [,] x = new int[2,3]{{1,2,3}, {3,4,5}};

// using System;

// namespace MultiDArray{
//     class Program {
//         static void Main(string[] args) {
//             // initializing 2D array

//             int[,] numbers = {{2,3}, {4,5}};

//             // access first element from the first row
//             Console.WriteLine("Element at index [0,0] : " + numbers[0,0]);

//             // access first element from second row
//             Console.WriteLine("Element at index [1,0] : " + numbers[1,0]);
//         }
//     }
// }

// using System;

// namespace MultiDArray{
//     class Program {
//         static void Main(string[] args) {

//             int[,] numbers = {{2,3}, {4,5}};

//             // old element
//             Console.WriteLine("Old element at index [0,0] : " + numbers[0,0]);

//             // assigning new value
//             numbers[0,0] = 222;

//             // new element
//             Console.WriteLine("New element at index [0,0] : " + numbers[0,0]);
//         }
//     }
// }

using System;

namespace MultiDArray{
    class Program {
        static void Main(string[] args) {

            int[,] numbers = {{2,3,9}, {4,5,9}};

            for(int i = 0; i < numbers.GetLength(0); i++) {
                Console.Write("Row " + i + ": ");

                for (int j = 0; j < numbers.GetLength(1); j++) {
                    Console.Write(numbers[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
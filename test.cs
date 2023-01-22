using System
// namespace  DataType
namespace Operator

// Hello World! program

// 
// namespace HelloWorld
// {
//     class Hello{
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Hello World!");
//         }
//     }
// }

//Alternate Hello World! Implementation

// using System;
// namespace HelloWorld
// {
//     class Hello {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

// int age = 24;

// {
//     class SByteExample
//     {
//         public static void Main(string[] args)
//         {
//             sbyte level = 23;
//             Console.WriteLine(level);
//         }
//     }
// }

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine ("Hello Mono World");
//     }
// }

// {
//     class ShortExample
//     {
//         public static void Main(string[] args)
//         {
//             short value = -330;
//             Console.WriteLine(value);
//         }
//     }
// }

// {
//     class IntExample
//     {
//         public static void Main(string[] args)
//         {
//             int score = 51093;
//             Console.WriteLine(score);
//         }
//     }
// }

// {
//     class LongExample
//     {
//         public static void Main(string[] args)
//         {
//             long range = -7091821871L;
//             Console.WriteLine(range);
//         }
//     }
// }

// {
//     class UShortExample
//     {
//         public static void Main(string[] args)
//         {
//             ushort value = 0;
//             Console.WriteLine(value);
//         }
//     }
// }

// {
//     class FloatExample
//     {
//         public static void Main(string[] args)
//         {
//             float number = 43.113F;
//             Console.WriteLine(number);
//         }
//     }
// }

// {
//     class CharExample
//     {
//         public static void Main(string[] args)
//         {
//             char ch1 = '\u0043';
//             char ch2 = 'x';
//             Console.WriteLine(ch1);
//             Console.WriteLine(ch2);
//         }
//     }
// }

{
    class DecimalExample
    {
        public static void Main(string[] args)
        {
            decimal bankBalance = 530005.25M;
            Console.WriteLine(bankBalance);
        }
    }
}

// {
//     class AssignmentOperator
//     {
//         public static void Main(string[] args)
//         {
//             int firstNumber, secondNumber;
//             // Assigning a constant to variable
//             firstNumber = 10;
//             Console.WriteLine("First Number = {0}", firstNumber);
            
//             //Assigning a variable to another variable
//             secondNumber = firstNumber;
//             Console.WriteLine("Second Number = {0} and {1}", secondNumber, 2);
//         }
//     }
// }

// {
//     class ArithmeticOperator
//     {
//         public static void Main(string[] args)
//         {
//             double firstNumber = 14.40, secondNumber = 4.60, result;
//             int num1 = 26, num2 = 4, rem;
            
//             // Addition operator
//             result = firstNumber + secondNumber;
//             Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
//             // Subtraction operator
//             result = firstNumber + secondNumber;
//             Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
//             // Multiplication operator
//             result = firstNumber + secondNumber;
//             Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);
//             // Modulo operator
//             rem = num1 % num2;
//             Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);
//         }
//     }
// }

// {
//     class RelationalOperator
//     {
//         public static void Main(string[] args)
//         {
//             bool result;
//             int firstNumber = 10, secondNumber = 20;
            
//             result = (firstNumber == secondNumber);
//             Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);
            
//             result = (firstNumber > secondNumber);
//             Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);
            
//             result = (firstNumber < secondNumber);
//             Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);
            
//             result = (firstNumber >= secondNumber);
//             Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);
            
//             result = (firstNumber != secondNumber);
//             Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);
//         }
//     }
// }

// {
//     class UnaryOperator
//     {
//         public static void Main(string[] args)
//         {
//             int number = 10, result;
//             bool flag = true;
            
//             result = +number;
//             Console.WriteLine("+number = " + result);
            
//             result = -number;
//             Console.WriteLine("-number = " + result);
            
//             // increment value by 1
//             result = ++number;
//             Console.WriteLine("++number = " + result);
            
//             // decrement value by 1
//             result = --number;
//             Console.WriteLine("--number = " + result);
            
//             Console.WriteLine("!flag = " + (!flag));
//         }
//     }
// }

// {
//     class UnaryOperator
//     {
//         public static void Main(string[] args)
//         {
//             int number = 10;
            
//             Console.WriteLine((number++));
//             Console.WriteLine(number);
//             Console.WriteLine((++number));
//         }
//     }
// }

// {
//     class TernaryOperator
//     {
//         public static void Main(string[] args)
//         {
//             int number = 10;
//             string result;
            
//             result = (number % 2 == 0)? "Even Number" : "Odd Number";
//             Console.WriteLine("{0} is an {1}", number, result);
//         }
//     }
// }

// namespace Sample

// {
//     class Test
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("C# is cool");
//         }
//     }
// }

// {
//     class Test
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Prints on ");
//             Console.WriteLine("New Line");
            
//             Console.Write("Prints on");
//             Console.Write("Same line");
//         }
//     }
// }

// {
//     class Test
//     {
//         public static void Main(string[] args)
//         {
//             int value = 10;
            
//             // Variable
//             Console.WriteLine(value);
//             // Literal
//             Console.WriteLine(50.05);
//         }
//     }
// }

// {
//     class Test
//     {
//         public static void Main(string[] args)
//         {
//             int val = 55;
//             Console.WriteLine("Hello " + "World");
//             Console.WriteLine("Value = " + val);
//         }
//     }
// }    

// {
//     class Test
//     {
//         public static void Main(string[] args)
//         {
//             string testString;
//             Console.Write("Enter a string - ");
//             testString = Console.ReadLine();
//             Console.WriteLine("You entered '{0}'", testString);
//         }
//     }
// }

// {
//     class Test
//     {
//         public static void Main(string[] args)
//         {
//             int userInput;
            
//             Console.WriteLine("Press any key to continue...");
//             Console.ReadKey();
//             Console WriteLine();
            
//             Console.Write("Input using Read() - ");
// 			userInput = Console.Read();
// 			Console.WriteLine("Ascii Value = {0}",userInput);
//         }
//     }
// }

// namespace Blocks
// {
//     class BlockExample
//     {
//         public static void Main(string[] args)
//         {
//             double temperature = 42.05;
//             if (temperature > 32)
//             {
//                 // Start of block
//                 Console.WriteLine("Current Temperature = {0}", temperature);
//                 Console.WriteLine("It's hot");
//                 // End of block
//             }
//         }
//     }
// }

/// <summary>
/// This is a hello world program
/// </summary>

// namespace Blocks
// {
//     class BlockExample
//     {
//         public static void Main(string[] args)
//         {
//             double temperature = 42.05;
//             if (temperature > 32)
//             {
//                 // Start of block
//                 // No statements
//                 // End of block
//             }
//         }
//     }
// }

// {
//     class IfStatement
//     {
//         public static void Main(string[] args)
//         {
//             int number = 6;
//             if (number < 5)
//             {
//                 Console.WriteLine("{0} is less than 5", number);
//             }
//             Console.WriteLine("This statement is always executed.");
//         }
//     }
// }

// C# if...else Statement

// {
//     class IfElseStatement
//     {
//         public static void Main(string[] args)
//         {
//             int number = 2;
//             if (number < 5)
//             {
//                 Console.WriteLine("{0} is less than 5", number);
//             }
//             else
//             {
//                 Console.WriteLine("{0} is greater than or equal to 5", number);
//             }
//             Console.WriteLine("This statement is always executed");
//         }
//     }
// }

// C# if...else if (if-then-else if) Statement

// {
//     class IfElseIfStatement
//     {
//         public static void Main(string[] args)
//         {
//             int number = 5;
            
//             if (number < 5)
//             {
//                 Console.WriteLine("{0} is less than 5", number);
//             }
//             else if (number > 5)
//             {
//                 Console.WriteLine("{0} is greater than 5", number);
//             }
//             else
//             {
//                 Console.WriteLine("{0} is equal to 5", number);
//             }
//         }
//     }
// }

{
	class Nested
	{
		public static void Main(string[] args)
		{
			int first = 7, second = -23, third = 13;
			if (first > second)
			{
				if (first > third)
				{
					Console.WriteLine("{0} is the largest", first);
				}
				else
				{
					Console.WriteLine("{0} is the largest", third);
				}
			}
			else
			{
				if (second > third)
				{
					Console.WriteLine("{0} is the largest", second);
				}
				else
				{
					Console.WriteLine("{0} is the largest", third);
				}
			}
		}
	}
}

// {
//     class SwitchCase
//     {
//         public static void Main(string[] args)
//         {
//             char ch;
//             Console.WriteLine("Enter an Alphabet");
//             ch = Convert.ToChar(Console.ReadLine());
            
//             switch(Char.ToLower(ch))
//             {
//                 case 'a':
//                     Console.WriteLine("Vowel");
//                     break;
//                 case 'e':
//                     Console.WriteLine("Vowel");
//                     break;
//                 case 'i':
//                     Console.WriteLine("Vowel");
//                     break;
//                 case 'o':
//                     Console.WriteLine("Vowel");
//                     break;
//                 case 'u':
//                     Console.WriteLine("Vowel");
//                     break;
//                 default:
//                     Console.WriteLine("Not a Vowel");
//                     break;
//                 }
//             }
//         }
//     }

// {
//     class SwitchCase
//     {
//         public static void Main(string[] args)
//         {
//             char ch;
//             Console.WriteLine("Enter an alphabet");
//             ch = Convert.ToChar(Console.ReadLine());
 
//             switch(Char.ToLower(ch))
//             {
//                 case 'a':
//                 case 'e':
//                 case 'i':
//                 case 'o':
//                 case 'u':
//                     Console.WriteLine("Vowel");
//                     break;
//                 default:
//                     Console.WriteLine("Not a vowel");
//                     break;
//             }
//         }
//     }
// }

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// using System;
 
// namespace Conditional
// {
//     class SwitchCase
//     {
//         public static void Main(string[] args)
//         {
//             char op;
//             double first, second, result;
             
//             Console.Write("Enter first number: ");
//             first = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Enter second number: ");
//             second = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Enter operator (+, -, *, /): ");
//             op = (char)Console.Read();
 
//             switch(op)
//             {
//                 case '+':
//                     result = first + second;
//                     Console.WriteLine("{0} + {1} = {2}", first, second, result);
//                     break;
                 
//                 case '-':
//                     result = first - second;
//                     Console.WriteLine("{0} - {1} = {2}", first, second, result);
//                     break;
                 
//                 case '*':
//                     result = first * second;
//                     Console.WriteLine("{0} * {1} = {2}", first, second, result);
//                     break;
                 
//                 case '/':
//                     result = first / second;
//                     Console.WriteLine("{0} / {1} = {2}", first, second, result);
//                     break;
 
//                 default:
//                     Console.WriteLine("Invalid Operator");
//                     break;
                     
//             }
//         }
//     }
// }

using System;
 
// namespace Conditional
// {
//     class Ternary
//     {
//         public static void Main(string[] args)
//         {
//             int number = 5;
//             bool isEven;
            
//             isEven = (number % 2 == 0)? true: false;
//             Console.WriteLine(isEven);
//         }
//     }
// }

namespace Loop

// {
//     class ForLoop
//     {
//         public static void Main(string[] args)
//         {
//             for (int i = 0; i>=-6; i--)
//             {
//                 Console.WriteLine("C# For Loop: Iteration {0}", i);
//             }
//         }
//     }
// }

// {
//     class ForLoop
//     {
//         public static void Main(string[] args)
//         {
//             int n = 8;
//             int sum = 0;
            
//             for (int i = 1; i <= n; i++)
//             {
//                 // sum = sum + i;
//                 sum += i;
//             }
//             Console.WriteLine("Sum of first {0} natural numbers = {1}", n, sum);
//         }
//     }
// }

// We can have more than one initialization and/or iterator statements within a for loop

// {
//     class ForLoop
//     {
//         public static void Main(string[] args)
//         {
//             for (int i = 0, j = 0; i+j <= 5; i++, j++)
//             {
//                 Console.WriteLine("i = {0} and j = {1}", i, j);
//             }
//         }
//     }
// }

// {
//     class ForLoop
//     {
//         public static void Main(string[] args)
//         {
//             int i = 1;
//             for (; i<=5; )
//             {
//                 Console.WriteLine("C# For Loop: Iteration {0}", i);
//                 i++;
//             }
//         }
//     }
// }

// {
//     class WhileLoop
//     {
//         public static void Main(string[] args)
//         {
//             int i = 1;
//             while (i <= 5)
//             {
//                 Console.WriteLine("C# For Loop: Iteration {0}", i++);
//             }
//         }
//     }
// }

// while loop to compute sum of first 5 natural numbers

// {
//     class WhileLoop
//     {
//         public static void Main(string[] args)
//         {
//             int i = 1, sum = 0;
//             while (i <= 5)
//             {
//                 sum += i;
//                 i++;
//             }
//             Console.WriteLine("Sum = {0}", sum);
//         }
//     }
// }

// {
//     class DoWhileLoop
//     {
//         public static void Main(string[] args)
//         {
//             int i = 1, n = 5, product;
//             do
//             {
//                 product = n * i;
//                 Console.WriteLine("{0} * {1} = {2}", n, i, product);
//                 i++;
//             } while (i <= 10);
//         }
//     }
// }

// {
//     class NestedForLoop
//     {
//         public static void Main(string[] args)
//         {
//             int outerLoop = 0, innerLoop = 0;
//             for(int i=1; i<=5; i++)
//             {
//                 outerLoop++;
//                 for (int j = 1; j<=5;j++)
//                 {
//                     innerLoop++;
//                 }
//         }
//         Console.WriteLine("Outer Loop runs {0} times", outerLoop);
//         Console.WriteLine("Inner Loop runs {0} times", innerLoop);
//         }
//     }
// }

// using System;

// namespace Loop
// {
// 	class NestedForLoop
// 	{
// 		public static void Main(string[] args)
// 		{
// 			for (int i=1; i<=5; i++)
// 			{
// 				Console.WriteLine(i);
// 				for (int j=1; j<=i; j++)
// 				{
// 					Console.Write(j + " ");
// 				}
// 				Console.WriteLine();
// 			}
// 		}
// 	}
// }

// using System;

// namespace Loop
// {
// 	class NestedWhileLoop
// 	{
// 		public static void Main(string[] args)
// 		{
// 			int i=0;
// 			while (i<2)
// 			{
// 				int j=0;
// 				while (j<2)
// 				{
// 					Console.Write("({0},{1}) ", i,j);
// 					j++;
// 				}
// 				i++;
// 				Console.WriteLine();
// 			}
// 		}
// 	}
// }

// using System;

// namespace Loop
// {
// 	class NestedLoop
// 	{
// 		public static void Main(string[] args)
// 		{
// 			int i=1;
// 			while (i<=5)
// 			{
// 				for (int j=1; j<=i; j++)
// 				{
// 					Console.Write(i + " ");
// 				}

// 				Console.WriteLine();
// 				i++;
// 			}
// 		}
// 	}
// }

// namespace CSharpBreak {
//     class Program {
//         static void Main(string[] args) {
//             for (int i = 1; i <= 4; i++) {
//                 // terminates the loop
//                 if (i == 3) {
//                     break;
//                 }
//                 Console.WriteLine(i);
//             }
//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace WhileBreak {
//     class Program {
//         static void Main(string[] args) {
//             int i = 1;
//             while (i <= 5) {
//                 Console.WriteLine(i);
//                 i++;
//                 if (i==4) {
//                     // terminates the loop
//                     break;
//                 }
//             }
//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace NestedBreak {
//     class Program {
//         static void Main(string[] args) {
//             int sum = 0;
//             for (int i = 1; i <= 3; i++) { // outer loop
                
//                 // inner loop
//                 for (int j = 1; j <= 3; j++) {
//                     if (i == 2) {
//                         break;
//                     }
//                     Console.WriteLine("i = " + i + " j = " + j);
//                 }
//             }
//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace ForEachBreak {
//     class Program {
//         static void Main(string[] args) {
//             int[] num = {1,2,3,4,5};
            
//             // use of for each loop
//             foreach(int number in num) {
                
//                 // terminates the loop
//                 if(number == 3) {
//                     break;
//                 }
//                 Console.WriteLine(number);
//             }
//         }
//     }
// }

using System;

// namespace ContinueLoop {
//     class Program {
//         static void Main(string[] args) {
//             for (int i = 1; i <= 5; i++) {
//                 // skips the condition
//                 if (i == 3) {
//                     continue;
//                 }
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }

using System;

// namespace ContinueNested {
//     class Program {
//         static void Main(string[] args) {
//             int sum = 0;
            
//             // outer loop
//             for(int i = 1; i <= 3; i++) {
//                 // inner loop
//                 for(int j = 1; j <= 3; j++) {
//                     if (j == 2) {
//                         continue;
//                     }
//                     Console.WriteLine("i = " + i + " j = " + j);
//                 }
//             }
//         }
//     }
// }

// using System;

// namespace ContinueForeach {
//     class Program {
//         static void Main(string[] args){
//             int[] num = {1,2,3,4,5};
//             foreach(int number in num) {
                
//                 // skips the iteration
//                 if(number==3) {
//                     continue;
//                 }
//                 Console.WriteLine(number);
//             }
//         }
//     }
// }
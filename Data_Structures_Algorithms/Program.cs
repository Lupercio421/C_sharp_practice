// See https://aka.ms/new-console-template for more information
namespace Data_Structures_Algorithms
{
    public class Program
    {
        //public static void Main()
        //{
        //    //var bp = new BalancedParenthesis();
        //    //char[] chars = { '{', '(', ')', '}', '[', ']' };
        //    char[] chars = { '{', '(', ')', '}', '[', '[' };
        //    // function call

        //    if (BalancedParenthesis.areBracketsBalanced(chars))
        //        Console.WriteLine("Balanced");
        //    else
        //        Console.WriteLine("Not Balanced");
        //}
        static void Main(string[] args)
        {
            var pc = new BalancedParenthesisPython();
            Console.WriteLine("Test 1, {}: " + pc.parChecker("{}"));
            Console.WriteLine("Test 2, [{()]: " + pc.parChecker("[{()]"));
            Console.WriteLine("Test 3, {({([][])}())}: " + pc.parChecker("{({([][])}())}"));
            Console.WriteLine("Test 4, {}[[[[]]]]([[]]): " + pc.parChecker("{[[[[]]]]([[]])}"));
            Console.WriteLine("Test 5, (((((()))))): " + pc.parChecker("(((((())))))"));
        }
    }

}
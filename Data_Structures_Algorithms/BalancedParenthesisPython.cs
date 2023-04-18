using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms
{
    public class BalancedParenthesisPython
    {
        public bool parChecker(string symbolString)
        {
            Stack<char> s = new Stack<char>();

            var balanced = true;

            int index = 0;

            while (index < symbolString.Length && balanced) 
            {
                char symbol = symbolString[index];

                if (symbol == '(' || symbol == '[' || symbol == '{')
                {
                    s.Push(symbol);
                }
                else
                {
                    if (s.Count == 0)
                    {
                        balanced = false;
                    }
                    else
                    {
                        char top = s.Pop();
                        if (!Matches(top, symbol))
                        {
                            balanced = false;
                        }
                    }
                }
                index++;
            }
            if (balanced && s.Count == 0)
            {
                return true;
            }
            else { return false; }
        }
        private bool Matches(char open, char close)
        {
            string opens = "({[";
            string closers = ")}}";

            return opens.IndexOf(open) == closers.IndexOf(close);
        }
    }
}

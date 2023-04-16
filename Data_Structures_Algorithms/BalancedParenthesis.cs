using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms
{
    public class BalancedParenthesis
    {
        static Boolean areBracketsBalanced(char[] exp)
        {
            //Declare an empty character stack
            Stack<char> st = new Stack<char>();

            //Traverse the given expression to check matching brackets
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(' || exp[i] == '[' || exp[i]=='{')
                    st.Push(exp[i]);

                //  If exp[i] is an ending bracket then pop from the stack and check if the popped bracket
                // is a matching pair
                if (exp[i] == ')' || exp[i] == '}' || exp[i] == ']')
                {
                    //If we see an ending bracket w/o a pair, then return false
                    if (st.Count == 0)
                    {
                        return false;
                    }

                    // Pop the top element from stack, if
                    // it is not a pair brackets of
                    // character then there is a mismatch. This
                    // happens for expressions like {(})
                    else if (!matches(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }
            if (st.Count == 0)
                return true; //it is balanced
            else
            {
                return false;//not balanced
            }    
        }
        static Boolean matches(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')') 
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' &&  character2 == ']')
                return true;
            else 
                return false;
        }
    }
}

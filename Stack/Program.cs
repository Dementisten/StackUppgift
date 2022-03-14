using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            string test = "[]{)}(";

            foreach(char c in test){
                stack.Push(c);
            }

            int i = 0;
            while (stack.Count != 0){
                
                char k = stack.Pop();
                if (k == '('){
                    i++;
                }
                else if (k == ')'){
                    i--;
                }
                else if (k == '{'){
                    i++;
                }
                else if (k == '}'){
                    i--;
                }
                else if (k == '['){
                    i++;
                }
                else if (k == ']'){
                    i--;
                }
            }

            if (i == 0){
                Console.WriteLine("Balanserad");
            }
            else{
                Console.WriteLine("Inte Balanserad");
            }

        }
    }
}

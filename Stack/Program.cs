using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            string test = "())))(((";

            foreach(char c in test){
                stack.Push(c);
            }

            int i = 0;
            int l = 0;
            int p = 0;

            while (stack.Count != 0){
                
                
                char k = stack.Pop();
                if (stack.Count == 0){
                    if(k == ')'){
                        p = p + 100;
                    }
                    else if(k == ']'){
                        p = p + 100;
                    }
                    else if(k == '}'){
                        p = p + 100;
                    }
                }

                if (k == '('){
                    i++;
                }
                else if (k == ')'){
                    i--;
                }
                else if (k == '{'){
                    l++;
                }
                else if (k == '}'){
                    l--;
                }
                else if (k == '['){
                    p++;
                }
                else if (k == ']'){
                    p--;
                }
            }

            if (i == 0 && l == 0 && p == 0){
                Console.WriteLine("Balanserad");
            }
            else{
                Console.WriteLine("Inte Balanserad");
            }

        }
    }
}

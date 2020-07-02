using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParenthesesChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.Write("\nInput expression: ");
                char[] input = Console.ReadLine().ToArray();

                Stack<char> container = new Stack<char>();

                bool parenthesesFound = false;
                bool parenthesesCorect = true;

                for (int i = 0; i < input.Length; i++)
                {
                    switch (input[i])
                    {
                        case '(':
                            parenthesesFound = true;

                            if (i == input.Length - 1)
                            {
                                parenthesesCorect = false;
                            }

                            container.Push(input[i]);
                            break;

                        case ')':
                            parenthesesFound = true;

                            if (container.Count == 0)
                            {
                                parenthesesCorect = false;
                                Console.WriteLine("Thre is a ( missing.");
                                break;
                            }

                            container.Pop();
                            //Console.WriteLine("A pair of parentheses matched.");

                            break;

                        default:
                            break;
                    }
                }

                if (!parenthesesFound)
                {
                    Console.WriteLine("\nThe expression contains no parentheses.");
                    parenthesesCorect = false;
                }

                if(container.Count != 0)
                {
                    Console.WriteLine("There are " + container.Count + " ) missing.");
                    parenthesesCorect = false;
                }
                
                if (parenthesesCorect)
                    Console.WriteLine("\nThe expression's parentheses are corect.");

                Console.Write("\nPress 't' to terminate program.\nPress any other key to do another exaple.");
                string choice = Console.ReadLine();

                if (choice == "t" || choice == "T")
                    flag = false;
            }
        }
    }
}

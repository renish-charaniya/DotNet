<<<<<<< HEAD
﻿/* Practical 4
 * 'Write C# code to convert infix notation to postfix notation. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 323782afd325f0a8daca94052819a2230d5d0aac

namespace Practical4
{
    class Program
    {
<<<<<<< HEAD
        static void Main(string[] args)
        {
            string infix;
            string postfix;
            infix = "(a^b)/c";
            infixToPostfix(infix, out postfix);
            Console.WriteLine($"Infix Expression {infix}\nPostfix Expression {postfix}");
            Console.Read();

        }
        /// <summary>
        /// Converts given infix expression to equivalent postfix expression
        /// </summary>
        /// <param name="infix">Given infix exoression</param>
        /// <param name="postfix">Equivalent postfix expression converted from infix expression</param>
        private static void infixToPostfix(string infix, out string postfix)
        {
            postfix = "";
            char ch;
            Stack<char> operators = new Stack<char>();

            //Process each character in the expression
            for (int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];
                if ("^()+-*/%".Any(c => c == ch)) //Check for operators
                { 
                    if(operators.Count == 0)
                    {
                        //If the stack is empty than push current operator to the stack
                        operators.Push(ch);
                    }
                    else
                    {
                        if(ch == '(')
                        {
                            operators.Push(ch);
                        }
                        else if(ch == ')')
                        {
                            //Pop all operator from stack to pstfix until you reach '('
                            while(operators.Peek() != '(')
                            {
                                postfix += operators.Pop();
                            }
                            operators.Pop(); //Pop '(' from the stack
                        }
                        else if(priority(ch) > priority(operators.Peek()))
                        {
                            //If new operator has higher priority than top of the stack then push it to the stack
                            operators.Push(ch);
                        }
                        else
                        {
                            //Pop top of the stack to postfix and decrease 'i' to operate same inpur operator in the next itration
                            postfix += operators.Pop();
                            i--;
                        }
                    }
                }
                else 
                {
                    //Add every operand to postfix
                    postfix += ch;
                }
            }

            //Pop all remaining operators from stack to postfix expression
            foreach (var item in operators)
            {
                postfix += item;
            }
        }

        /// <summary>
        /// return the priority of the given operator 
        /// </summary>
        /// <param name="ch">The operator for which we want to find priority</param>
        /// <returns></returns>
        private static int priority(char ch)
        {
            switch (ch)
            {
                case '(':
                    return 0; // Minimum 
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3; //Maximum
                default:
                    return 4; //Should never be executed for a valid infix expression
            }
=======
        //isOperator() is check the given character is operator or not .
        public static Boolean isOperator(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '%' || ch == '^')
                return true;
            else
                return false;
        }

        //pr() is used to get priority.
        public static int pr(char ch)
        {
            switch (ch)
            {
                case '(':
                    return 0;

                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                case '%':
                    return 2;
                case '^':
                    return 3;
            }
            return 0;
        }
        public static String reverse(String s)
        {
            String temp="";
            for(int i=s.Length-1;i>=0;i--)
            {
                if (s[i] == '(')
                    temp += ')';
                else if (s[i] == ')')
                    temp += '(';
                else
                    temp += s[i];
            }
            return temp;
        }

        static void Main(string[] args)
        {
            String infix, postfix,prefix;

            //Convert Infix to Postfix String ...
            Console.WriteLine("Convert Infix to Postfix String ...");
            Console.Write("Enter the Infix String : ");
            infix = Console.ReadLine();
            infixToPostfix(ref infix, out postfix);
            Console.WriteLine("Postfix String : "+postfix);

            //Convert Infix to Prefix String ...
            Console.WriteLine("\nConvert Infix to Prefix String ...");
            Console.Write("Enter the Infix String : ");
            infix = Console.ReadLine();
            infixToPrefix(ref infix,out prefix);
            Console.WriteLine("Prefix String : "+prefix);

            Console.Read();
        }

        //Convert infix string into postfix string
        // ref and out is use for pass by reference.
        //ref means you may reference this variable.
        //out means you must initialize this variable.
        public static void infixToPostfix(ref String infix,out String postfix)
        {
            postfix = "";
            char ch;
            Stack<char> stack = new Stack<char>();
            for(int i=0;i<infix.Length;i++)
            {
                ch = infix[i];
                if(ch=='(')
                {
                    stack.Push(ch);
                }
                else if(isOperator(ch))
                {
                    if (stack.Count == 0)
                        stack.Push(ch);
                    else
                    {
                        if (pr(stack.Peek()) >= pr(ch))
                        {
                            postfix += stack.Pop();
                            i--;
                        }
                        else
                            stack.Push(ch);
                    }
                }
                else if(ch==')')
                {
                    while (stack.Peek() != '(')
                        postfix += stack.Pop();
                    stack.Pop();
                }
                else
                    postfix += ch;
            }
            while(stack.Count!=0)
                postfix += stack.Pop();
        }

        //Convert infix String into prefix String .
        public static void infixToPrefix(ref String infix,out String prefix)
        {
            prefix = "";
            infix = reverse(infix);
            String postfix="";
            char ch;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (isOperator(ch))
                {
                    if (stack.Count == 0)
                        stack.Push(ch);
                    else
                    {
                        if (pr(stack.Peek()) >= pr(ch))
                        {
                            postfix += stack.Pop();
                            i--;
                        }
                        else
                            stack.Push(ch);
                    }
                }
                else if (ch == ')')
                {
                    while (stack.Peek() != '(')
                        postfix += stack.Pop();
                    stack.Pop();
                }
                else
                    postfix += ch;
            }
            while (stack.Count != 0)
                postfix += stack.Pop();
            prefix = reverse(postfix);
>>>>>>> 323782afd325f0a8daca94052819a2230d5d0aac
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern 1");
            pattern1();//Call Static method pattern1()
            Console.WriteLine("Pattern 2");
            pattern2();//Call Static method pattern2()
            Console.WriteLine("Pattern 3");
            pattern3();//Call Static method pattern3()
            Console.WriteLine("Pattern 4");
            pattern4();//Call Static method pattern4()
            Console.WriteLine("Pattern 5");
            pattern5();//Call Static method pattern5()
            Console.Read();
        }
        static void pattern1()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine(); //for new line
            }
        }
        static void pattern2()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                    Console.Write("*");
                Console.WriteLine(); //for new line
            }
        }
        static void pattern3()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                    Console.Write("*");
                Console.WriteLine(); //for new line
            }
        }
        static void pattern4()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 4; j >= i; j--)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine(); //for new line
            }
        }
        static void pattern5()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i; j++)
                    Console.Write(" ");
                for (int j = 5; j >= i; j--)
                    Console.Write("*");
                Console.WriteLine(); //for new line
            }
        }
    }
}

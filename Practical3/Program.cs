using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,c;
            Console.WriteLine("Number Conversions");
            while(true)
            {
                Console.WriteLine("1. Binary To Decimal");
                Console.WriteLine("2. Decimal To Binary");
                Console.WriteLine("3. Decimal To Octal");
                Console.WriteLine("4. Decimal To Hexadecimal");
                Console.WriteLine("5. Exit");
                Console.Write("Enter the your choice : ");
                c = int.Parse(Console.ReadLine());
                switch(c)
                {
                    case 1: Console.WriteLine("Binary To Decimal");
                            Console.Write("Enter the Number :");
                            number = int.Parse(Console.ReadLine());
                            BinaryToDecimal(number);
                            break;


                    case 2: Console.WriteLine("Decimal To Binary");
                            Console.Write("Enter the Number :");
                            number = int.Parse(Console.ReadLine());
                            DecimalToBinary(number);
                            break;


                    case 3: Console.WriteLine("Decimal To Octal");
                            Console.Write("Enter the Number :");
                            number = int.Parse(Console.ReadLine());
                            DecimalToOct(number);
                            break;

                    case 4: Console.WriteLine("Decimal To Hexadecimal");
                            Console.Write("Enter the Number :");
                            number = int.Parse(Console.ReadLine());
                            DecimalToHex(number);
                            break;
                }
                if (c == 5)
                    break;
                Console.WriteLine();
            }
            Console.Read();
        }
        public static void  BinaryToDecimal(int n)
        {
            int sum = 0,a, p = 1;
            while(n>0)
            {
                a = n % 10;
                sum += a * p;
                p *= 2;
                n /= 10;
            }
            Console.WriteLine("Binary To Decimal : "+ sum) ;
        }
        public static void DecimalToBinary(int n)
        {
            int[] sum=new int[10];
            int a,i=0;
            while(n>0)
            {
                a = n % 2;
                sum[i++] = a;
                n /= 2;
            }
            Console.Write("Decimal To Binary : ");
            for(int j=i-1;j>=0;j--)
                Console.Write(sum[j]);
        }
        public static void DecimalToOct(int n)
        {
            int a,i=0;
            int[] sum = new int[10];
            while(n>0)
            {
                a = n % 8;
                sum[i++]= a;
                n /= 8;
            }
            Console.Write("Decimal To Octal : ");
            for(int j=i-1;j>=0;j--)
                Console.Write(sum[j]);
        }
        public static void DecimalToHex(int n)
        {
            int a, i = 0;
            char[] sum=new char[10];
            while (n > 0)
            {
                a = n % 16;
                if (a > 9)
                {
                    sum[i++] =(char)( a-10 + 65);
                }
                else
                {
                    sum[i++] = (char)(a + 48);
                }
                n /= 16;
            }
            Console.Write("Decimal to Hexadecimal : ");
            for(int j=i-1;j>=0;j--)
                Console.Write(sum[j]);
        }
    }
}

<<<<<<< HEAD
﻿/* Practical 3: Write C# code to do the  following 
 * a. Convert binary to decimal 
 * b. Convert decimal to hexadecimal 
 * c. Convert decimal to binary 
 * d. Convert decimal to octal
 */
using System;
using System.Text.RegularExpressions;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 323782afd325f0a8daca94052819a2230d5d0aac

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            int decimalNumber;

            #region Binary To Decimal
            bool flag = true;
            string binaryString;

            //Take and validate user input in string format
            Console.WriteLine("Enter a binary number(31 bit Max)");
            do
            {
                if (!flag) //Only execute if user enters anything except 0 and 1
                    Console.WriteLine("Please enter a valid binary value");
                binaryString = Console.ReadLine();
                flag = false; //will display error message in every subsequent iteration of this loop (if this loop continuous)
            } while (!Regex.IsMatch(binaryString, @"^[01]+$")); //Checking input string for anything other than 0s and 1s

            ConvertBinaryToDecimal(binaryString, out decimalNumber);
            Console.WriteLine("Answer: " + decimalNumber);

            #endregion

            #region Decimal To Octal and Binary

            //Declaration and initialisation
            int number, newBase;

            TakeDecimalInput(out decimalNumber);

            Console.WriteLine("In which base you want to convert? (2 or 8)");
            newBase = int.Parse(Console.ReadLine());

            ConvertDecimalToBinaryOrOctal(decimalNumber, out number, newBase);
            Console.WriteLine(number);

            #endregion

            #region Decimal To HexaDecimal
            string hex;
            TakeDecimalInput(out decimalNumber);
            ConvertDecimalToHex(decimalNumber, out hex);
            Console.WriteLine($"Hexadecimal equivalent of {decimalNumber} is {hex}");
            #endregion

            Console.Read();
        }

        #region Conversion Methods

        
        private static void ConvertDecimalToHex(int decimalNumber, out string hex)
        {
            char[] modulo = new char[31]; //To store all the modulos of a decimal mumber after iteratively dividing by 8
            int i = 0, temp;
            hex = "";
            //Find all the modulos and store them in an integer array
            while (decimalNumber > 0)
            {
                temp = (char)(decimalNumber % 16);
                if (temp > 9)
                    modulo[i] = (char)(temp + 55);
                else
                    modulo[i] = (char)(temp+48);
                decimalNumber /= 16;
                i++;
            }

            i--; //decrease by 1 to manage the actual length of the number

            //
            for (; i >= 0; i--)
            {
                hex += modulo[i];
            }
        }

       
        /// <summary>
        /// Converts decimal input to equivalent octal number
        /// </summary>
        /// <param name="decimalNumber">Decimal Number from user</param>
        /// <param name="number">Converted Octal Number will be returned in this variable</param>
        private static void ConvertDecimalToBinaryOrOctal(int decimalNumber, out int number, int newBase)
        {
            number = 0;
            int[] modulo = new int[31]; //To store all the modulos of a decimal mumber after iteratively dividing by 8
            int i = 0;
            string numberString = ""; //To form a single string of all the modulos togather

            //Find all the modulos and store them in an integer array
            while(decimalNumber>0)
            {
                modulo[i++] = decimalNumber % newBase;
                decimalNumber /= newBase;
            }

            i--; //decrease by 1 to manage the actual length of the number

            //
            for (; i >= 0 ; i--)
            {
                numberString += modulo[i].ToString();
            }
            number = int.Parse(numberString);
        }

        /// <summary>
        /// Converts a string of 0s and 1s to equivalent decimal number
        /// </summary>
        /// <param name="binaryString">string of 0s and 1s</param>
        /// <param name="decimalNumber">store the converted decimal number</param>
        private static void ConvertBinaryToDecimal(string binaryString, out int decimalNumber)
        {
            //Variable declaration and initialisation
            decimalNumber = 0; //To store converted decimal number
            int bit; //to store individual bit from right to left while calculating decimal from binary
            int powerCounter = 0; //To manage the exponent of 2
           
            //Convertion of Binary to Decimal
            for (int i = binaryString.Length - 1; i >= 0; i--)
            {
                bit = int.Parse(binaryString[i].ToString());
                decimalNumber += bit * (int)Math.Pow(2, powerCounter++);
            }
        }
        #endregion

        #region Helper Method
        /// <summary>
        /// Prompt user to input decimal number
        /// </summary>
        /// <param name="decimalNumber"></param>
        /// <param name="numberString"></param>
        private static void TakeDecimalInput(out int decimalNumber)
        {
            string numberString;
            bool flag = true; //to display error message while user enters invalid binary/decimal number

            //Take and validate user input
            Console.Write("Enter Decimal Number: ");
            do
            {
                if (!flag) //only execute if user have entered invalid decimal number
                    Console.WriteLine("Please enter a valid decimal number");
                numberString = Console.ReadLine();
                flag = false; //will display error message in every subsequent iteration of this loop (if this loop continuous)
            } while (!int.TryParse(numberString, out decimalNumber));
        }

        #endregion
=======
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
>>>>>>> 323782afd325f0a8daca94052819a2230d5d0aac
    }
}

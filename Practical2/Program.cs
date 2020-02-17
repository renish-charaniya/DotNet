using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name,country,emailAddress,phoneNo; // variable declaration
            
            //name Validation using regular expression
            do {
                Console.Write("Hello my friend ! \nPlease enter the your name : ");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name,"^[a-zA-Z]+$"));

            //country Validation using regular expression
            do{
                Console.Write("Please enter the your country : ");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(country,"^[a-zA-Z]+$"));

            //emailAddress Validation regular expression
            do{
                Console.Write("Please enter the email address : ");
                emailAddress = Console.ReadLine();
            } while (!Regex.IsMatch(emailAddress, "^[a-zA-Z0-9]+[a-zA-Z0-9\\.]*(@gmail|@yahoo|@live)(.com|.net|.ca)$"));
            
            //phoneNo Validation
            do{
                Console.Write("Please enter the phone number : ");
                phoneNo = Console.ReadLine();
            } while (!Regex.IsMatch(phoneNo, "^\\d{10}$"));

            Console.WriteLine();
            Console.WriteLine("Hello "+name+" !!!!!");
            Console.WriteLine("Your are from "+country+",");
            Console.WriteLine("Your email address is "+emailAddress+",");
            Console.WriteLine("and phone number is "+phoneNo+".");
            Console.Read();
        }
    }
}

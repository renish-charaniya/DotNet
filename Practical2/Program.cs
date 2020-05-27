<<<<<<< HEAD
﻿/* Practical 2
 * Write C# code to prompt a user to input his/her name and country name 
 * and then the output will be shown as an example below: 
 * Hello Ram from country India!
 */
using System;
using System.Text.RegularExpressions;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

>>>>>>> 323782afd325f0a8daca94052819a2230d5d0aac
namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            string name, country;
            do
            {
                Console.WriteLine("Hello! Whats your name?");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name,@"^[a-zA-Z]+$"));
            do
            {
                Console.WriteLine("Where are you from?");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(country,@"^[a-zA-Z]+$"));

            Console.WriteLine($"Hello {name} from country {country}");
=======
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
>>>>>>> 323782afd325f0a8daca94052819a2230d5d0aac
            Console.Read();
        }
    }
}

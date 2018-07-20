using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "John";      //the firstname string has the value of "John"
            string lastname = "Doe";        //the lastname string has the value of "doe"
            Console.WriteLine("Name: " + firstname + " " + lastname);       //the line is written to the console that prints "name", the firstname string and the lastname string
            Console.WriteLine("Please enter a new first name:");        //the line is written to the console that asks the user for a new first name 
            firstname = Console.ReadLine();     //whatever the user types into the console will be stored in the firstname string, overwriting the original (given that there is one)
            Console.WriteLine("Please enter a new last name:");
            lastname = Console.ReadLine();
            Console.WriteLine("New name: " + firstname + " " + lastname);       //the line is written to the console that states the new first name with the original second name
            Console.ReadLine();
        }
    }
}

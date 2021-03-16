// HOMEWORK - 11 - Mini-Project - Extension Methods 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        // First part
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "What is your first name: ".RequestString();
             person.LastName = "What is your last name: ".RequestString();

            // Two different ways to display info for person.Age
            person.Age = "What is your age: ".RequestInt(0, 100);
            person.Age = ConsoleHelper.RequestInt("Please enter your age again: ", 0, 120);

            // Two different ways to display info for person.Children
            person.Children = "How many children do you have? ".RequestInt(0, 9);
            person.Children = ConsoleHelper.RequestInt("Please enter number of children again: ", 0, 10);

            Console.ReadLine();
        }
    }
}

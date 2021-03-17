// Object Oriented Programming - part 2 - Generics 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
	partial class Program
    {
        static void Main(string[] args)
        {
            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "Josh", HasError = true });

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine($"{ item.FirstName } { item.LastName } was rejected.");
            }

            Console.ReadLine();
        }
    }
}



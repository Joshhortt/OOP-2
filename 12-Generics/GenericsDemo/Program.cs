// Object Oriented Programming - part 2 - Generics 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
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


        public class GenericHelper<T> where T : IErrorCheck
        {
            public List<T> Items { get; set; } = new List<T>();
            public List<T> RejectedItems { get; set; } = new List<T>();

            public void CheckItemAndAdd(T item)
            {
                if (item.HasError == false)
                {
                    Items.Add(item);
                }
                else
                {
                    RejectedItems.Add(item);
                }
            }
        }

        public interface IErrorCheck
        {
            bool HasError { get; set; }
        }

        public class CarModel : IErrorCheck
        {
            public string Manufacturer { get; set; }
            public int YearManufactured { get; set; }
            public bool HasError { get; set; }
        }

        public class PersonModel : IErrorCheck
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public bool HasError { get; set; }
        }
    }
}



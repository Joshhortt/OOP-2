// Object Oriented Programming - part 2 - Generics 

namespace GenericsDemo
{
	partial class Program
    {
		public class CarModel : IErrorCheck
        {
            public string Manufacturer { get; set; }
            public int YearManufactured { get; set; }
            public bool HasError { get; set; }
        }
    }
}



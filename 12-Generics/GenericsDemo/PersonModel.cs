// Object Oriented Programming - part 2 - Generics 

namespace GenericsDemo
{
	partial class Program
    {
		public class PersonModel : IErrorCheck
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public bool HasError { get; set; }
        }
    }
}



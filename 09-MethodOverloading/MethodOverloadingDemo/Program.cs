// Object Oriented Programming - part 2 - Method Overloading
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var person = new PersonModel("Josh","Hortt");  // 14. 

			//person.GenerateEmail("gmail.com", false);  // 26.
			person.GenerateEmail();  // 33.

			Console.WriteLine(person.Email);  // 27.

			Console.ReadLine();  // 1.
		}
	}

	public class PersonModel  // 2.
	{ 
	public string FirstName { get; set; }  // 3.

	public string LastName { get; set; }  // 4.

	public string Email { get; set; }  // 5.

	public PersonModel()  // 6.  Constructor( 3 methods *** with the same name, unless ther is one that has different signature line)
	{
		// Constructor 
	}

	//--- > 1+ Overloading
	public PersonModel(string firstName, string lastName, string email)  // 7. ( *** )
	{
		FirstName = firstName;  // 8.
		LastName = lastName;  // 9.
		Email = email;  // 10.
	}

	// --- > 2+ Overloading
	public PersonModel(string firstName, string lastName)  // 11. ( *** )
		{
			FirstName = firstName;  // 12.
			LastName = lastName;  // 13.
			
		}

		public void GenerateEmail()  // 15.
		{
			//Email = $"{FirstName}.{LastName}@aol.com";  // 16.  // 27.
			GenerateEmail("aol.com", false);    // 28. refactor, because of too much repetition
		}
		public void GenerateEmail(string domain)  // 17.
		{
			//Email = $"{ FirstName }.{ LastName }@{ domain }";  // 18.  // 29.
			GenerateEmail(domain, false);  // 30.   refactor, because of too much repetition
		}

		public void GenerateEmail(bool firstInitialMethod)  // 19.
		{
			GenerateEmail("aol.com", false);   // 32.  refactor, because of too much repetition

			//if (firstInitialMethod == true)  // 20.   // 31. comment block
			//{
			//	Email = $"{ FirstName.Substring(0,1) }{ LastName }@aol.com";  // 20.b
			//}
			//else
			//{
			//	Email = $"{ FirstName }.{ LastName }@aol.com";  // 21.
			//}
		}

		public void GenerateEmail(string domain, bool firstInitialMethod)  // 22.
		{
			if (firstInitialMethod == true)  // 23.
			{
				Email = $"{ FirstName.Substring(0, 1) }{ LastName }@{ domain }";  // 24.
			}
			else
			{
				Email = $"{ FirstName }.{ LastName }@{ domain }";  // 25.
			}
		}
	}
}

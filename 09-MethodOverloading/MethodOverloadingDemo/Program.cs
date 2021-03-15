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
			var person = new PersonModel("Josh","Hortt");

			person.GenerateEmail();  

			Console.WriteLine(person.Email); 

			Console.ReadLine(); 
		}
	}

	public class PersonModel  
	{ 
	public string FirstName { get; set; }  

	public string LastName { get; set; }  

	public string Email { get; set; } 

	public PersonModel()  
	{
		
	}

	public PersonModel(string firstName, string lastName, string email) 
	{
		FirstName = firstName;  
		LastName = lastName; 
		Email = email; 
	}

	
	public PersonModel(string firstName, string lastName) 
		{
			FirstName = firstName; 
			LastName = lastName;  
		}

		public void GenerateEmail() 
		{
			GenerateEmail("aol.com", false);    
		}
		public void GenerateEmail(string domain) 
		{
			GenerateEmail(domain, false);  
		}

		public void GenerateEmail(bool firstInitialMethod)  
		{
			GenerateEmail("aol.com", false);   
		}

		public void GenerateEmail(string domain, bool firstInitialMethod) 
		{
			if (firstInitialMethod == true) 
			{
				Email = $"{ FirstName.Substring(0, 1) }{ LastName }@{ domain }";  
			}
			else
			{
				Email = $"{ FirstName }.{ LastName }@{ domain }"; 
			}
		}
	}
}

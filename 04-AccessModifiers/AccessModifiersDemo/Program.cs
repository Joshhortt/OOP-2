// Object Oriented Programming - part 2 - Access Modifiers
// public, private, protected, internal, private protected , protected internal.
using DemoLibrary;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

namespace AccessModifiersDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person(); 

			person.SavePerson(); 

			Console.ReadLine();  
		}
	}

	public class ModifiedDataAccess : DataAccess  
	{
		public void GetUnsecureConnectionInfo()  
		{
			GetConnectionString(); 
		}
	}
	
	public class CEO : Manager 
	{
		public void GetConnectionInfo()  
		{
			ModifiedDataAccess data = new ModifiedDataAccess();   
			data.GetUnsecureConnectionInfo();   
			formerLastName = "test";  
		}
	}
}

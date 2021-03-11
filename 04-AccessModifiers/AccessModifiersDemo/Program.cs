// Object Oriented Programming - part 2 - Access Modifiers
// public, private, protected, internal, private protected , protected internal
using DemoLibrary;  // 2.
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
			Person person = new Person();  // 1. 

			// DataAccess data = new DataAccess();  // 29. ;  35. it get's inaccessible after changing the access modifier of DataAccess to 'internal'.
																// Why is that ? Internal means anything in the sema assembly .
																// 'AccessModifiersDemo' is 1 Assembly. 'DemoLibrary' is another Assembly.

			person.SavePerson();  // 33.

			Console.ReadLine();  // 0.
		}
	}

	public class ModifiedDataAccess : DataAccess  // 42.
	{
		public void GetUnsecureConnectionInfo()  // 43.
		{
			GetConnectionString();  // 44. 
		}
	}
	
	public class CEO : Manager  // 36. 
	{
		public void GetConnectionInfo()  //  37. 
		{
			//DataAccess data = new DataAccess();  // 38. it still inaccessible after changing the access modifier of DataAccess to 'internal', even
												 // if CEO inherits it's members from class Manager. Different Assembly.
												 // 39. Note that formerLastName isprotected but accessible.  45. comment DataAccess data
			ModifiedDataAccess data = new ModifiedDataAccess();   // 46. 
			data.GetUnsecureConnectionInfo();   // 47.
			// formerLastName = "test";   // 48.;   51. No more access to that after changing protected to private protected. (Different Assembly).
		}
	}
}

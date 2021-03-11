using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public class DataAccess  // 26. ; 40. (redo to public for sequence purpose)

	// internal class DataAccess  // 34. access modifier 'internal'.

	{
		//public string GetConnectionString()  // 27. 
		protected internal string GetConnectionString()   // 41. 
		{
			return "Sensitive data";  // 28.
		}
	}
	public class Person
	{
		protected string formerLastName = "";   // 14. private variable  // 20. changed private to protected.  // 49. comment protected

		//private protected string formerLastName = ""; // 50. private protected

		public string FirstName { get; private set; }  // 3.;   12. private set can only be changed inside the class Person.
													   // but can be read anywher because it's public by default.
		public string LastName { get; private set; }  // 4.;   13. private set can only be changed inside the class Person.
													  // but can be read anywher because it's public by default.


		private string _ssn;  // 5.This private is accessible inside the class Person because it's outside the method public string SSN.

		public string SSN   // 6.
		{
			get
			{
				return $"***-**--{_ssn.Substring(_ssn.Length - 4) }"; // 7.
			}
			set
			{
				_ssn = value; // 8. 
			}
		}

		public void ChangeLastName(string newLastName)  // 11.  Method - Passing in newLastName.
		{
			formerLastName = LastName;  // 15. 
			LastName = newLastName;   // 16.
		}

		public void SayHello()  // 9.
		{
			Console.WriteLine($"Hello { FirstName }");  // 10.
		}
		public void SavePerson()  // 30.
		{
			DataAccess data = new DataAccess();  // 31. 
			string conn = data.GetConnectionString();  // 32. 

			// saves the person
		}
	}

	public class Employee : Person  // 17. class Employee inherits from class Person.
									// Therefore It get's all the protected members as well like methods or variables, too.
	{
		public string GetFormerLastName()  // 18. 
		{
			return formerLastName;  // 19. Does not have access to 'formerLastName', because it's private.
									// 21. Does have acces now because we changed the access modifier for 'formerLastName' to 'protected'.
		}
	}

	public class Manager : Employee  // 22. class Manager inherits from class Employee. Employee inherits from Person.
									 // Therefore have access to all Person's access entities
									
	{
		public string GetAllNames()  // 23. 
		{
			return $"{ FirstName }, { LastName }, { formerLastName }";  // 24. 
									// 25. 
		}
	}
}

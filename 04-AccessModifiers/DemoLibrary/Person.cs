using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public class Person
	{
		public string FirstName { get; set; }  // 1.

		private string _ssn;  // 5.

		public string SSN   // 4.
		{
			get
			{
				return $"***-**--{_ssn.Substring(_ssn.Length - 4) }"; // 6.
			}
			set
			{
				_ssn = value; // 7. 
			}
		}

		public void SayHello()  // 2.
		{
			Console.WriteLine($"Hello { FirstName }");  // 3.
		}
	}
}

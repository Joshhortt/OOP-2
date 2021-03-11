using DemoLibrary;  // 2.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();  // 1. 

			DataAccess data = new DataAccess();  // 29. ;  35. it get's inaccessible after changing the access modigier of DataAccess to 'internal'.
																// Why is that ? Internal means anything in the sema assembly .
																// 'AccessModifiersDemo' is 1 Assembly. 'DemoLibrary' is another Assembly.

			person.SavePerson();  // 33.

			Console.ReadLine();  // 0.
		}
	}
}

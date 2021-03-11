// Object Oriented Programming - part 2 - Method Overriding

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			PersonModel person = new PersonModel  // 6.
			{
				FirstName = "Josh",  // 7.
				LastName = "Hortt",  // 8.
				Email = "joshhortt@yahoo.com"  // 9.
		};

		Console.WriteLine(person);  // 10.

			Console.ReadLine();  // 1. 
		}
	}
	public abstract class Car // 23. Abstract class
	{
		public virtual void StartCar()  // 24. virtual
		{
			Console.WriteLine("Turn on key and start");  // 25.
		}
		// internal abstract void SetClock();  // 26. internal abstract is possible but if you would use Interface, it wouldn't be possible because
												// Interface averything is public.
		public abstract void SetClock();  // 27. 
	}
	public class Corolla : Car  // 28. 
	{
		//internal override void SetClock()  29. -- 26
		public override void SetClock()  // 30
		{
			Console.WriteLine("Fiddle with the Corolla Clock.");  // 31.
		}
	}
	public class Tesla : Car  // 32. 
	{
		public override void StartCar()  // 35. override
		{
			Console.WriteLine("Think about your destination.");  // 36.
		}

		public override void SetClock()  // 33.
		{
			Console.WriteLine("It sets itself.");  // 34.
		}
	}
}

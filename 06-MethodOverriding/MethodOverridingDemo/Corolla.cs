// Object Oriented Programming - part 2 - Method Overriding

using System;

namespace MethodOverridingDemo
{
	public class Corolla : Car 
	{
		public override void SetClock() 
		{
			Console.WriteLine("Fiddle with the Corolla Clock."); 
		}
	}
}

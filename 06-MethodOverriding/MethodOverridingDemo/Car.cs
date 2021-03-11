// Object Oriented Programming - part 2 - Method Overriding

using System;

namespace MethodOverridingDemo
{
	public abstract class Car
	{
		public virtual void StartCar() 
		{
			Console.WriteLine("Turn on key and start"); 
		}
		public abstract void SetClock(); 
	}
}

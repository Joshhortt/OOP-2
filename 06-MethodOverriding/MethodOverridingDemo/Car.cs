// Object Oriented Programming - part 2 - Method Overriding

using System;

namespace MethodOverridingDemo
{
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
}

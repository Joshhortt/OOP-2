// Object Oriented Programming - part 2 - Method Overriding

using System;

namespace MethodOverridingDemo
{
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

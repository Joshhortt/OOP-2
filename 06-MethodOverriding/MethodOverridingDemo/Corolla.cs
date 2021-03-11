// Object Oriented Programming - part 2 - Method Overriding

using System;

namespace MethodOverridingDemo
{
	public class Corolla : Car  // 28. 
	{
		//internal override void SetClock()  29. -- 26
		public override void SetClock()  // 30
		{
			Console.WriteLine("Fiddle with the Corolla Clock.");  // 31.
		}
	}
}

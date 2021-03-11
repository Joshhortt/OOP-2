// Object Oriented Programming - part 2 - Method Overriding

namespace MethodOverridingDemo
{
	public class EmployeeModel : PersonModel // 14.
	{
		public decimal HourlyRate { get; set; }  // 15.

		public virtual decimal GetPaychekAmount(int hoursWorked)  // 16. method virtual
		{
			return HourlyRate = hoursWorked;  // 17.
		}
	}
}

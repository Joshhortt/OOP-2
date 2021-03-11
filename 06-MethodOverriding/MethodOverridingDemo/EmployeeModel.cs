// Object Oriented Programming - part 2 - Method Overriding

namespace MethodOverridingDemo
{
	public class EmployeeModel : PersonModel
	{
		public decimal HourlyRate { get; set; }

		public virtual decimal GetPaychekAmount(int hoursWorked) 
		{
			return HourlyRate = hoursWorked;
		}
	}
}

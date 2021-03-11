// Object Oriented Programming - part 2 - Method Overriding

namespace MethodOverridingDemo
{
	public class ComissionEmplyeeModel : EmployeeModel  // 18.
	{
		public decimal ComissionAmount { get; set; }  // 19.

		public override decimal GetPaychekAmount(int hoursWorked)  // 20. method override
		{
			decimal initialPay = base.GetPaychekAmount(hoursWorked);  // 22.
			return base.GetPaychekAmount(hoursWorked);  // 21.
		}
	}
}

// Object Oriented Programming - part 2 - Method Overriding

namespace MethodOverridingDemo
{
	public class ComissionEmployeeModel : EmployeeModel
	{
		public decimal ComissionAmount { get; set; }

		public override decimal GetPaychekAmount(int hoursWorked) 
		{
			decimal initialPay = base.GetPaychekAmount(hoursWorked);
			return base.GetPaychekAmount(hoursWorked); 
		}
	}
}

// Object Oriented Programming - part 2 - Method Overriding

namespace MethodOverridingDemo
{
	public class PersonModel  // 2.
	{
		public string FirstName { get; set; }  // 3.
		public string LastName { get; set; }  // 4.
		public string Email{ get; set; }  // 5.

		public override string ToString()  // 11. Add method override
		{
			//return base.ToString();  // 12. Add ToString option
			return $"{FirstName} {LastName}";  // 13. Now it does something diffrent
		}
	}
}

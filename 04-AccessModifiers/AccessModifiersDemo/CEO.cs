// Object Oriented Programming - part 2 - Access Modifiers
// public, private, protected, internal, private protected , protected internal.
using DemoLibrary;

//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

namespace AccessModifiersDemo
{
	public class CEO : Manager 
	{
		public void GetConnectionInfo()  
		{
			ModifiedDataAccess data = new ModifiedDataAccess();   
			data.GetUnsecureConnectionInfo();   
			formerLastName = "test";  
		}
	}
}

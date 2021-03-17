// Object Oriented Programming - part 2 - Generics 

using System.Collections.Generic;

namespace GenericsDemo
{
	partial class Program
    {
		public class GenericHelper<T> where T : IErrorCheck
        {
            public List<T> Items { get; set; } = new List<T>();
            public List<T> RejectedItems { get; set; } = new List<T>();

            public void CheckItemAndAdd(T item)
            {
                if (item.HasError == false)
                {
                    Items.Add(item);
                }
                else
                {
                    RejectedItems.Add(item);
                }
            }
        }
    }
}



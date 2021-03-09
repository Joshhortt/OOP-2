using System;

namespace InheritanceMiniProject
{
    public class BookModel : InventoryItemModel  // 3. Add inheritance
    {
        public int NumberOfPages { get; set; }  // 2. Add property
    }
}

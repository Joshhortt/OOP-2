namespace InheritanceMiniProject
{
    public class InventoryItemModel : IInventoryItem  //  58. add Interface inheritance
    {
        public string ProductName { get; set; }  // 1. Add property
        public int QuantityInStock { get; set; }  // 12. Add property
    }
}

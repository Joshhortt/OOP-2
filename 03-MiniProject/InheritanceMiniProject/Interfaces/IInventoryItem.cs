namespace InheritanceMiniProject
{
    public interface IInventoryItem
    {
        string ProductName { get; set; }  // 56. add property from 1. in InventoryItemModel and take out public 
        int QuantityInStock { get; set; }  // 57. add property from 12. in InventoryItemModel and take out public 
    }
}



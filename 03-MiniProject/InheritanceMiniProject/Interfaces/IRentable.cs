namespace InheritanceMiniProject
{
    public interface IRentable : IInventoryItem  //  59. add Interface inheritance
    {
        void Rent();  // 13. Add method
        void ReturnRental();  // 14. Add method
    }
}

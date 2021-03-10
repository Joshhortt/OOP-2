namespace InheritanceMiniProject
{
    // Inheritance
    public interface IRentable : IInventoryItem  
    {
        // methods
        void Rent();  
        void ReturnRental();  
    }
}

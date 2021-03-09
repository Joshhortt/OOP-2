// // Object Oriented Programming - part 2 - Mini-Project - Interfaces and Inheritance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<InventoryItemModel> inventory = new List<InventoryItemModel>();   // 6. Add List
            inventory.Add(new VehicleModel { DealerFee = 25, ProductName = "Toyota Carisma" });  // 7. Add a Inventory piece-Vehicle
            inventory.Add(new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 });  // 8. Add another piece to Inventory-Book

            Console.ReadLine();   // 0. Add
        }
    }
}

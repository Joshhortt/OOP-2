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
            // List<InventoryItemModel> inventory = new List<InventoryItemModel>();   // 6. Add List 
            // 44. Comment List created in the beginning
            List<IRentable> rentables = new List<IRentable>();   // 42. Add List
            List<IPurchasable> purchasables = new List<IPurchasable>();   // 43. Add List

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Toyota Carisma" };  // 44. add variable ne Instance
            var book = new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 };  // 45. add variable ne Instance
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };  // 46. add variable ne Instance

            rentables.Add(vehicle);  // 47. Add vehicle
            rentables.Add(excavator); // 48. Add excavator

            // rentables.Add(book);  Can not add book because it 's not rentable only purchasble

            purchasables.Add(book); // 49. Add book
            purchasables.Add(vehicle); // 50. Add vehicle

            Console.Write("Do you want to rent or purchase something: (rent, purchase) ");  // 51. add message
            string rentalDecision = Console.ReadLine();  // 52.prompt user for a decision

            if (rentalDecision.ToLower() == "rent")   // 53. if decision is 'rent'
            {
                foreach (var item in rentables)  // 54. forach loop
                {
                    Console.WriteLine($"Item: { item.ProductName }");  // 55. Add IRentable item property (implement also steps 56-60) to make it work
                    Console.Write("Do you want to rent this item (yes/no): ");  // 61. add message to user if want's to rent
                    string wantToRent = Console.ReadLine();  // 62. prompt user for answer yer or no

                    if (wantToRent.ToLower() == "yes")  // 63. If yes then ...
                    {
                        item.Rent();  // 64. call that method
                    }

                    Console.Write("Do you want to return this item (yes/no): ");  // 65. add message to user if want's to return rental
                    string wantToReturn = Console.ReadLine();  // 66. prompt user for answer yer or no

                    if (wantToReturn.ToLower() == "yes")  // 67. If yes then ...
                    {
                        item.ReturnRental();  // 68. call that method
                    }
                }
            }
            else  // 69. Add else statement
            {
                foreach (var item in purchasables)  // 70.forach loop
                {
                    Console.WriteLine($"Item: { item.ProductName }");  // 71. Add IPurchasable item property 
                    Console.Write("Do you want to purchase this item (yes/no): ");  // 72. add message to user if want's to purchase
                    string wantToPurchase = Console.ReadLine();  // 73. prompt user for answer yer or no

                    if (wantToPurchase.ToLower() == "yes")  // 74. If yes then ...
                    {
                        item.Purchase();  // 75. call that method
                    }
                }
            }
                Console.WriteLine("We are done");  // 76. Just a messaga saying that we are done!

            //inventory.Add(new VehicleModel { DealerFee = 25, ProductName = "Toyota Carisma" });  // 7. Add a Inventory piece-Vehicle
            //inventory.Add(new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 });  // 8. Add another piece to Inventory-Book
            // 47. Comment or delete 8.

            Console.ReadLine();   // 0. Add
        }
    }
}
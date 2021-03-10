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
            //Lists Interfaces
            List<IRentable> rentables = new List<IRentable>();  
            List<IPurchasable> purchasables = new List<IPurchasable>();   

            // variables / new Instances
            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Toyota Carisma" }; 
            var book = new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 }; 
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };  

            // rentables variables
            rentables.Add(vehicle); 
            rentables.Add(excavator);

            // purchasables variables
            purchasables.Add(book); 
            purchasables.Add(vehicle);

            // Beginnining ELSE
            // Condition rentables - rent
            Console.Write("Do you want to rent or purchase something: (rent, purchase) ");  
            string rentalDecision = Console.ReadLine();  
            if (rentalDecision.ToLower() == "rent")   
            {
                foreach (var item in rentables)  
                {
                    Console.WriteLine($"Item: { item.ProductName }");  
                    Console.Write("Do you want to rent this item (yes/no): ");  
                    string wantToRent = Console.ReadLine();  

                    if (wantToRent.ToLower() == "yes") 
                    {
                        item.Rent();  
                    }

                    // Condition rentables - return
                    Console.Write("Do you want to return this item (yes/no): ");  
                    string wantToReturn = Console.ReadLine();
            
                    if (wantToReturn.ToLower() == "yes")  
                    {
                        item.ReturnRental();  
                    }
                }
            }
            // Beginnining ELSE
            else  
            {
                // Condition Purchasables - purchase
                foreach (var item in purchasables)  
                {
                    Console.WriteLine($"Item: { item.ProductName }");  
                    Console.Write("Do you want to purchase this item (yes/no): ");  
                    string wantToPurchase = Console.ReadLine();  

                    if (wantToPurchase.ToLower() == "yes")  
                    {
                        item.Purchase();  
                    }
                }
            }
                Console.WriteLine("We are done"); 

            Console.ReadLine();  
        }
    }
}
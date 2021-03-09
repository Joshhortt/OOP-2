// Object Oriented Programming - part 2 - Interfaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    // Interface is a contract
    // Classes implement interfaces

    class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();  // new Instance
            GameController gameController = new GameController();  // new Instance
            BatteryPoweredGameController battery = new BatteryPoweredGameController();  // new Instance
            BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();  // new Instance

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(battery);

            foreach (IComputerController controller in controllers)  // foreach loop
            {
                if (controller is GameController gc)
                {
                  //  
                }

                if (controller is IBatteryPowered powered)
                {
                   // 
                }
            }

            List<IBatteryPowered> powereds = new List<IBatteryPowered>();

            powereds.Add(battery);
            powereds.Add(batteryKeyboard);

            Console.ReadLine();
        }
    }
}

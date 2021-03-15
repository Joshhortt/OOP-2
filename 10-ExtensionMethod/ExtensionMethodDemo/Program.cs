using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelRoomModel room = new HotelRoomModel();  // 24.

            room.TurnOnAir().SetTemperature(32).OpenShades();  // 25. three extensions

            room.TurnOffAir().CloseShades();  // 26.  two extension

            "Extension Method".PrintToConsole();  // 1.
            Console.ReadLine();  // 0.
        }
    }

    public class HotelRoomModel  // 2. class
    {
        public int Temperature { get; set; }   // 3. prop
        public bool IsAirRunning { get; set; }  // 4. prop 
        public bool AreShadesOpen { get; set; }  // 5. prop
    }

    public static class ExtensionSamples  // 6.  class
    {
        public static void PrintToConsole(this string message)  // 7. Extension Method with 'this' keyword
        {
            Console.WriteLine(message);  // 8.
        }

        public static HotelRoomModel TurnOnAir(this HotelRoomModel room)  // 9.  Extension Method with 'this' keyword
        {
            room.IsAirRunning = true;  // 10. set to true 
            return room;  // 11. 
        }

        public static HotelRoomModel TurnOffAir(this HotelRoomModel room)  // 21. Extension Method with 'this' keyword
        {
            room.IsAirRunning = false;  // 22. set to false
            return room;  // 23.
        }

        public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)  //12. Extension Method with 'this' keyword
        {
            room.Temperature = temperature;  // 13.
            return room;  // 14. 
        }

        public static HotelRoomModel OpenShades(this HotelRoomModel room)  // 15. Extension Method with 'this' keyword
        {
            room.AreShadesOpen = true;  // 16. set to true
            return room;  // 17.
        }

        public static HotelRoomModel CloseShades(this HotelRoomModel room)  // 18. Extension Method with 'this' keyword
        {
            room.AreShadesOpen = false;  // 19. set to false
            return room;  // 20.
        }
    }
}

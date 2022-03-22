using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Taxi
            Taxi taxi = new Taxi();

            // Pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // Pengambilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}

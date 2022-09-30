using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            IPassengerCarrier suv = new SUV();

            AddPassenger(ref suv);
        }

        static void AddPassenger(ref IPassengerCarrier vehicleObject)
        {
            vehicleObject.LoadPassenger();
            Console.WriteLine(vehicleObject.ToString());
        }
    }
}

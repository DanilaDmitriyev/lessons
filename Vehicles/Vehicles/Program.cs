using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle bicycle = new Bicycle();
            GroundVehicle bicycle2 = new Bicycle();
            IMusculeVehicle bicycle3 = new Bicycle();
            Bicycle bicycle4 = new Bicycle();
            bicycle4.MaxSpeed = 40;
            bicycle2.MaxSpeed = 40;
            bicycle.MaxSpeed = 40;
            Boat MyBoat = new Boat();
            MyBoat.Displacement = 1200;
            bicycle2.NumberWheels = 2;
        }
    }
}

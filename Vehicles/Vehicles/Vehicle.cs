using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    abstract class Vehicle
    {
    }
    abstract class GroundVehicle : Vehicle
    {

    }
    abstract class SeaVehicle : Vehicle
    {

    }
    abstract class AirVehicle : Vehicle
    {

    }
    class Car : GroundVehicle, IMotorVehicle
    {

    }
    class Bicycle : GroundVehicle, IMusculeVehicle
    {

    }
    class MotorBoat : SeaVehicle, IMotorVehicle
    {

    }
    class Boat : SeaVehicle, IMusculeVehicle
    {

    }
    class Airplane : AirVehicle, IMotorVehicle
    {

    }
    class Deltaplane: AirVehicle, IMusculeVehicle
    {

    }
    interface IMotorVehicle
    {

    }
    interface IMusculeVehicle
    {

    }
}

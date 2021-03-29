using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    abstract class Vehicle
    {
        public virtual double MaxSpeed { get; set; }
    }
    abstract class GroundVehicle : Vehicle
    {
        public int NumberWheels { get; set; }
    }
    abstract class SeaVehicle : Vehicle
    {
        public double Displacement { get; set; }
    }
    abstract class AirVehicle : Vehicle
    {

    }
    class Car : GroundVehicle, IMotorVehicle
    {

    }
    class Bicycle : GroundVehicle, IMusculeVehicle
    {
        public double RiderPower { get; set; }
        public override double MaxSpeed { get => RiderPower*0.4 ; set => RiderPower = value/0.4; }
    }
    class MotorBoat : SeaVehicle, IMotorVehicle
    {

    }
    class Boat : SeaVehicle, IMusculeVehicle
    {
        public double RiderPower { get; set; }
    }
    class Airplane : AirVehicle, IMotorVehicle
    {

    }
    class Deltaplane: AirVehicle, IMusculeVehicle
    {
        public double RiderPower { get; set; }
    }
    interface IMotorVehicle
    {

    }
    interface IMusculeVehicle
    {
        double RiderPower { get; set; }
    }
}

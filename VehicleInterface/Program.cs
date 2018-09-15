using System;
using System.Collections.Generic;
using VehicleInterface.AirBased;
using VehicleInterface.LandBased;
using VehicleInterface.WaterBased;

namespace VehicleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane = new Boeing747();
            var wingSuit = new WingSuit();
            var AirVehicles = new List<IVehicle> {plane, wingSuit};
            foreach (var item in AirVehicles)
            {
                item.Fly();
            }

            var jeep = new JeepWrangler();
            var limo = new Limo();
            var landVehicles = new List<IVehicle> {jeep, limo};
            foreach (var item in landVehicles)
            {
                item.Drive();
            }

            var seadoo = new Seadoo();
            var yachty = new Yachty();
            var waterVehicles = new List<IVehicle> { seadoo, yachty};
            foreach (var item in waterVehicles)
            {
                item.Drive();
            }

            Console.Read();
            Console.WriteLine("Hello World!");
        }
    }
}

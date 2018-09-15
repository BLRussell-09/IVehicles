using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterface.WaterBased
{
    class Yachty : WaterBase, IVehicle
    {

        public override string Name { get; set; } = "Lil Yachty";
        public override double MaxWaterSpeed { get; set; } = 70;
        public override int PassengerCapacity { get; set; } = 40;

    }
}

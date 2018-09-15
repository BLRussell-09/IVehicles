using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterface.WaterBased
{
    class Seadoo : WaterBase, IVehicle
    {
        public override string Name { get; set;} = "Seadoo";
        public override int PassengerCapacity { get ; set; } = 1;
    }
}

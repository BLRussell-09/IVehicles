using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterface.LandBased
{
    class JeepWrangler : LandBase, IVehicle
    {
        public override string Name { get; set; } = "Jeep Wrangler";
    }
}

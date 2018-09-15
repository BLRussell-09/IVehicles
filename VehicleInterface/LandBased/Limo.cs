using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterface.LandBased
{
    class Limo : LandBase, IVehicle
    {
        public override string Name { get; set;} = "Brabus Maybach";
        public override double MaxLandSpeed { get; set ; } = 217;
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterface.AirBased
{
    class WingSuit : IVehicle
    {
        public int Doors { get; set; } = 0;
        public double EngineVolume { get; set; } = 6;
        public double MaxAirSpeed { get; set; } = 396;
        public double MaxLandSpeed { get; set; } = 25;
        public double MaxWaterSpeed { get; set; } = 3;
        public string Name { get; set; } = "Man in wingsuit";
        public int PassengerCapacity { get; set; } = 1;
        public int Wheels { get; set; } = 0;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "Man-Powered";

        public virtual void Drive()
        {
          throw new NotImplementedException();
        }
        public virtual void Fly()
        {
          Console.WriteLine($"The {Name}, glides blissfully through the sky while dodging rancid clumps of bird sh*t");
        }
        public virtual void Start()
        {
          Console.WriteLine($"The {Name} jumps from great heights and begins to glide.");
        }
        public virtual void Stop()
        {
          Console.WriteLine($"The {Name} lands with unbroken legs.");
        }
    }
}

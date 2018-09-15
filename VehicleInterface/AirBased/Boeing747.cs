using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterface.AirBased
{
    class Boeing747 : IVehicle
    {
        public int Doors { get; set;} = 6;
        public double EngineVolume { get; set;} = 12;
        public double MaxAirSpeed { get; set;} = 614;
        public double MaxLandSpeed { get; set; } = 184;
        public double MaxWaterSpeed { get; set; } = 0;
        public string Name { get; set;} = "Boeing 747-100";
        public int PassengerCapacity { get; set; } = 366;
        public int Wheels { get; set; } = 10;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set;} = "The big-ass plane kind?";

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
          Console.WriteLine($"The engines whir and come to life at a deafening {EngineVolume}db's.");
        }
        public virtual void Stop()
        {
          Console.WriteLine($"As the {Name} lands, it's {Wheels} wheels skid to a halt and as the engines silence, the pilot exits");
        }
    }
}

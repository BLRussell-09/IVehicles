using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterface.WaterBased
{
    abstract class WaterBase : IVehicle
    {
        public virtual int Doors { get; set; } = 0;
        public virtual double EngineVolume { get; set; } = 6;
        public virtual double MaxAirSpeed { get; set; } = 0;
        public virtual double MaxLandSpeed { get; set; } = 0;
        public virtual double MaxWaterSpeed { get; set; } = 12;
        public abstract string Name { get; set; }
        public abstract int PassengerCapacity { get; set; }
        public virtual int Wheels { get; set; } = 0;
        public virtual bool Winged { get; set; } = false;
        public virtual string TransmissionType { get; set; } = "Automatic";

        public virtual void Drive()
        {
          Console.WriteLine($"The {Name} rides the surf at {MaxWaterSpeed} knots");
        }
        public virtual void Fly()
        {
          throw new NotImplementedException();
        }
        public virtual void Start()
        {
          Console.WriteLine($"The {Name}'s {TransmissionType} engine sputters to life and the water begins to boil.");
        }
        public virtual void Stop()
        {
          Console.WriteLine($"The {Name} crashes into the rocks after the pilot goes overboard.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterface.LandBased
{
    abstract class LandBase : IVehicle
    {
        public virtual int Doors { get; set; } = 4;
        public virtual double EngineVolume { get; set; } = 6;
        public virtual double MaxAirSpeed { get; set; } = 0;
        public virtual double MaxLandSpeed { get; set; } = 225;
        public virtual double MaxWaterSpeed { get; set; } = 0;
        public abstract string Name { get; set; }
        public virtual int PassengerCapacity { get; set; } = 5;
        public virtual int Wheels { get; set; } = 4;
        public virtual bool Winged { get; set; } = false;
        public virtual string TransmissionType { get; set; } = "Manual";

        public virtual void Drive()
        {
          Console.WriteLine($"The {Name} whizzes down the road at {MaxLandSpeed} mph");
        }
        public virtual void Fly()
        {
          throw new NotImplementedException();
        }
        public virtual void Start()
        {
          Console.WriteLine($"The {Name}'s {TransmissionType} engine roars to life and settles into a bone-chilling purr.");
        }
        public virtual void Stop()
        {
          Console.WriteLine($"The {Name} smashes into the railing. Shoulda worn a seatbelt.");
        }
    }
}

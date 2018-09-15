using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterface.AirBased
{
    abstract class AirBase : IVehicle
    {
        public abstract int Doors { get; set;}
        public abstract double EngineVolume { get; set;}
        public abstract double MaxAirSpeed { get; set;}
        public virtual double MaxLandSpeed { get; set;} = 184;
        public virtual double MaxWaterSpeed { get; set;} = 0;
        public abstract string Name { get; set;}
        public abstract int PassengerCapacity { get; set;}
        public abstract int Wheels { get; set;}
        public abstract bool Winged { get; set;}
        public abstract string TransmissionType { get; set;}

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

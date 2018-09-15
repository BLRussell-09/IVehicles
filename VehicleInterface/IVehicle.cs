using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterface
{
    interface IVehicle
    {
        int Doors { get; }
        double EngineVolume { get;}
        double MaxAirSpeed { get;}
        double MaxLandSpeed { get;}
        double MaxWaterSpeed { get;}
        int PassengerCapacity { get;}
        int Wheels { get;}
        bool Winged { get;}
        string TransmissionType { get;}

        void Drive();
        void Fly();
        void Start();
        void Stop();
    }
}

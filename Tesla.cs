using System;

namespace Garage
{
    public class Tesla : IElectricVehicles, IVehicle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public string Engine { get; set; }
        public string Name { get; set; }

        public int PassengerLimit { get; set; }

        public void Move() { }
        public void Accelerate() { }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public Tesla()
        {
            CurrentChargePercentage = 10;
            Name = "Tesla";
        }

    }
}
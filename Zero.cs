using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public Zero()
        {
            MainColor = "Midnight Blue";
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you! Yeeeeeow!");
        }
    }
}
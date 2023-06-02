using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public Ram()
        {
            MainColor = "Silver";
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you. Rrrrrumble!");
        }
    }
}
using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public Tesla()
        {
            MainColor = "Burgundy";
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you! MMmmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a {direction}! MMmmmmm!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops.");
        }
    }
}
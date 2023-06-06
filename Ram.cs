
namespace Garage
{
    public class Ram : IGasVehicles
    {
        public double BatteryKWh { get; set; }
        public string Name { get; set; }

        public int CurrentTankPercentage { get; set; }
        public string Engine { get; set; }

        public int PassengerLimit { get; set; }

        public void Move() { }
        public void Accelerate() { }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public Ram()
        {
            CurrentTankPercentage = 25;
            Name = "Ram";
        }

    }
}
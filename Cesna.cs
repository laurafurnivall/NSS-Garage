
namespace Garage
{
    public class Cessna : IGasVehicles
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public string Name { get; set; }
        public string Engine { get; set; }

        public int PassengerLimit { get; set; }

        public void Move() { }
        public void Accelerate() { }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public Cessna()
        {
            CurrentTankPercentage = 30;
            Name = "Cessna";
        }

    }
}
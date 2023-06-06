namespace Garage
{
    public interface IGasVehicles
    {
        void RefuelTank();
        int CurrentTankPercentage { get; }
    }
}
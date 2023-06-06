namespace Garage
{
    public interface IElectricVehicles
    {
        void ChargeBattery();
        int CurrentChargePercentage { get; }
    }
}
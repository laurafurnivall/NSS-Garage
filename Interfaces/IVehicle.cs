namespace Garage
{
    public interface IVehicle
    {
        string Name { get; }
        string Engine { get; }
        int PassengerLimit { get; }
        void Move();
        void Accelerate();
    }
}
namespace Garage
{
    public interface IGasVehicles
    {
        int CurrentTankPercentage { get; set; }
        double FuelCapacity { get; set; }
        void RefuelTank();
    }
}
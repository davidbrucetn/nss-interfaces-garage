using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicles // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            Console.WriteLine($"The {MainColor} Cessna is now full.");
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies over - Chitty bang-bang Chitty-chitty bang-bang!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the Cessna, banks {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name}, the Cessna, lands and rolls to stop on the runway.");
        }
    }
}
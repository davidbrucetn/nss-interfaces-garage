using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicles // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"The {MainColor} Ram is now full.");
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives by - Bwwob bwwwobbubwub");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the Ram, turns noisily {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name}, the Ram, reluctantly slows and comes to a stop at the Tractor Supply store.");
        }
    }
}
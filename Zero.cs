using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle 
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"The {MainColor} Zero electric motorcycle is now charged.");
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero whizzes by - Whoooosh!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the Zero, leans {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name}, the Zero, pops a wheely then returns to the ground and slides to a stop.");
        }
    }
}
using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"The {MainColor} Tesla is now charged.");
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives by - Whmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the Tesla, turns quietly {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"{Name}, the Tesla, pulls into the Neiman Marcus parking lot to a silent stop.");
        }
    }
}
using System;

namespace Garage
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle turns {direction}.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gradully slows to a stop.");
        }
    }
}
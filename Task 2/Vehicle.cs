using System;

namespace DotNetAssignment
{
    // Base class
    public class Vehicle
    {
        // Properties
        public string Brand { get; set; }
        public double Speed { get; set; }

        // Methods
        public void Start()
        {
            Console.WriteLine($"{Brand} started moving at {Speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} has stopped.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
        }
    }
}

using System;

namespace DotNetAssignment
{
    public class Car : Vehicle
    {
        // Unique field for Car
        public int Seats { get; set; }

        // Override DisplayInfo to include Seats
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call base class info
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}

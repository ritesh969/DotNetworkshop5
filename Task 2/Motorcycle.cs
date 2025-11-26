using System;

namespace DotNetAssignment
{
    public class Motorcycle : Vehicle
    {
        // Unique field for Motorcycle
        public bool HasCarrier { get; set; }

        // Override DisplayInfo to include HasCarrier
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call base class info
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }
}

using System;

namespace DotNetAssignment
{
    // Now creating derived class Bike
    public class Bike : Vehicle
    {
        // Now implementing StartEngine method
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started");
        }

        // Now implementing StopEngine method
        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped");
        }
    }
}

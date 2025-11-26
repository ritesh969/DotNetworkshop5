using System;

namespace DotNetAssignment
{
    // Now creating derived class Car
    public class Car : Vehicle
    {
        // Now implementing StartEngine method
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        // Now implementing StopEngine method
        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}

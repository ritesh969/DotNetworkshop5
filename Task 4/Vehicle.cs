using System;

namespace DotNetAssignment
{
    // Now creating abstract class Vehicle
    public abstract class Vehicle
    {
        // Now creating abstract method StartEngine
        public abstract void StartEngine();

        // Now creating abstract method StopEngine
        public abstract void StopEngine();

        // Now creating concrete method Display
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}

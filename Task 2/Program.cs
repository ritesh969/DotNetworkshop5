using System;

namespace DotNetAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Car object
            Car myCar = new Car();
            myCar.Brand = "Toyota";
            myCar.Speed = 120;
            myCar.Seats = 5;

            // Demonstrate base class methods and overridden method
            myCar.Start();
            myCar.DisplayInfo();
            myCar.Stop();

            Console.WriteLine(); // Spacer

            // Create Motorcycle object
            Motorcycle myMotorcycle = new Motorcycle();
            myMotorcycle.Brand = "Honda";
            myMotorcycle.Speed = 80;
            myMotorcycle.HasCarrier = true;

            // Demonstrate base class methods and overridden method
            myMotorcycle.Start();
            myMotorcycle.DisplayInfo();
            myMotorcycle.Stop();

            Console.ReadLine();
        }
    }
}

using System;

namespace DotNetAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------ Now demonstrating Car ------------------

            // Now creating Car object
            Car myCar = new Car();

            // Now calling Display method from base class
            myCar.Display();

            // Now calling StartEngine and StopEngine
            myCar.StartEngine();
            myCar.StopEngine();

            Console.WriteLine(); // Spacer

            // ------------------ Now demonstrating Bike ------------------

            // Now creating Bike object
            Bike myBike = new Bike();

            // Now calling Display method from base class
            myBike.Display();

            // Now calling StartEngine and StopEngine
            myBike.StartEngine();
            myBike.StopEngine();

            Console.ReadLine();
        }
    }
}

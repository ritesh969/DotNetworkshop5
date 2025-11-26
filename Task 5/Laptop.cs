using System;

namespace DotNetAssignment
{
    public class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery is turned on");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Laptop Brand: " + Brand);
            Console.WriteLine("Laptop Price: " + Price);
        }
    }
}

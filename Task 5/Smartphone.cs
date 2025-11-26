using System;

namespace DotNetAssignment
{
    public class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price) { }

        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera is enabled");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Smartphone Brand: " + Brand);
            Console.WriteLine("Smartphone Price: " + Price);
        }

        // Removed sealed keyword to fix the error
        public void WarrantyInfo()
        {
            Console.WriteLine("This smartphone comes with 1-year warranty");
        }
    }
}

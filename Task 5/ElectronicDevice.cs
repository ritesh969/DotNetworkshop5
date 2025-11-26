using System;

namespace DotNetAssignment
{
    // Abstract class ElectronicDevice
    public abstract class ElectronicDevice
    {
        // Private fields
        private string brand = string.Empty;  // default value to avoid warning
        private double price;

        // Public properties (encapsulation)
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    price = 0; // Default to 0 if invalid
            }
        }

        // Constructor
        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        // Abstract method
        public abstract void ShowInfo();
    }
}

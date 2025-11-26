using System;
using System.Collections.Generic;

namespace DotNetAssignment
{
    public class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine(device.Brand + " added to store");
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
            Console.WriteLine(device.Brand + " removed from store");
        }

        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n--- All Device Details ---\n");

            foreach (ElectronicDevice device in devices)
            {
                device.ShowInfo();

                if (device is Laptop laptop)
                    laptop.TurnOnBattery();
                else if (device is Smartphone smartphone)
                {
                    smartphone.EnableCamera();
                    smartphone.WarrantyInfo();
                }

                Console.WriteLine();
            }
        }
    }
}

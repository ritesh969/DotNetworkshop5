using System;

namespace DotNetAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicsStore myStore = new ElectronicsStore();

            Laptop myLaptop = new Laptop("Dell", 1200);
            Smartphone myPhone = new Smartphone("Samsung", 800);

            myStore.AddDevice(myLaptop);
            myStore.AddDevice(myPhone);

            myStore.ShowAllDeviceDetails();

            Console.ReadLine();
        }
    }
}

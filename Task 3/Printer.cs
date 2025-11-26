using System;

namespace DotNetAssignment
{
    // Now creating Printer class with overloaded methods
    public class Printer
    {
        // Now creating method to print string message
        public void Print(string message)
        {
            Console.WriteLine("Printing string message: " + message);
        }

        // Now creating method to print integer number
        public void Print(int number)
        {
            Console.WriteLine("Printing integer number: " + number);
        }

        // Now creating method to print string message multiple times
        public void Print(string message, int count)
        {
            Console.WriteLine("Printing string message " + count + " times:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}

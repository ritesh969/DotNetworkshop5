using System;

namespace DotNetAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------ Slide 1: Demonstrating Printer class ------------------

            // Now creating Printer object
            Printer myPrinter = new Printer();

            // Now demonstrating printing string message
            myPrinter.Print("Hello World!");

            // Now demonstrating printing integer number
            myPrinter.Print(123);

            // Now demonstrating printing string message multiple times
            myPrinter.Print("Repeat this", 3);

            Console.WriteLine(); // Spacer

            // ------------------ Slide 2: Demonstrating Teacher class ------------------

            // Now creating NepaliTeacher object
            NepaliTeacher nepTeacher = new NepaliTeacher();
            nepTeacher.Name = "Mr. Sharma";

            // Now demonstrating methods of NepaliTeacher
            Console.WriteLine("NepaliTeacher Name: " + nepTeacher.Name);
            nepTeacher.Teaching();       // Overridden method
            nepTeacher.SalaryInfo();     // Sealed method from base class

            Console.WriteLine(); // Spacer

            // Now creating EnglishTeacher object
            EnglishTeacher engTeacher = new EnglishTeacher();
            engTeacher.Name = "Ms. Smith";

            // Now demonstrating methods of EnglishTeacher
            Console.WriteLine("EnglishTeacher Name: " + engTeacher.Name);
            engTeacher.Teaching();       // Uses base class method
            engTeacher.SalaryInfo();     // Sealed method from base class

            Console.ReadLine();
        }
    }
}

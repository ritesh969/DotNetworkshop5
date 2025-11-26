using System;

namespace DotNetAssignment
{
    // Now creating Teacher base class
    public class Teacher
    {
        // Now creating Name property
        public string Name { get; set; }

        // Now creating Teaching method which can be overridden
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Now creating SalaryInfo method which cannot be overridden
        public void SalaryInfo()
        {
            Console.WriteLine("Teacher salary info cannot be overridden");
        }
    }

    // Now creating derived class NepaliTeacher
    public class NepaliTeacher : Teacher
    {
        // Now overriding Teaching method
        public override void Teaching()
        {
            Console.WriteLine("NepaliTeacher teaches in Nepali");
        }
    }

    // Now creating derived class EnglishTeacher
    public class EnglishTeacher : Teacher
    {
        // Teaching method is not overridden here, will use base class behavior
    }
}

using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee badikov = new Employee("Badikov", "Oleg");
            badikov.level = "junior";
            badikov.experience = 0;
            badikov.ShowInfo();

            Employee lesovnikov = new Employee("Lesovnikov", "Jeka");
            lesovnikov.level = "senior";
            lesovnikov.experience = 2;
            lesovnikov.ShowInfo();

            Employee tkachenko = new Employee("Tkachenko", "Bogdan");
            tkachenko.level = "lead";
            tkachenko.experience = 1;
            tkachenko.ShowInfo();

            Console.ReadKey();
        }
    }
}

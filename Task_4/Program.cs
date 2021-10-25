using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inst1 = new Invoice(100158, "Oleg", "Comfy") { Article = "flat-tvs", Quantity = 5 };
            Invoice inst2 = new Invoice(100159, "Sasha", "Comfy") { Article = "flat-tvs", Quantity = 3 };
            Invoice inst3 = new Invoice(100160, "Alina", "Comfy") { Article = "flat-tvs", Quantity = 1 };

            inst1.CostShow(true);
            inst1.CostShow(false);

            inst2.CostShow(true);

            inst3.CostShow(true);

            Console.ReadKey();
        }
    }
}

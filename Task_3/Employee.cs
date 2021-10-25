using System;

namespace Task_3
{
    class Employee
    {
        public string firstname, lastname;
        public string level;
        public int experience;        
        public Employee(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        double CalcSalary()
        {
            double salary;

            switch (level)
            {
                case "junior":
                    salary = 18171;
                    break;
                case "middle":
                    salary = 51212;
                    break;
                case "senior":
                    salary = 79848;
                    break;
                case "lead":
                    salary = 87107;
                    break;
                default:
                    salary = 10000;
                    break;
            }

            switch (experience)
            {
                case 0:
                    salary *= 1;
                    break;
                case 1:
                    salary *= 1.25;
                    break;
                case 2:
                    salary *= 1.5;
                    break;
                default:
                    salary *= 1;
                    break;
            }
            return salary;
      
        }

        public void ShowInfo()
        {
            double salary = CalcSalary();
            Console.WriteLine(firstname + " " + lastname + " - " + level);
            Console.WriteLine("Ставка {0}, подоходный налог {1}, чистыми {2} \n", salary, salary * 0.18, salary - salary * 0.18);
        }
    }
}

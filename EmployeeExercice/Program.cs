using System;
using System.Collections.Generic;

namespace EmployeeExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registred? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("Employee #{0}: ", (i + 1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                int salary = int.Parse(Console.ReadLine());
                Console.WriteLine();

                list.Add(new Employee(name, id, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increased: ");
            int ide = int.Parse(Console.ReadLine());


            if (list.Find(x => x.Id == ide) != null)
            {
                Console.Write("Enter the percentage: ");
                int percentage = int.Parse(Console.ReadLine());
                list.Find(x => x.Id == ide).IncreaseSalary(percentage);
            }
            else
                Console.WriteLine("!ID Does not exist!");

            Console.WriteLine("Updated list of employees:");
            foreach (Employee item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}


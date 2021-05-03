using System;
using System.Collections.Generic;
using TaxPayersExercice.Entities;
namespace TaxPayersExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> payers = new List<Taxpayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} payer: ");

                Console.Write("Individual or company (i/c)? ");
                char choice = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if(choice == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healphEX = double.Parse(Console.ReadLine());

                    payers.Add(new Individual(name, anualIncome, healphEX));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int empNumber = int.Parse(Console.ReadLine());

                    payers.Add(new Company(name, anualIncome, empNumber));
                }
                Console.WriteLine();

            }
                Console.WriteLine("TAXES PAID: ");

                double sum = 0;
                foreach (Taxpayer payer in payers)
                {
                    Console.WriteLine(payer.Name + ": $ " + payer.TaxesPaid());
                    sum += payer.TaxesPaid();
                }
                Console.WriteLine("\n TOTAL TAXES PAID: " + sum);
        }
    }
}

﻿using System;
using ExceptionExercice.Entities.Exceptions;
using ExceptionExercice.Entities;


namespace ExceptionExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdraw);

                Console.WriteLine("\nEnter amout for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine()));
                Console.WriteLine("New balance: " + account.Balance);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error: " + e.Message);
            }
        }
    }
}

using System;
using System.Globalization;
using ListaDeExercicios17.Entities;
using ListaDeExercicios17.Entities.Exceptions;

namespace ListaDeExercicios17
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double iBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, iBalance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                acc.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.Write($"New balance: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            } catch (WithdrawException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
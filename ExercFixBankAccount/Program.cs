using System;
using System.Globalization;
using ExercFixBankAccount.Entities;
using ExercFixBankAccount.Entities.Exceptions;

namespace ExercFixBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data:");

            try
            {
                Console.Write("Number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Withdraw limit: ");
                double limit = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account ac = new Account(number, holder!, limit);
                Console.Write("Inicial deposit: ");
                double amount = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                ac.Deposit(amount);

                Console.Write("\nEnter amount for withdraw $:  ");
                amount = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                ac.Withdraw(amount);
                Console.WriteLine("New balance $ : " + ac.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
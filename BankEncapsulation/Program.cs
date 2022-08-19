using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("How much would you like to depoist");

            var amountToDepoist = double.Parse(Console.ReadLine());

            account.Depoist(amountToDepoist);

            Console.WriteLine($"Your balance is now {account.GetBalance()}");
        }
    }
}


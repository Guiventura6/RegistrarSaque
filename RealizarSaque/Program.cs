using System;
using System.Globalization;
using RealizarSaque.Entities;
using RealizarSaque.Entities.Exceptions;

namespace RealizarSaque
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            //Entrada
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CI);
            Console.Write("Withdraw limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine(), CI);
            Account acc = new Account(number, holder, initialBalance, withDrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double withDraw = double.Parse(Console.ReadLine(), CI);
            try
            {
                //Saida
                acc.WithDraw(withDraw);                
                Console.WriteLine($"New balance: {acc.Balance.ToString("F2", CI)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}

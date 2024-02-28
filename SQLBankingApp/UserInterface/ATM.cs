using SQLBankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBankingApp.UserInterface
{
    public static class ATM
    {
        public static void ATMInterface(BankAccount account)
        {
            Console.WriteLine("Welcome to Bowman Banking App!");
            Console.WriteLine("==============================");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Deposit money");
                Console.WriteLine("2. Check balance");
                Console.WriteLine("3. Exit");

                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the amount to deposit:");
                        double depositAmount;
                        if (!double.TryParse(Console.ReadLine(), out depositAmount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }

                        account.Deposit(depositAmount);
                        Console.WriteLine("Deposit successful!");
                        break;
                    case 2:
                        Console.WriteLine($"Current balance: {account.CheckBalance():C}");
                        break;
                    case 3:
                        Console.WriteLine("Thank you for using Bowman Banking App!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}

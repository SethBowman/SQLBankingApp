using SQLBankingApp.DataAccess;
using SQLBankingApp.DataManipulation;
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
        public static bool ATMInterface(BankAccount account)
        {
            Console.WriteLine("\n\nWelcome to Bowman Banking App!");
            Console.WriteLine("==============================\n");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Deposit money");
                Console.WriteLine("2. Check balance");
                Console.WriteLine("3. Exit");

                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid option.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nEnter the amount to deposit:");
                        double depositAmount;
                        if (!double.TryParse(Console.ReadLine(), out depositAmount))
                        {
                            Console.WriteLine("\nInvalid input. Please enter a valid amount.");
                            continue;
                        }

                        account.Deposit(depositAmount);
                        Console.WriteLine("\nDeposit successful!");
                        break;
                    case 2:
                        Console.WriteLine($"\nCurrent balance: {account.CheckBalance():C}");
                        break;
                    case 3:
                        Console.WriteLine("\n\nThank you for using Bowman Banking App!");
                        return false;
                    default:
                        Console.WriteLine("\nInvalid option. Please enter a valid option.");
                        break;
                }
            }
        }

        public static void AppInterface()
        {
            bool cont = true;

            while (cont)
            {
                IBankAccountRepo bankAccountRepo = new BankAccountRepo(JSONAccess.JSONConfig());

                Console.WriteLine("Please enter your account number:");
                var accountNumber = Console.ReadLine();

                Console.WriteLine("Please enter your password:");
                var password = Console.ReadLine();

                var account = bankAccountRepo.GetAllAccounts().FirstOrDefault(a => a.AccountNumber == accountNumber);

                if (account != null && account.VerifyPassword(password))
                {
                    cont = ATMInterface(account);
                }
                else
                {
                    Console.WriteLine("\nInvalid account number or password. Please try again.\n\n");
                    continue;
                }
            }
        }
    }
}

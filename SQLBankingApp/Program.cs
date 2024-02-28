using SQLBankingApp.DataAccess;
using SQLBankingApp.DataManipulation;
using SQLBankingApp.UserInterface;

IBankAccountRepo bankAccountRepo = new BankAccountRepo(JSONAccess.JSONConfig());


    Console.WriteLine("Please enter your account number:");
    var accountNumber = Console.ReadLine();


var account = bankAccountRepo.GetAllAccounts().FirstOrDefault(a => a.AccountNumber == accountNumber);

if (account != null)
{
    ATM.ATMInterface(account);
}
else
{
    Console.WriteLine("Account not found. Please check your account number.");
}
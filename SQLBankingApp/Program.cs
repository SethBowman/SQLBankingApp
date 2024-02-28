using SQLBankingApp.DataAccess;
using SQLBankingApp.DataManipulation;
using SQLBankingApp.UserInterface;

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
        cont = ATM.ATMInterface(account);
    }
    else
    {
        Console.WriteLine("\nInvalid account number or password. Please try again.\n\n");
        continue;
    }
}
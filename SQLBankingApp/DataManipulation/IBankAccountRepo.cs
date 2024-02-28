using SQLBankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBankingApp.DataManipulation
{
    public interface IBankAccountRepo
    {
        public IEnumerable<BankAccount> GetAllAccounts();
    }
}

using Dapper;
using SQLBankingApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBankingApp.DataManipulation
{
    public class BankAccountRepo : IBankAccountRepo
    {
        private readonly IDbConnection _connection;

        public BankAccountRepo(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<BankAccount> GetAllAccounts()
        {
            return _connection.Query<BankAccount>("select * from bankaccounts;");
        }
    }
}

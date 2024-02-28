using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using SQLBankingApp.SecureFiles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBankingApp.DataAccess
{
    public static class JSONAccess
    {
        public static IDbConnection JSONConfig()
        {
            var config = new ConfigurationBuilder()                
                .AddJsonFile(FilePath._jsonPath)
                .Build();
            string connString = config.GetConnectionString("DefaultConnection");
            return new MySqlConnection(connString);
        }
    }
}

using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
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
                .AddJsonFile(@"C:\Users\sbowm\OneDrive\Desktop\repos\SQLBankingApp\SQLBankingApp\SecureFiles\appsettings.json")
                .Build();
            string connString = config.GetConnectionString("DefaultConnection");
            return new MySqlConnection(connString);
        }
    }
}

using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Zadanie1
{
    class Program
    {

        static void Main(string[] args)
        {
            var connectionString = @"Data Source=ELO420\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;" +
                                    "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                                    "MultiSubnetFailover=False;MultipleActiveResultSets = True";

            using var connection = new SqlConnection(connectionString);

            connection.Open();

            DB.Wyswietl(connection);

            DB.Wstawianie(connection);

            DB.Zamiana(connection);

            connection.Close();


        }
    }
}

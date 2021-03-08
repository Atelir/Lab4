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

            var selectSql = "SELECT * FROM dbo.Customers";
            var polecenie = new SqlCommand(selectSql, connection);
            var wyswietl = polecenie.ExecuteReader();

            
            foreach (DbDataRecord item in wyswietl)
            {
                Console.WriteLine(item.GetString(0) + " " + item.GetString(1));
            }
            Console.WriteLine();

            string idKlienta;
            string nazwaFirmy;
            Console.Write("Podaj IdKlienta: (powinno składać się z 5 liter)");
            idKlienta = Console.ReadLine();
            if(idKlienta.Length != 5)
            {

                Console.WriteLine("Niepoprawna ilość znaków w ID");
                System.Environment.Exit(0);
            }
            Console.Write("Podaj nazwe firmy: ");
            nazwaFirmy = Console.ReadLine();
            if (nazwaFirmy.Length == 0 )
            {

                Console.WriteLine("Nie wprowadzono nazwy firmy");
                System.Environment.Exit(0);
            }

            var insertSql = "INSERT INTO dbo.Customers (CustomerID, CompanyName) VALUES (@ID, @CompanyName)";
            var insertCommand = new SqlCommand(insertSql, connection);
            insertCommand.Parameters.Add(new SqlParameter("@ID", idKlienta));
            insertCommand.Parameters.Add(new SqlParameter("@CompanyName", nazwaFirmy));
            insertCommand.ExecuteNonQuery();


            string idKlientaNowe;
            string nazwaFirmyNowa;
            Console.Write("Podaj IDklienta którego nazwe firmy chcesz zmienić: ");
            idKlientaNowe = Console.ReadLine();
            Console.Write("Podaj nową nazwę firmy");
            nazwaFirmyNowa = Console.ReadLine();

            var SQLaktualizacja = $"UPDATE dbo.Customers SET CompanyName = @CompanyName WHERE CustomerID = @ID";
            var SQLAktKomenda = new SqlCommand(SQLaktualizacja, connection);
            SQLAktKomenda.Parameters.Add(new SqlParameter("@CompanyName", nazwaFirmyNowa));
            SQLAktKomenda.Parameters.Add(new SqlParameter("@ID", idKlientaNowe));
            SQLAktKomenda.ExecuteNonQuery();

            string idKlientaUsun;
            Console.Write("Podaj IDKlienta którego firmę chcesz usunąć: ");
            idKlientaUsun = Console.ReadLine();

            var SQLusuniecie = $"DELETE FROM dbo.Customers WHERE CustomerID = @ID";
            var SQLUsunKomenda = new SqlCommand(SQLusuniecie, connection);
            SQLUsunKomenda.Parameters.Add(new SqlParameter("@ID", idKlientaUsun));
            SQLUsunKomenda.ExecuteNonQuery();

            connection.Close();


        }
    }
}

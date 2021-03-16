using System;
using Dapper;
using System.Collections.Generic;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {

            

            var db = new Baza(@"Data Source = ELO420\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            foreach (Customers customers in db.GetCustomers())
            {
                Console.WriteLine($"{customers.CustomerID}  {customers.CompanyName}");
            }
            Console.WriteLine();
            Console.WriteLine("Pojedynczy rekord po ID:");
            Console.WriteLine();
            var singleCustomer = db.GetCustomersByID("ALFKI");
            Console.WriteLine($"{singleCustomer.CustomerID}  {singleCustomer.CompanyName}");

            Console.WriteLine("Podaj nowe ID klienta:");
            string clientID = Console.ReadLine();
            Console.WriteLine("Podaj nową nazwę firmy:");
            string companyName = Console.ReadLine();
            db.AddCustomer(new Customers() { CustomerID = clientID, CompanyName = companyName });
            var dlatestu = db.GetCustomersByID(clientID);
            Console.WriteLine("Wiersz wstawiony:");
            Console.WriteLine($"{dlatestu.CustomerID}  {dlatestu.CompanyName}");
            Console.WriteLine("Podaj poprawiona nazwę firmy:");
            string companyNameEdit = Console.ReadLine();
            db.ChangeCustomer(clientID, companyNameEdit);
            db.DeleteCustomer(clientID);
            foreach (Customers customers in db.GetCustomers())
            {
                Console.WriteLine($"{customers.CustomerID}  {customers.CompanyName}");
            }


        }

    }
}

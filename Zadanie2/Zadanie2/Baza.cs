using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Zadanie2
{
    public class Baza
    {
        private IDbConnection _connection;
        public Baza(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }
        
        public IEnumerable<Customers> GetCustomers() //<Customers> zeby nie bylo dynamic
        {

            return _connection.Query<Customers>("SELECT * FROM dbo.Customers");

        }

        public Customers GetCustomersByID(string id) //parametr
        {

            return _connection.QuerySingleOrDefault<Customers>("SELECT * FROM dbo.Customers WHERE CustomerID = @ID", new {ID = id });

        }

        public bool AddCustomer(Customers customer)
        {

            var wynik = _connection.Execute("INSERT INTO Customers(CustomerID,CompanyName) VALUES (@ID, @CompanyName)", new { id = customer.CustomerID, CompanyName = customer.CompanyName });
            return wynik == 1;

        }

        public Customers ChangeCustomer(string id, string companyName)
        {

            return _connection.QuerySingleOrDefault<Customers>("UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID = @ID", new { ID = id, CompanyName = companyName });

        }

        public Customers DeleteCustomer(string id)
        {

            return _connection.QuerySingleOrDefault<Customers>("DELETE Customers WHERE CustomerID = @ID", new { ID = id });

        }


    }
}

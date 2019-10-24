using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Dapper101AHBCJULY2019.DAL.Models;

namespace Dapper101AHBCJULY2019.DAL
{
    public interface ICustomerStore
    {
        IEnumerable<CustomerDALModel> SelectAllCustomers();
        CustomerDALModel SelectCustomerByFirstName(string firstName);

        CustomerDALModel SelectCustomerById(string id);
    }

    public class CustomerStore : ICustomerStore
    {
        private readonly Database _config;

        public CustomerStore(Dapper101AHBCJULY2019Configuration config)
        {
            _config = config.Database;
        }

        public IEnumerable<CustomerDALModel> SelectAllCustomers()
        {
            var sql = @"SELECT * FROM Customers";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Query<CustomerDALModel>(sql);
                return result;
            }
        }

        public CustomerDALModel SelectCustomerByFirstName(string firstName)
        {
            var sql = @"Select * From Customers Where ContactName LIKE @ContactName";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.QueryFirstOrDefault<CustomerDALModel>(sql, new {ContactName = $"%{firstName}%"});

                return result;
            }
        }

        public CustomerDALModel SelectCustomerById(string id)
        {
            var sql = @"Select * From Customers where CustomerId = @CustomerId";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.QueryFirstOrDefault<CustomerDALModel>(sql, new { CustomerID = id });

                return result;
            }
        }
    }

    public static class StringExtensions
    {
        public static string ToCamelCase(this string subject)
        {
            return "I'm a camel, sup";
        }
    }
}

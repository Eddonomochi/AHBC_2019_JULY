using Dapper;
using Dapper101AHBCJULY2019.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper101AHBCJULY2019.DAL
{
    public interface IProductStore
    {
        ProductDALModel SelectProductById(string id);
        IEnumerable<ProductDALModel> SelectAllProducts();

    }


    public class ProductStore : IProductStore
    {
        private readonly Database _config;

        public ProductStore(Dapper101AHBCJULY2019Configuration config)
        {
            _config = config.Database;
        }

        public IEnumerable<ProductDALModel> SelectAllProducts()
        {
            var sql = @"SELECT * FROM Products";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Query<ProductDALModel>(sql);
                return result;
            }

        }

        public ProductDALModel SelectProductById(string id)
        {
            var sql = @"Select * From Products where ProductID = @ProductID";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.QueryFirstOrDefault<ProductDALModel>(sql, new { ProductID = id });

                return result;
            }

        }
    }
}

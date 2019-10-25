using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper101AHBCJULY2019.DAL.Models;

namespace Dapper101AHBCJULY2019.Models
{
    public class ProductListViewModel
    {

        public string ProductId { get; set; }
        public string ProductName { get; set; }

        public ProductListViewModel(ProductDALModel dalModel)
        {
            ProductId = dalModel.ProductID;
            ProductName = dalModel.ProductName;
        }
    }
}
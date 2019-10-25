using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper101AHBCJULY2019.DAL.Models
{
    public class ProductDALModel
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string SupplierID { get; set; }
        public string CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }


    }
}

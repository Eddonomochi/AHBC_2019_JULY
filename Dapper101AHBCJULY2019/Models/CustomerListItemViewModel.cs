using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper101AHBCJULY2019.DAL.Models;

namespace Dapper101AHBCJULY2019.Models
{
    public class CustomerListItemViewModel
    {
        public CustomerListItemViewModel(CustomerDALModel dalModel)
        {
            Id = dalModel.CustomerID;
            Name = dalModel.ContactName;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper101AHBCJULY2019.Models
{
    public class CustomersViewModel
    {
        public IEnumerable<CustomerListItemViewModel> Customers { get; set; }
    }
}

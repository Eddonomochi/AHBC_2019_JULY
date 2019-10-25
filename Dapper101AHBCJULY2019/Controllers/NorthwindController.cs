using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper101AHBCJULY2019.DAL;
using Dapper101AHBCJULY2019.NorthwindServices;
using Microsoft.AspNetCore.Mvc;

namespace Dapper101AHBCJULY2019.Controllers
{
    public class NorthwindController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;


        public NorthwindController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Customers()
        {
            var result = _customerService.GetCustomers();
            return View(result);
        }

        public IActionResult Products()
        {
            var result = _productService.GetProducts();
            return View(result);
        }


        public IActionResult Home()
        {
            return View();
        }

        public IActionResult GetCustomer()
        {
            return View();
        }

        public IActionResult GetProduct()
        {
            return View();
        }

        public IActionResult Customer(string id)
        {
            var customer = _customerService.GetCustomer(id);
            return View(customer);
        }
    }
}
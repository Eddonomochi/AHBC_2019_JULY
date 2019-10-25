using Dapper101AHBCJULY2019.DAL;
using Dapper101AHBCJULY2019.DAL.Models;
using Dapper101AHBCJULY2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper101AHBCJULY2019.NorthwindServices
{
    public interface IProductService
    {
        ProductsViewModel GetProducts();
        ProductViewModel GetProduct(string id);
    }

    public class ProductService : IProductService
    {
        private readonly IProductStore _produtStore;
        public ProductService(IProductStore productStore)
        {
            _produtStore = productStore;
        }

        public ProductViewModel GetProduct(string id)
        {
            var dalProduct = _produtStore.SelectProductById(id);
            var product = MapProductViewModel(dalProduct);
            return product;
        }

        public ProductsViewModel GetProducts()
        {
            var dalProducts = _produtStore.SelectAllProducts();

            var products = new List<ProductListViewModel>();

            foreach (var dalPRoduct in dalProducts)
            {
                products.Add(new ProductListViewModel(dalPRoduct));
            }

            var productViewModel = new ProductsViewModel();
            productViewModel.Products = products;

            return productViewModel;
            
        }

        private ProductViewModel MapProductViewModel(ProductDALModel dalProduct)
        {
            var product = new ProductViewModel();
            product.ProductID = dalProduct.ProductID;
            product.ProductName = dalProduct.ProductName;
            product.SupplierID = dalProduct.SupplierID;
            product.CategoryID = dalProduct.CategoryID;
            product.QuantityPerUnit = dalProduct.QuantityPerUnit;
            product.UnitPrice = dalProduct.UnitPrice;
            product.UnitsInStock= dalProduct.UnitsInStock;
            product.UnitsOnOrder = dalProduct.UnitsOnOrder;
            product.ReorderLevel= dalProduct.ReorderLevel;
            product.Discontinued = dalProduct.Discontinued;
            return product;


        }
    }
}

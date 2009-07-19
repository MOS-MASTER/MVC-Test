using System.Collections.Generic;
using System.Linq;
using CS.Data;

namespace CS.Tests.TestRepositories
{
    public class TestProductRepository :IProductRepository
    {
        private readonly IList<Product> _products;
        public TestProductRepository()
        {
            _products = new List<Product>();
            for (var i = 1; i <= 5; i++)
            {
                var p = new Product {ProductId = i, ProductName = string.Format("Product {0}", i)};

                _products.Add(p);
            }
        }

        public IQueryable<Product> GetProducts()
        {
            return _products.AsQueryable();
        }
    }
}

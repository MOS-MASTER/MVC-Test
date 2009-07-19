using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS.Data;

namespace CS.Services
{
    public class ProductService :IProductService
    {
        private IProductRepository _repository = null;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
            if(_repository == null)
                throw new InvalidOperationException("Product Repository cannot be null");
        }

        public IList<Product> GetProducts()
        {
            return _repository.GetProducts().ToList();
        }

        public IList<Product> GetProductsByCategory(int id)
        {
            return _repository.GetProducts().WithCategoryId(id).ToList();
        }

        public Product GetProduct(int id)
        {
            return _repository.GetProducts()
                .WithProductId(id).SingleOrDefault();
        }

        public Product GetProduct(string productname)
        {
            return _repository.GetProducts()
                .WithProductName(productname).SingleOrDefault();
        }
    }
}

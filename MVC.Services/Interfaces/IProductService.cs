using System.Collections.Generic;
using CS.Data;

namespace CS.Services
{
    public interface IProductService
    {
        IList<Product> GetProducts();
        IList<Product> GetProductsByCategory(int id);
        Product GetProduct(int id);
        Product GetProduct(string productname);
    }
}
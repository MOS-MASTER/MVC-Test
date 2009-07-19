using System.Linq;

namespace CS.Data
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts();
    }
}

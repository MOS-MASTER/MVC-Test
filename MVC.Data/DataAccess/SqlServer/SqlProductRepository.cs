using System.Linq;
using CS.Data.DataAccess.SqlServer;

namespace CS.Data
{
    public class SqlProductRepository :IProductRepository
    {
        private readonly LinqTestDataContext _db;

        public SqlProductRepository()
        {
            
        }
        public SqlProductRepository(LinqTestDataContext dataContext)
        {
            _db = dataContext;
        }

        public IQueryable<Product> GetProducts()
        {
            return _db.Products.Select(p => new Product
                                                {
                                                    ProductId = p.ProductId,
                                                    ProductName = p.ProductName,
                                                    CategoryId = p.CategoryId
                                                });
        }
    }
}

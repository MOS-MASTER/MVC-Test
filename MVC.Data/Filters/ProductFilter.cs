using System.Linq;

namespace CS.Data
{
    public static class ProductFilter
    {
        public static IQueryable<Product> WithProductId
            (this IQueryable<Product> qry, int id)
        {
            return qry.Where(p => p.ProductId == id);
        }

        public static IQueryable<Product> WithProductName
            (this IQueryable<Product> qry, string productname)
        {
            return qry.Where(p => p.ProductName.ToLower()
                                  == productname.ToLower());
        }

        public static IQueryable<Product> WithCategoryId
            (this IQueryable<Product> qry, int id)
        {
            return qry.Where(p => p.CategoryId == id);
        }
    }
}
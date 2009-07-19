using System.Linq;

namespace CS.Data
{
    public static class CategoryFilter
    {
        public static IQueryable<Category> WithCategoryId
            (this IQueryable<Category> qry, int id)
        {
            return qry.Where(c => c.CategoryId == id);
        }

        public static IQueryable<Category> WithCategoryName
            (this IQueryable<Category> qry, string categoryname)
        {
            return qry.Where(c => c.CategoryName.ToLower()
                                  == categoryname.ToLower());
        }
    }
}
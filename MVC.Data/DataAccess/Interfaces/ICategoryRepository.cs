using System.Linq;

namespace CS.Data
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetCategories();
        bool Add(Category category);
        bool Delete(Category category);
    }
}

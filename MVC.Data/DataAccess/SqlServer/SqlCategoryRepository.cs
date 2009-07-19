using System;
using System.Linq;
using CS.Data.DataAccess.SqlServer;

namespace CS.Data
{
    public class SqlCategoryRepository : ICategoryRepository
    {
        private readonly LinqTestDataContext _db;

        public SqlCategoryRepository()
        {
        }

        public SqlCategoryRepository(LinqTestDataContext dataContext)
        {
            _db = dataContext;
        }

        #region ICategoryRepository Members

        public IQueryable<Category> GetCategories()
        {
            return _db.Categories.Select(c => new Category
                                                  {
                                                      CategoryId = c.CategoryId,
                                                      CategoryName = c.CategoryName,
                                                  });
        }

        public bool Delete(Category category)
        {
            using (_db)
            {
                var linqcategory = _db.Categories.Single
                    (c => c.CategoryName.ToLower() 
                        == category.CategoryName.ToLower());

                if (linqcategory != null)
                {
                    _db.Categories.DeleteOnSubmit(linqcategory);
                    _db.SubmitChanges();
                }
            }
            return true;
        }

        #endregion

        public bool Add(Category category)
        {
            using (_db)
            {
                var linqcategory = new DataAccess.SqlServer.Category
                                       {
                                           CategoryName = category.CategoryName
                                       };

                _db.Categories.InsertOnSubmit(linqcategory);
                _db.SubmitChanges();
            }
            return true;
        }
    }
}
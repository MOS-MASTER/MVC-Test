using System.Linq;
using CS.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.IntegrationTests
{
    [TestClass]
    public class SqlCategoryRepositoryTest :TestBase
    {
        [TestMethod]
        public void SqlCategoryRepositoryShouldReturnCategoriesAsQueryable()
        {
            var qry = _categoryRepository.GetCategories();
            Assert.IsNotNull(qry);
        }

        public void SqlCategoryReposistoryShoulReturnTwoCategories()
        {
            var qry = _categoryRepository.GetCategories();
            Assert.IsNotNull(qry);

            var categories = qry.ToList();
            Assert.AreEqual(2, categories.Count);
        }

        [TestMethod]
        public void SqlCategoryRepositoryShouldReturnFiveProductsForCategoryOne()
        {
            var qry = _categoryRepository.GetCategories();
            Assert.IsNotNull(qry);
        }

        public void SqlCategoryRepositoryAddNewCategoryWithNameCoding()
        {
            var category = new Category
                               {
                                   CategoryName = "Coding"
                               };
            var add = _categoryRepository.Add(category);
            Assert.IsTrue(add);
        }

        public void SqlCategoryRepositoryDeleteNewCategoryWithNameCoding()
        {
            var category = _categoryService.GetCategory("Coding");
            Assert.IsNotNull(category);
            var delete = _categoryRepository.Delete(category);
            Assert.IsTrue(delete);
        }
    }
}

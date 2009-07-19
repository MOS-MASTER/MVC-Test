using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS.Data;
using CS.Services;

namespace CS.IntegrationTests
{
    /// <summary>
    /// Summary description for CategoryTest
    /// </summary>
    [TestClass]
    public class CategoryServiceTest :TestBase
    {
        [TestMethod]
        public void CategoryServiceShouldReturnCategoryOneWithNameFruits()
        {
            Category category = _categoryService.GetCategory(1);
            Assert.IsNotNull(category);
            Assert.AreEqual(category.CategoryName, "Fruits");
        }

        [TestMethod]
        public void CategoryServiceShouldReturnCategoryFruits()
        {
            Category category = _categoryService.GetCategory("Fruits");
            Assert.IsNotNull(category);
            Assert.AreEqual(category.CategoryName, "Fruits");
        }

        public void CategoryServiceShouldReturnTwoCategories()
        {
            IList<Category> categories = _categoryService.GetCategories();
            Assert.AreEqual(3, categories.Count);
        }

        [TestMethod]
        public void CategoryFruitsShouldReturnFiveProducts()
        {
            Category category = _categoryService.GetCategory("Fruits");
            Assert.IsNotNull(category);

            IList<Product> products = _productService.GetProductsByCategory(category.CategoryId);
            Assert.AreEqual(5, products.Count);
        }

        public void CategoryServiceAddCategoryWithNameServiceTest()
        {
            var category = new Category
                               {
                                   CategoryName = "ServiceTest"
                               };
            var add = _categoryService.Add(category);
            Assert.IsTrue(add);
        }

        public void CategoryServiceDeleteCategoryWithNameServiceTest()
        {
            var category = _categoryService.GetCategory("ServiceTest");
            var delete = _categoryService.Delete(category);
            Assert.IsTrue(delete);
        }
    }
}

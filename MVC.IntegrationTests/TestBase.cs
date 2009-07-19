using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CS.Data.DataAccess.SqlServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS.Data;
using CS.Services;

namespace CS.IntegrationTests
{
    /// <summary>
    /// Summary description for TestBase
    /// </summary>
    [TestClass]
    public class TestBase
    {
        protected IProductRepository _productRepository;
        protected ICategoryRepository _categoryRepository;
        protected IProductService _productService;
        protected ICategoryService _categoryService;

        [TestInitialize]
        public void Startup()
        {
            var dataContext = new LinqTestDataContext();
            _productRepository = new SqlProductRepository(dataContext);
            _categoryRepository = new SqlCategoryRepository(dataContext);

            _productService = new ProductService(_productRepository);
            _categoryService = new CategoryService(_categoryRepository);
        }
    }
}

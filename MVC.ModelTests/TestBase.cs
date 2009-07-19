using CS.Data;
using CS.Tests.TestRepositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Tests
{
    /// <summary>
    /// Summary description for TestBase
    /// </summary>
    [TestClass]
    public class TestBase
    {
        protected IProductRepository _productRepository;

        [TestInitialize]
        public void Startup()
        {
            _productRepository = new TestProductRepository(); //init test products
        }
    }
}
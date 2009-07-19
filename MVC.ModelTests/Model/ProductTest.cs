using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Tests.Model
{
    /// <summary>
    /// Summary description for ProductTest
    /// </summary>
    [TestClass]
    public class ProductTest :TestBase
    {
        [TestMethod]
        public void ProductsRepositoryShouldReturn5Products()
        {
            Assert.AreEqual(5, _productRepository.GetProducts().Count());
        }
    }
}

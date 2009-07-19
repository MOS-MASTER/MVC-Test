using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS.Services;
using CS.Data;

namespace CS.IntegrationTests
{
    [TestClass]
    public class ProductServiceTest :TestBase
    {
        [TestMethod]
        public void ProductServiceShouldReturnProductOneWithNameAppels()
        {
            Product product = _productService.GetProduct(1);
            Assert.AreEqual(product.ProductName, "Appels");
        }

        [TestMethod]
        public void ProductServiceShouldReturnProductAppels()
        {
            Product product = _productService.GetProduct("Appels");
            Assert.IsNotNull(product);
            Assert.AreEqual(product.ProductName, "Appels");
        }

        [TestMethod]
        public void ProductServiceShouldReturnSixProducts()
        {
            IList<Product> products = _productService.GetProducts();
            Assert.AreEqual(6, products.Count);
        }
    }
}

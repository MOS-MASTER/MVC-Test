using System.Linq;
using CS.Data;
using CS.Data.DataAccess.SqlServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS.Data;
using CS.Services;
using Product=CS.Data.Product;

namespace CS.IntegrationTests
{
    [TestClass]
    public class ProductIntegrationTest :TestBase
    {

        /// <summary>
        /// Return products as IQueryable from the repository to see if we don't hit the db here
        /// </summary>
        [TestMethod]
        public void SqlProductRepositoryShouldReturnProductsAsQueryable()
        {
            var qry = _productRepository.GetProducts();
            Assert.IsNotNull(qry);
        }

        /// <summary>
        /// Retrieve product ID 1 from the repository and check that its name is "Appels"
        /// </summary>
        [TestMethod]
        public void SqlProductRepositoryProductOneShouldHaveNameAppels()
        {
            //var productService = new ProductService(_productRepository);
            //Assert.IsNotNull(productService);

            //Product product = productService.GetProduct(1);
            //Assert.AreEqual(product.ProductName, "Appels");   //this one is for service tests
            var qry = _productRepository.GetProducts();
            Assert.IsNotNull(qry);

            var products = (from p in qry where p.ProductId == 1 select p).ToList(); //At THIS point the query hits the db!!

            Assert.AreEqual(1, products.Count);
            Assert.AreEqual(products[0].ProductName, "Appels");
        }

        /// <summary>
        /// retrieve all products from the reposistory and check that the product count is 6
        /// </summary>
        [TestMethod]
        public void SqlProductRepositoryProductCountShouldReturn6()
        {
            var qry = _productRepository.GetProducts();
            Assert.IsNotNull(qry);

            var products = qry.ToList();

            Assert.AreEqual(6, products.Count);
        }
    }
}

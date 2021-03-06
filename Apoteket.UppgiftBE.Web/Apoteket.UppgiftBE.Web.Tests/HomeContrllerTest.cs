﻿using System.Collections.Generic;
using System.Web.Mvc;
using Apoteket.UppgiftBE.Web.Controllers;
using Apoteket.UppgiftBE.Web.Data;
using Apoteket.UppgiftBE.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Apoteket.UppgiftBE.Web.Tests
{
    /// <summary>
    /// Summary description for HomeControllerTest
    /// </summary>
    [TestClass]
    public class HomeControllerTest
    {
        public HomeControllerTest()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void HomeControllerIndexView()
        {
            //Arrange
            var homeController = new HomeController();
            //Act
            var result = homeController.Index() as ViewResult;
            //Assert
           Assert.IsNotNull(result);
           Assert.AreEqual("Index", result.ViewName);
        }

        //public void TestCreateGetForBasketController()
        //{
        //    BasketController basketController = new BasketController();
        //    ViewResult result = basketController.Create() as ViewResult;
        //    Assert.IsNotNull(result);
        //    Assert.IsInstanceOfType(result, typeof(ViewResult));
        //    Assert.AreEqual(string.Empty, result.ViewName);
        //}


        [TestMethod]
        public void TestDetailsView()
        {
            var productController = new ProductController();
            var result = productController.Details(1) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }

        [TestMethod]
        public void TestDetailsViewData()
        {
            var products = new List<Product>
            {
                new Product() {Id = 1, Name = "Kaffe", Price = 5},
                new Product() {Id = 2, Name = "Kaffe1", Price = 5},
                new Product() {Id = 3, Name = "Kaffe2", Price = 5}
            };

            var controller = new ProductController();
            var result = controller.Details(1) as ViewResult;
            var product = (Product)result.ViewData.Model;
            Assert.AreEqual("Kaffe", product.Name);
        }

        [TestMethod]
        public void ThenReturnProductViewModel()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product() {Id = 1, Name = "Kaffe", Price = 5},
                new Product() {Id = 2, Name = "Kaffe1", Price = 5},
                new Product() {Id = 3, Name = "Kaffe2", Price = 5}
            };
            var productRepository = new Mock<IProductList>();
            productRepository.Setup(e => e.Get()).Returns(products);
            var controller = new ProductController();
            // Act 
            var result = controller.Index() as ViewResult;
            
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Product", result.Model.GetType().ToString());
        }

        [TestMethod]
        public void TestDetailsRedirect()
        {
            var productController = new ProductController();
            var result = (RedirectToRouteResult)productController.Details(-1);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

    }
}

using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using Apoteket.UppgiftBE.Web.Controllers;
using Apoteket.UppgiftBE.Web.Data;
using Apoteket.UppgiftBE.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Apoteket.UppgiftBE.Web.Tests
{
    /// <summary>
    /// Summary description for BasketControllerTest
    /// </summary>
    [TestClass]
    public class BasketControllerTest
    {
        public BasketControllerTest()
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
        public void BasketControllerIndexView()
        {
            //Arrange
            var basketController = new BasketController();
            //Act
            var result = basketController.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(String.Empty, result.ViewName);
        }

        [TestMethod] //Test the call of return view(), no args passed to the View function.
        public void TestCreateGetForBasketController()
        {
            BasketController basketController = new BasketController();
            ViewResult result = basketController.Create() as ViewResult;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(string.Empty, result.ViewName);
        }

        [TestMethod]
        public void TestBasketContrllorDetailsRedirect()
        {
            var basketController = new BasketController();
            var result = (RedirectToRouteResult)basketController.Details(-1);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }
    }
}

using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenCartTest.Logic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Assert = NUnit.Framework.Assert;

namespace OpenCartTest
{
    [TestClass]
    public class AddingToCartTesting
    {
        IWebDriver driver = new ChromeDriver();
        AddToCartLogic addToCartLogic;

        [SetUp]
        public void InitialisationMainPage()
        {
            addToCartLogic = new AddToCartLogic();
        }

       [Test]
        public void AddToCartTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            addToCartLogic.AddToCart();
            addToCartLogic.AddToCart(Constants.NAME_SELECTED_PRODUCT);
        }       
    }
}

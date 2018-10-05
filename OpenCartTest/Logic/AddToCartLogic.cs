using OpenCartTest.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenCartTest.Logic
{
    public class AddToCartLogic
    {
        public void AddToCart()
        {
            Constants.driver = new ChromeDriver();
            Constants.driver.Navigate().GoToUrl("http://atqc-shop.epizy.com/index.php?route=common/home");
        }

        public void AddToCart(string nameProduct)
        {
            MainPage MainPage = new MainPage(Constants.driver);
            foreach (var element in MainPage.GetListProduct())
                {
                if (element.GetTextFromProductName() == nameProduct)
                {
                    element.ClickAddToWishList();
                }
            }

        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCartTest.pages

{
    public abstract class Nav
    {        
        public IWebDriver driver;

        protected SelectElement ChangeCurrencySelect { get; private set; }
        protected IWebElement PhoneButton { get; private set; }
        protected IWebElement PhoneLabel { get; private set; }
        protected SelectElement MyAcountSelect { get; private set; }
        protected IWebElement WishListButton { get; private set; }
        protected IWebElement ShoppingCartButton { get; private set; }
        protected IWebElement CheckoutButton { get; private set; }

        public Nav(IWebDriver driver)
        {
            this.ChangeCurrencySelect = new SelectElement(driver.FindElement(By.XPath("//div[@class = 'btn-group']")));
            this.PhoneButton = driver.FindElement(By.XPath("//i[@class='fa fa-phone']"));
            this.MyAcountSelect = new SelectElement(driver.FindElement(By.XPath("//a[contains(@title, 'My Account')]")));
            this.WishListButton = driver.FindElement(By.Id("wishlist-total"));
            this.ShoppingCartButton = driver.FindElement(By.XPath("//a[contains(@title,'Shopping Cart')]"));
            this.CheckoutButton = driver.FindElement(By.XPath("//a[contains(@title,'Checkout')]"));
        }

        //ChangeCurrencySelect
        public IWebElement GetChangeCurrencySelectElement()
        {
            return ChangeCurrencySelect.AllSelectedOptions[0];
        }
        public string GetChangeCurrencySelectText()
        {
            return GetChangeCurrencySelectElement().Text;
        }

        public void SetCurrent(string currentValue)
        {
            ChangeCurrencySelect.SelectByText(currentValue);
        }


        //Phone Button
        public void ClickPhoneButton()
        {
            PhoneButton.Click();
        }

        //Phone Lable
        public string GetPhoneLableText()
        {
            return PhoneLabel.Text;
        }


        //MyAcountSelect
        public IWebElement GetMyAcountSelectElement()
        {
            return MyAcountSelect.AllSelectedOptions[0];
        }
        public string GetMyAcountSelectText()
        {
            return GetMyAcountSelectElement().Text;
        }
        public void SetMyAcountSelect(string RegOrLog)
        {
            MyAcountSelect.SelectByText(RegOrLog);
        }

        //WishListButton
        public string GetWishListButtonText()
        {
            return WishListButton.Text;
        }

        public void ClickWishListButton()
        {
            WishListButton.Click();
        }

        //ShoppingCartButton
        public string GetShoppingCartButtonButtonText()
        {
            return ShoppingCartButton.Text;
        }

        public void ClickShoppingCartButton()
        {
            ShoppingCartButton.Click();
        }

        //CheckoutButton
        public string GetCheckoutButtonText()
        {
            return CheckoutButton.Text;
        }

        public void ClickCheckoutButton()
        {
            CheckoutButton.Click();
        }
    }
}

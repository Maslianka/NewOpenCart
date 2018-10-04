using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace OpenCartTest.pages
{
    public class ProductItem
    {
        protected IWebElement ProductBox { get; private set; }
        protected IWebElement ProductImage { get; private set; }
        protected IWebElement ProductName { get; private set; }
        protected IWebElement ProductDescription { get; private set; }
        protected IWebElement ProductPrice { get; private set; }
        protected IWebElement ProductExTax { get; private set; }
        protected IWebElement ProductIconCart { get; private set; }
        protected IWebElement ProductIconWishList { get; private set; }
        protected IWebElement ProductIconCompare { get; private set; }

        public ProductItem(IWebDriver driver, IWebElement current)
        {

            this.ProductBox = current;
            this.ProductImage = current.FindElement(By.ClassName("image"));
            this.ProductName = current.FindElement(By.CssSelector(".caption>h4>a"));
            this.ProductDescription = current.FindElements(By.CssSelector(".caption p"))[0];
            this.ProductPrice = current.FindElement(By.CssSelector(".caption .price"));
            this.ProductExTax = current.FindElement(By.CssSelector(".caption .price .price-tax"));
            this.ProductExTax = current.FindElement(By.CssSelector(".caption .price .price-tax"));
            this.ProductIconCart = current.FindElement(By.XPath("//a[text()=" + ProductName + "]/../../..//i[@class='fa fa-shopping-cart']"));
            this.ProductIconWishList = current.FindElement(By.XPath("//a[text()=" + ProductName + "]/../../..//i[@class='fa fa-heart']"));
            this.ProductIconCompare = current.FindElement(By.XPath("//a[text()=" + ProductName + "]/../../..//i[@class='fa fa-exchange']"));
           

        }

        //ProductImage
        public void ClickProductImage()
        {
            this.ProductImage.Click();
        }

        //ProductName
        public void ClickProductName()
        {
            this.ProductName.Click();
        }

        //GetTextFromLabel
        public string GetTextFromProductName()
        {
            return this.ProductName.Text;
        }
        public string GetTextFromProductDescription()
        {
            return this.ProductDescription.Text;
        }
        public string GetTextFromProductPrice()
        {
            return this.ProductPrice.Text;
        }
        public string GetTextFromProductExTax()
        {
            return this.ProductExTax.Text;
        }

        //Buttons
        public void ClickCartButton()
        {
            this.ProductIconCart.Click();
        }
        public void ClickAddToWishList()
        {
            this.ProductIconWishList.Click();
        }
        public void ClickCompareButton()
        {
            this.ProductIconCompare.Click();
        }
    }
}

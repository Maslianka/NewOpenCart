using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace OpenCartTest.pages
{
    public class MainPage : Nav
    {  
        protected IWebElement UpHorizontalCarousel { get; private set; }
        protected IWebElement DownHorizontalCarousel { get; private set; }



        protected List<ProductItem> listProduct;

        public MainPage(IWebDriver driver) : base(driver)
        {
            UpHorizontalCarousel = driver.FindElement(By.Id("slideshow0"));

            listProduct = new List<ProductItem>();
            var elements = driver.FindElements(By.ClassName("product-layout"));
            foreach (var current in elements)
            {
                listProduct.Add(new ProductItem(driver, current));
            }

            DownHorizontalCarousel = driver.FindElement(By.Id("carousel0"));
        }

    }
}

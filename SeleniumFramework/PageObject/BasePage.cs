using OpenQA.Selenium;

namespace SeleniumFramework.PageObject
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}

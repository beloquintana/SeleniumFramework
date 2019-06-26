using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Helpers
{
    public class WaitHelper
    {
        public static bool ElementIsPresent(IWebDriver driver, By locator, double seconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

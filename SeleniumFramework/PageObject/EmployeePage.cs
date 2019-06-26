using OpenQA.Selenium;
using SeleniumFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.PageObject
{
    public class EmployeePage : BasePage
    {
        protected By Form = By.Id("formEmployee");

        public EmployeePage(IWebDriver driver)
            : base(driver)
        {
            if (!Driver.Title.Equals("AUT Form – Verstand QA"))
                throw new Exception("This is not the Employee page");
        }

        public bool FormIsPresent()
        {
            return WaitHelper.ElementIsPresent(Driver, Form, 2);
        }

        public bool IsSuccessAlertPresent()
        {
            try
            {
                Driver.SwitchTo().Alert().Accept();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }            
        }

    }
}

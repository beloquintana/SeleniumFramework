using OpenQA.Selenium;
using SeleniumFramework.Helpers;
using System;

namespace SeleniumFramework.PageObject
{
    public class EmployeePage : BasePage
    {
        protected By Form = By.Id("formEmployee");
        protected By NameInput = By.XPath("//*[@id='formEmployee']/div[2]/div[1]/input");
        protected By EmailInput = By.XPath("//*[@id='formEmployee']/div[2]/div[2]/input");
        protected By AddressTextArea = By.Id("address");
        protected By PhoneInput = By.Id("phone");
        protected By AddButton = By.Id("addButton");

        public EmployeePage(IWebDriver driver)
            : base(driver)
        {
            if (!Driver.Title.Equals("AUT Form – TestFaceClub"))
                throw new Exception("This is not the Employee page");
        }

        public bool FormIsPresent()
        {
            return WaitHelper.ElementIsPresent(Driver, Form, 2);
        }

        public void AddEmployee(string name, string email, string address, string phone)
        {
            Driver.FindElement(NameInput).SendKeys(name);
            Driver.FindElement(EmailInput).SendKeys(email);
            Driver.FindElement(AddressTextArea).SendKeys(address);
            Driver.FindElement(PhoneInput).SendKeys(phone);
            Driver.FindElement(AddButton).Click();
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

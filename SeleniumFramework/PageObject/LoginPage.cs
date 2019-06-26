using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.PageObject
{
    public class LoginPage : BasePage
    {
        public By UserInput = By.Id("user");
        public By PassWordInput = By.Id("pass");
        public By LoginButton = By.Id("loginButton");

        public LoginPage(IWebDriver driver)
            :base(driver)
        {
            if (!Driver.Title.Equals("AUT Login – Verstand QA"))
                throw new Exception("This is not the login page");
        }

        public void TypeUserName(string user)
        {
            Driver.FindElement(UserInput).SendKeys(user);
        }

        public void TypePassword(string password)
        {
            Driver.FindElement(PassWordInput).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            Driver.FindElement(LoginButton).Click();
        }

        public EmployeePage LoginAs(string user, string password)
        {
            TypeUserName(user);
            TypePassword(password);
            ClickLoginButton();
            return new EmployeePage(Driver);
        }


    }
}

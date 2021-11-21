using OpenQA.Selenium;
using System;

namespace SeleniumFramework.PageObject
{
    public class LoginPage : BasePage
    {
        public By UserInput = By.Id("user");
        public By PassWordInput = By.Id("pass");
        public By LoginButton = By.Id("loginButton");

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            if (!Driver.Title.Equals("AUT Login – TestFaceClub"))
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

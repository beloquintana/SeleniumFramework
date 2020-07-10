using NUnit.Framework;
using SeleniumFramework.PageObject;

namespace SeleniumFramework.Test
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLogin()
        {
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin", "admin123");

            Assert.IsTrue(employeePage.FormIsPresent());
        }
    }
}

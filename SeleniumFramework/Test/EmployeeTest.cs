using NUnit.Framework;
using SeleniumFramework.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Test
{
    [TestFixture]
    public class EmployeeTest : BaseTest
    {
        private EmployeePage employeePage;

        [SetUp]
        public void BeforeTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            employeePage = loginPage.LoginAs("admin", "admin123");
        }

        [Test]
        public void AddEmployee()
        {
            employeePage.AddEmployee("Juan", "juan@gmail.com", "MTV", "598752022");
            Assert.IsTrue(employeePage.IsSuccessAlertPresent());
        }
    }
}

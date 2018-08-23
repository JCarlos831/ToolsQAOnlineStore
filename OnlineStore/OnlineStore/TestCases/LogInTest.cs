using NUnit.Framework;
using OnlineStore.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineStore.TestCases
{
    class LogInTest
    {
        [Test]
        public void Test()
        {
            Driver.driver.Navigate().GoToUrl("http://store.demoqa.com");

            var homePage = new HomePage();
            homePage.ClickOnMyAccount();

            var loginPage = new LoginPage();
            loginPage.LoginToApplication();

            Driver.driver.Close();
        }
    }
}

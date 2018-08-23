using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.PageObjects
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "log")][CacheLookup]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "pwd")][CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login")][CacheLookup]
        public IWebElement Submit { get; set; }
    }
}

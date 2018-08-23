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
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "pwd")][CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login")][CacheLookup]
        private IWebElement Submit { get; set; }

        public void LoginToApplication()
        {
            UserName.SendKeys("testuser_jc");
            Password.SendKeys("Test@123");
            Submit.Submit();
        }
    }


}

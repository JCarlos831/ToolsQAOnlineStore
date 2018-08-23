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
    class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

            [FindsBy(How = How.XPath, Using = "//*[@id=\"account\"]/a")][CacheLookup]
            public IWebElement MyAccount { get; set; }
    }
}

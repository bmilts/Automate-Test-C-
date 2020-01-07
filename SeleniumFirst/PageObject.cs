using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class PageObject
    {
        [Obsolete]
        public PageObject()
        {
            PageFactory.InitElements(Collections.driver, this);
        }

        [FindsBy(How = How.Name, Using = "userName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement textPassword { get; set; }

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.Id, Using = "tripType")]
        public IWebElement radioTripType { get; set; }

        [FindsBy(How = How.Id, Using = "fromPort")]
        public IWebElement dropFromPort { get; set; }

        [FindsBy(How = How.Id, Using = "toPort")]
        public IWebElement dropToPort { get; set; }

        [FindsBy(How = How.Id, Using = "servClass")]
        public IWebElement radioServClass { get; set; }

        [FindsBy(How = How.Name, Using = "findFlights")]
        public IWebElement btnContinue { get; set; }

        [FindsBy(How = How.Name, Using = "reserveFlights")]
        public IWebElement btnReserveContinue { get; set; }
    }
}

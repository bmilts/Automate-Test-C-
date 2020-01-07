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
        public IWebElement txtPassword { get; set; }

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

        [FindsBy(How = How.Name, Using = "passFirst0")]
        public IWebElement txtPassFirst { get; set; }

        [FindsBy(How = How.Name, Using = "passLast0")]
        public IWebElement txtPassLast { get; set; }

        [FindsBy(How = How.Name, Using = "creditnumber")]
        public IWebElement txtCardAmex { get; set; }

        [FindsBy(How = How.Name, Using = "ticketLess")]
        public IWebElement cboxTicketless { get; set; }

        [FindsBy(How = How.Name, Using = "buyFlights")]
        public IWebElement btnSecurePurchase { get; set; }
    }
}

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class MainClass
    {
        public static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize() {

            Collections.driver = new ChromeDriver();

            // 1. Navigate to testing page
            Collections.driver.Navigate().GoToUrl("http://newtours.demoaut.com/mercurywelcome.php");
            Console.WriteLine("Opened URL");

        }

        [Test]
        [Obsolete]
        public void ExecuteTest() {

            PageObject page = new PageObject();

            // 2.Login to Find a Flight authentication with the following credentials:
            // a.Username: mercury
            // SeleniumSetMethods.EnterText("userName", "mercury", PropertyType.Name);
            // POM
            page.txtUserName.SendKeys("mercury");

            // b.Password: mercury
            // SeleniumSetMethods.EnterText("password", "mercury", PropertyType.Name);
            // POM
            page.txtPassword.SendKeys("mercury");

            // Click Sign in button
            // SeleniumSetMethods.ClickElement( "login", PropertyType.Name);
            // POM
            page.btnLogin.Click();

            // 3.Select One Way radio button
            SeleniumSetMethods.SelectDropdown("tripType", "oneway", PropertyType.Id);

            // 4.Depart from Sydney
            SeleniumSetMethods.SelectDropdown( "fromPort", "Sydney", PropertyType.Id);

            // 5.Arrive in London
            SeleniumSetMethods.SelectDropdown( "toPort", "London", PropertyType.Id);

            // 6.Select First Class service class.
            SeleniumSetMethods.SelectDropdown("servClass", "First", PropertyType.Id);

            //7.     Click Continue
            // POM
            page.btnContinue.Click();

            //8.     On the Select Flight page click the Continue button.
            // POM
            page.btnReserveContinue.Click();

            //9.     Provide a First Name
            // POM
            page.txtPassFirst.SendKeys("John");

            //10.  Provide a Last Name
            page.txtPassLast.SendKeys("Doe");

            //11.  Provide a Credit Card Number
            page.txtCardAmex.SendKeys("378282246310005");

            //12.  Check the Ticketless Travel box.
            page.cboxTicketless.Click();

            //13.  Click the Secure Purchase button.
            page.btnSecurePurchase.Click();

            Console.WriteLine("Executed Test");

        }

        [TearDown]
        public void CleanUp() {
            Collections.driver.Quit();
            Console.WriteLine("Closed browser");
        }
    }
}

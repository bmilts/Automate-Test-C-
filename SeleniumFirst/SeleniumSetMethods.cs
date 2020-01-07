using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public class SeleniumSetMethods
    {

        // Enter text into field
        public static void EnterText(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            { 
                Collections.driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == PropertyType.Name) {
                Collections.driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }

        // Click button, checkbox, option etc
        public static void ClickElement(string element, PropertyType elementType)
        {

            if (elementType == PropertyType.Id)
            {
                Collections.driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == PropertyType.Name)
            {
                Collections.driver.FindElement(By.Name(element)).Click();
            }
        }


        // Selecting a dropdown control
        public static void SelectDropdown(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                new SelectElement(Collections.driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementType == PropertyType.Name)
            {
                new SelectElement(Collections.driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }
    }
}

using System;
using OpenQA.Selenium;

namespace SeleniumFirst
{
    public enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName,
    }

    public static class Collections
    { 
        public static IWebDriver driver { get; set; }
    }
}

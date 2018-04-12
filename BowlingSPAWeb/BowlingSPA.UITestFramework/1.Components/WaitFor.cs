using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BowlingSPA.UITestFramework._1.Components
{
    class WaitFor
    {
        public static WebDriverWait Five(IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public static WebDriverWait Ten(IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public static WebDriverWait Twenty(IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public static WebDriverWait Thirty(IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public static WebDriverWait Sixty(IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }
    }
}

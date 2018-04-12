using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BowlingSPA.UITestFramework._1.Components
{
    class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void InitialiseChrome()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--no-sandbox");

            Instance = new ChromeDriver(options);

            Instance.Manage().Window.Size = new System.Drawing.Size(1280, 1024);
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            TurnOnWait();
        }

        //public static void InitialiseIE()
        //{
        //    //InternetExplorerOptions options = new InternetExplorerOptions();
        //    //options.AddAdditionalCapability("ignoreZomSetting", true);

        //    Instance = new InternetExplorerDriver();

        //    Instance.Manage().Window.Size = new System.Drawing.Size(1280, 1024);
        //    Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
        //    TurnOnWait();
        //}

        //public static void InitialiseFirefox()
        //{
        //    Instance = new FirefoxDriver();

        //    Instance.Manage().Window.Size = new System.Drawing.Size(1280, 1024);
        //    Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
        //    TurnOnWait();
        //}

        public static void StartQuote(string environmentUrl)
        {
            Instance.Navigate().GoToUrl(environmentUrl);
        }

        public static void LoadPage(string environmentUrl)
        {
            Instance.Navigate().GoToUrl(environmentUrl);
        }

        public static void BrowserQuit(IWebDriver driver)
        {
            driver.Quit();
        }

        public static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        public static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }

        public void ClickByClassName(string className)
        {
            Instance.FindElement(By.ClassName(className)).Click();
        }
    }
}

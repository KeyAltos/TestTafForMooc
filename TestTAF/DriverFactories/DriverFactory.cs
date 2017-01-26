namespace TestTAF.DriverFactories
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;

    using TestTAF.DataModel;

    public static class DriverFactory
    {
        private static string DriverPath = @"C:\SeleniumDrivers";
        

        public static IWebDriver GetDriver(Browser browser)
        {
            IWebDriver webDriver;

            switch (browser)
            {
                case Browser.FF:
                    webDriver = new FirefoxDriver();
                    break;
                case Browser.Chrome:
                default:
                    webDriver = new ChromeDriver(DriverPath);
                    break;
            }

            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            return webDriver;
        }
    }
}
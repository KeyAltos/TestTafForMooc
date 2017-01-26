namespace TestTAF.DriverFactories
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Remote;

    using TestTAF.DataModel;

    public static class SingletonDriver
    {
        private static string DriverPath = @"C:\SeleniumDrivers";
        private static bool isDisposed = false;

        private static IWebDriver WebDriver;

        public static IWebDriver Instance
        {
            get
            {
                if (WebDriver == null)
                {
                    SetDriver(Browser.Chrome);
                }

                if (!isDisposed)
                {
                    return WebDriver;
                }
                
                throw new ArgumentNullException($"The only driver instance has been already disposed");
            }
        }

        public static void SetDriver(Browser browser)
        {
            if (isDisposed)
            {
                Console.WriteLine($"The only driver instance has been already disposed");
                return;
            }

            if (WebDriver != null)
            {
                Console.WriteLine($"Driver {((RemoteWebDriver)WebDriver).Capabilities.BrowserName} has been already created");
                return;
            }

            switch (browser)
            {
                case Browser.FF:
                    WebDriver = new FirefoxDriver();
                    break;
                case Browser.Chrome:
                default:
                    WebDriver = new ChromeDriver(DriverPath);
                    break;

            }

            WebDriver.Manage().Window.Maximize();
        }

        public static void DisposeDriver()
        {
            isDisposed = true;
            WebDriver.Quit();
            WebDriver = null;
        }

        public static void ClearDriver()
        {
            WebDriver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
namespace Tests.Singlton
{
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Newtonsoft.Json;

    using OpenQA.Selenium;

    using TestTAF.DataModel;
    using TestTAF.DriverFactories;

    [TestClass]
    [DeploymentItem(SourcePath, TestConfigFolder)]
    public class BaseSingltonDriverTest
    {
        protected static IWebDriver Driver;
        protected static TestSettings TestSettings;
        private const string SourcePath = @"TestConfigData\TestConfig.json";

        private const string TestConfigFolder = @"Resources";
        private const string TestConfigPath = @"Resources\TestConfig.json";
        
        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
            SingletonDriver.ClearDriver();
        }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext testContext)
        {
            RetrieveTestSettings();
            SingletonDriver.SetDriver(TestSettings.Browser);
            Driver = SingletonDriver.Instance;
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            SingletonDriver.DisposeDriver();
        }

        private static void RetrieveTestSettings()
        {
            TestSettings = JsonConvert.DeserializeObject<TestSettings>(File.ReadAllText($"{TestConfigPath}"));
        }
    }
}
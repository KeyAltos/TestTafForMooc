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
    public class BaseTest
    {
        protected static IWebDriver Driver;
        protected static TestSettings TestSettings;

        private const string SourcePath = @"TestConfigData\TestConfig.json";
        private const string TestConfigFolder = @"Resources";
        private const string TestConfigPath = @"Resources\TestConfig.json";
        
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext testContext)
        {
            RetrieveTestSettings();
        }

        private static void RetrieveTestSettings()
        {
            TestSettings = JsonConvert.DeserializeObject<TestSettings>(File.ReadAllText($"{TestConfigPath}"));
        }
    }
}
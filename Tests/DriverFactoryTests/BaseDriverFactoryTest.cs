namespace Tests.DriverFactoryTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Tests.Singlton;

    using TestTAF.DriverFactories;

    [TestClass]
    public class BaseDriverFactoryTest : BaseTest
    {
        [TestInitialize]
        public void TestInit()
        {
            Driver = DriverFactory.GetDriver(TestSettings.Browser);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Driver.Quit();
        }
    }
}
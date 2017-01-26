namespace Tests.SingltonTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Tests.Singlton;

    using TestTAF.DriverFactories;

    [TestClass]
    public class BaseSingltonDriverTest : BaseTest
    {
        public BaseSingltonDriverTest()
        {
            SingletonDriver.SetDriver(TestSettings.Browser);
            Driver = SingletonDriver.Instance;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            SingletonDriver.ClearDriver();
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            SingletonDriver.DisposeDriver();
        }
    }
}
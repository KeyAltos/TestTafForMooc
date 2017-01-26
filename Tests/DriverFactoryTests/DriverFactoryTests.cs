namespace Tests.DriverFactoryTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The singleton tests.
    /// </summary>
    [TestClass]
    public class DriverFactoryTests : BaseDriverFactoryTest
    {
        protected string TargetSite;

        [TestMethod]
        public void TestMetod11()
        {
            this.TargetSite = "google";

            Driver.Navigate().GoToUrl($"https://www.{this.TargetSite}.com");

            Assert.IsTrue(Driver.Url.Contains(this.TargetSite));
        }

        [TestMethod]
        public void TestMetod12()
        {
            this.TargetSite = "bbc";

            Driver.Navigate().GoToUrl($"https://www.{this.TargetSite}.com");

            Assert.IsTrue(Driver.Url.Contains(this.TargetSite));
        }
    }
}

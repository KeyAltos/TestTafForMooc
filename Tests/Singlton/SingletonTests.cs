namespace Tests.Singlton
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The singleton tests.
    /// </summary>
    [TestClass]
    public class SingletonTests : BaseSingltonDriverTest
    {
        protected string TargetSite;

        [TestMethod]
        public void TestMetod1()
        {
            this.TargetSite = "google";

            Driver.Navigate().GoToUrl($"https://www.{this.TargetSite}.com");

            Assert.IsTrue(Driver.Url.Contains(this.TargetSite));
        }

        [TestMethod]
        public void TestMetod2()
        {
            this.TargetSite = "bbc";

            Driver.Navigate().GoToUrl($"https://www.{this.TargetSite}.com");

            Assert.IsTrue(Driver.Url.Contains(this.TargetSite));
        }
    }
}

using AndroidAppiumTestsPOM.Pages;

namespace AndroidAppiumTestsPOM.Tests
{
    public class CalculatorTests :BaseTests
    {

        private Calculator page;

        [SetUp]
        public void Setup()
        {
            this.page = new Calculator(driver);
        }

        [Test]
        public void Test_TwoPositiveNumbers()
        {
            var result = page.CalculateTwoNumbers("10", "5");
            Assert.That(result, Is.EqualTo("15"));
        }

        [Test]
        public void Test_InvalidNumbers()
        {
            var result = page.CalculateTwoNumbers("10", "bbbb");
            Assert.That(result, Is.EqualTo("error"));
        }

    }
}
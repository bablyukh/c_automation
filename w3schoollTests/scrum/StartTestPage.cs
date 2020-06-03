using w3schoollAutomation.Pages;
using NUnit.Framework;


namespace w3schoollTests
{
    [TestFixture]
    public class StartTestPageTests : BaseUITest
    {

        private StartTestPage startTestPage = new StartTestPage();

        [SetUp]
        public void InitPageAndGoToTests()
        {
            startTestPage.Init(driver);
        }

        [Test]
        public void testCorrectPageHeader()
        {
            Assert.AreEqual(startTestPage.GetPageHeader(), "Scrum Open", "Wrong page header");
        }

    }
}

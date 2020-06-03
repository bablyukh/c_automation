using w3schoollAutomation.Pages;
using NUnit.Framework;
using w3schoollAutomation;


namespace w3schoollTests
{
    [TestFixture]
    public class ScrumTests : BaseUITest
    {

        private TestPage testPage;

        [OneTimeSetUp]
        public void InitPageAndGoToTests()
        {
            StartTestPage startTestPage = new StartTestPage();
            startTestPage.Init(driver);
            testPage = startTestPage.
                 clickContinue().
                 clickStart();
        }

        [Test, Order(1)]
        public void testWhenClickStartUserCanSeeFirtsQuestion()
        {
            Assert.AreEqual(testPage.GetQuestionNumberHeaderText(), "Question 1 of 30");
        }


        [Test]
        public void testUserCanChooseAnswerAndWhenClickNextHeWillRedirectToNextQuestion()
        {
            int currentQuestion = testPage.getCurrentQuestionNumber();
            testPage.
                  chsooseAnswer().
                  clickNext();
            Assert.AreEqual(testPage.GetQuestionNumberHeaderText(), "Question " + (currentQuestion + 1) + " of 30");
        }


        [Test]
        public void testUserCanClickPrevious()
        {
            testPage.
                  chsooseAnswer().
                  clickNext();
            int currentQuestion = testPage.getCurrentQuestionNumber();
            testPage.
                  chsooseAnswer().
                  clickPrevious();
            Assert.AreEqual(testPage.GetQuestionNumberHeaderText(), "Question " + (currentQuestion - 1) + " of 30");
        }


    }
}

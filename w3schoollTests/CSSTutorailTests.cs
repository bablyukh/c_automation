using NUnit.Framework;
using w3schoollAutomation.Pages.CSS;

namespace w3schoollTests
{
    //  [TestFixture]
    public class CSSTutorailTests : BaseUITest
    {

        private CSSTutorialPage page = new CSSTutorialPage();
        [SetUp] 
        public void InitTestPage()
        {
            page.Init(driver);
        }

        [Test]
        public void verifyTitleWhenOpenCSSTutorialPage()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - verify title correct and pageHeader correct
            */
        }

        [Test]
        public void verifyUserCanClickNextFromCSS()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Next button
            - verify title correct and pageHeader correct
            */
        }

        [Test]
        public void verifyUserCanClickHomeFromCSS()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Home button
            - verify title correct and pageHeader correct
            */
        }


        [Test]
        public void verifyUserCanClickNextButtonSecondTime()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Next button
            - click Next button
            - verify title correct and pageHeader correct
            */
        }

        [Test]
        public void verifyUserCanClickPreviousButton()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Next button
            - click ❮ Previous  button 
            - verify title correct and pageHeader correct
            */
        }
    }
}

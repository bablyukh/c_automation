using OpenQA.Selenium;

namespace w3schoollAutomation.Pages
{

    public class StartTestPage : AbstarctPage<StartTestPage>
    {


        private IWebElement PageHeader
        {
            get
            {
                return driver.FindElement(By.CssSelector(".classmarker_content_inner > h1"));
            }
        }

        private IWebElement ContinueButton
        {
            get
            {
                return driver.FindElement(By.CssSelector("a.blocklink"));
            }
        }

        private IWebElement StartButton
        {
            get
            {
                return driver.FindElement(By.CssSelector("input.blocklink"));
            }
        }

        public string GetPageHeader()
        {
            return PageHeader.Text;
        }

        public StartTestPage clickContinue()
        {
            ContinueButton.Click();
            return this;
        }

        public TestPage clickStart()
        {
            StartButton.Click();
            TestPage page = new TestPage();
            page.Init(driver);
            return page;
        }

        public override StartTestPage Init(IWebDriver _driver)
        {
            this.driver = _driver;
            return this;
        }
    }
}

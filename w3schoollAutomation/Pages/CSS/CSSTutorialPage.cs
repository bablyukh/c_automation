using OpenQA.Selenium;

namespace w3schoollAutomation.Pages.CSS
{
    public class CSSTutorialPage : AbstarctPage<CSSTutorialPage>
    {
        public override CSSTutorialPage Init(IWebDriver _driver)
        {
            this.driver = _driver;
            driver.Navigate().GoToUrl("https://www.w3schools.com/css/default.asp");
            return this;
        }


    }
}

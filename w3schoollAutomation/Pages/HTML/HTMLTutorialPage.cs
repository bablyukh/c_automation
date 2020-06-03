using OpenQA.Selenium;

namespace w3schoollAutomation.Pages.HTML
{
    public class HTMLTutorialPage : AbstarctPage<HTMLTutorialPage>
    {
        public override HTMLTutorialPage Init(IWebDriver _driver)
        {
            this.driver = _driver;
            driver.Navigate().GoToUrl("https://www.w3schools.com/html/default.asp");
            return this;
        }

        public HTMLTutorialPage ClickNext()
        {
            driver.FindElement(By.CssSelector("#main > div.nextprev > a.w3-right.w3-btn"))
                .Click();
            return this;
        }

        public HTMLTutorialPage ClickHome()
        {
            driver.FindElement(By.CssSelector("#main > div.nextprev > a.w3-left.w3-btn")).Click();
            return this;
        }

        public HTMLTutorialPage ClikPrevious()
        {
            return this;
        }


        public string GetTitle()
        {
            return driver.Title;
        }

        public string GetPageHeader()
        {
            return driver.FindElement(By.CssSelector("#main > h1")).Text;
        }



        public bool isAt
        {
            get
            {
                return GetTitle()
                .Equals("HTML Tutorial") && GetPageHeader().Equals("HTML Tutorial");
            }
        }
    }
}

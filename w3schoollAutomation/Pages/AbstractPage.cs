using OpenQA.Selenium;

namespace w3schoollAutomation.Pages
{
    public abstract class AbstarctPage<T> : IWebDriverHolder
    {
        protected IWebDriver driver;
        public IWebDriver GetDriver()
        {
            return driver;
        }

        public void OpenPage(string LinkText)
        {
            var pageLink = driver.FindElement(By.LinkText(LinkText));
            pageLink.Click();
        }

        public abstract T Init(IWebDriver driver);

        object IWebDriverHolder.Init(IWebDriver _driver)
        {
            this.driver = _driver;
            return this;
        }
    }
}

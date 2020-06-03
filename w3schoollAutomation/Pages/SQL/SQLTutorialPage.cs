using OpenQA.Selenium;

namespace w3schoollAutomation.Pages.SQL
{
    public class SQLTutorialPage : AbstarctPage<SQLTutorialPage>
    {
        public bool isAt
        {
            get
            {
                // IWebElement SQLTutorialLink = Driver.Instance.FindElements(By.CssSelector("#main > h1"))[0];
                return driver.Title.Equals("SQL Tutorial") && this.GetPageHeader().Equals("SQL Tutorial");
            }
        }

        private IWebElement PageHeader
        {
            get
            {
                return driver.FindElement(By.CssSelector("#main > h1"));
            }
        }

        private IWebElement RunSQLButton
        {
            get
            {
                return driver.FindElement(By.CssSelector("#main > div.w3-example > a"));
            }
        }

        public string GetPageHeader()
        {
            return PageHeader.Text;
        }

        public SqlEditorPage OpenSqlEditor()
        {
            RunSQLButton.Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            return new SqlEditorPage();
        }

        public override SQLTutorialPage Init(IWebDriver _driver)
        {
            this.driver = _driver;
            driver.Navigate().GoToUrl("https://www.w3schools.com/sql/default.asp");
            return this;
        }
    }
}

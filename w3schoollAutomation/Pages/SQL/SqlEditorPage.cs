using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using w3schoollAutomation.Pages;
using w3schoollAutomation.Pages.SQL;

namespace w3schoollAutomation
{
    public class SqlEditorPage : AbstarctPage<SqlEditorPage>
    {
        public bool isAt
        {
            get
            {
                return driver.Title.Equals("SQL Tryit Editor v1.6");
            }
        }

        public SQLTutorialPage BackToTutorialsPage()
        {
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            return new SQLTutorialPage();
        }

        public Dictionary<string, string> GetQueryResults()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("iframeResultSQL")));
            IWebElement queryResultDiv = driver.FindElement(By.TagName("table"));
            var queryResults = new Dictionary<string, string>();
            var sElements = queryResultDiv.FindElements(By.TagName("tr"));
            var elementHEaders = queryResultDiv.FindElements(By.TagName("th"));
            string[] keys = new string[elementHEaders.Count];
            for (int i = 0; i < elementHEaders.Count; i++)
            {
                keys[i] = elementHEaders[i].Text;
            }
            foreach (var item in sElements)
            {
                var tt = item.Text;
                var tdElements = item.FindElements(By.TagName("td"));
                for (int i = 0; i < tdElements.Count; i++)
                {
                    queryResults.Add(keys[i], tdElements[i].Text);
                }
            }
            driver.SwitchTo().DefaultContent();

            return queryResults;
        }

        public override SqlEditorPage Init(IWebDriver _driver)
        {
            this.driver = _driver;
            driver.Navigate().GoToUrl("https://www.w3schools.com/sql/trysql.asp?filename=trysql_select_all");
            return this;
        }
    }
}

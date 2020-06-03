using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace w3schoollAutomation.Pages
{
    public class TestPage : AbstarctPage<TestPage>
    {

        public TestPage chsooseAnswer()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, this.CheckBoxAnswers.Count);
            this.CheckBoxAnswers[i].Click();
            return this;
        }


        public  DefaultWait<IWebDriver> fluentWait(){
          DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            return fluentWait;
        }

        public TestPage waitForContentReloaded(string oldQuestionId)
        {
            fluentWait().Until(x => !oldQuestionId.Equals(CurrentGuestionID));
            return this;
        }

        public TestPage clickNext()
        {
            string id = CurrentGuestionID;
            this.NextButton.Click();
            return waitForContentReloaded(id);
        }

        public TestPage clickPrevious()
        {
            string id = CurrentGuestionID;
            this.PreviousButton.Click();
            return waitForContentReloaded(id);
        }

        public string GetQuestionNumberHeaderText()
        {
            return this.QuestionNumberHeader.Text;
        }

        public int getCurrentQuestionNumber()
        {
            string[] words = this.QuestionNumberHeader.Text.Split(' ');
            return Int16.Parse(words[1]);
        }

        public override TestPage Init(IWebDriver _driver)
        {
            this.driver = _driver;
            return this;
        }

        private IWebElement NextButton
        {
            get
            {
                return driver.FindElement(By.Id("qnext"));
            }
        }


        private IWebElement PreviousButton
        {
            get
            {
                return driver.FindElement(By.Id("qprev"));
            }
        }



        private string CurrentGuestionID
        {
            get
            {
                return driver.FindElement(By.CssSelector("div.single_question_box>a")).GetAttribute("id");
            }
        }


        private IWebElement QuestionNumberHeader
        {
            get
            {
                return driver.FindElement(By.CssSelector("div.qboxprogress>h2"));
            }
        }
        private ReadOnlyCollection<IWebElement> CheckBoxAnswers
        {
            get
            {
                return driver.FindElements(By.CssSelector(".qfieldset input"));
            }
        }
    }
}

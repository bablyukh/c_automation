using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;


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



        public TestPage clickNext()
        {
            this.NextButton.Click();
            return this;
        }

        public TestPage clickPrevious()
        {
            this.PreviousButton.Click();
            return this;
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

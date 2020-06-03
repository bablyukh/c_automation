using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace w3schoollTests
{
    [Parallelizable(ParallelScope.Fixtures)]
    public abstract class BaseUITest
    {
        public IWebDriver driver { get; set; }
        public static string baseURL
        {
            get
            {
                return "https://www.classmarker.com/online-test/start/?quiz=vek54a6ec10658ef";
            }
        }


        [OneTimeSetUp]
        public void Init()
        {
            this.driver = new ChromeDriver(@"c:\tools");
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            this.driver.Manage().Window.Maximize();
            this.driver.Url = baseURL;
        }


        //This method will executed after each test cases
        [OneTimeTearDown]
        public void TeardownTest()
        {
            //closing browser
            this.driver.Close();
        }

    }
}

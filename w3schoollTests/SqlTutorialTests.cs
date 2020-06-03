using NUnit.Framework;
using w3schoollAutomation;
using w3schoollAutomation.Pages.SQL;

namespace w3schoollTests
{

    [TestFixture]
    class SqlTutorialTests : BaseUITest
    {
        SQLTutorialPage page = new SQLTutorialPage();
        [SetUp]
        public void InitTestPage() => page.Init(driver);

        //Test method
        [Test]
        public void UserCanOpenSQLTutorialsPage()
        {
            /* Test Case:
            - Open https://www.w3schools.com
            - click on link Learn SQL
            - Verify "SQL Tutorial" page opened
             */
            Assert.True(page.isAt);
        }


        //Test method
        [Test]
        public void User_Can_Open_SQL_Editor_Page()
        {
            /* Test Case:
            - Open https://www.w3schools.com
            - click on link Learn SQL
            - Click on "Run SQL" button
            - Verify SQL Editor page opened
             */
            SqlEditorPage editorPage = page.OpenSqlEditor();
            Assert.True(editorPage.isAt);
            page = editorPage.BackToTutorialsPage();
            Assert.True(page.isAt);
        }
    }
}

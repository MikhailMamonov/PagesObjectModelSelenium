using PagesObjectModelSelenium.Pages;

namespace PagesObjectModelSelenium.Tests
{
    [TestFixture]
    public class HomeTest : BaseTest
    {
        private LoginPage _loginPage;
        private HomePage _homePage;
        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(Driver);
            _loginPage.Login("admin","admin");

            _homePage = new HomePage(Driver);
        }
        
        [Test(Description = "Verify that rows has been filtered. ")]
        [TestCase("123",0)]
        [TestCase("admin", 1)]
        [TestCase("",5)]
        public void TestRowsHasBeenFiltered (string filter, int expectedValue)
        {
            _homePage.ChangeTextInLoginFilterField(filter);
            var rowsCount = _homePage.GetRowCount();
            Assert.That(rowsCount,Is.EqualTo(expectedValue));
        }


    }
}

using PagesObjectModelSelenium.Pages;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagesObjectModelSelenium.Tests
{
    [TestFixture]
    public class AddUserTest : BaseTest
    {
        private LoginPage _loginPage;
        private HomePage _homePage;
        private AddUserPage _addUserPage;
        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(Driver);
            _loginPage.Login("admin","admin");

            _homePage = new HomePage(Driver);

            _homePage.ClicklAddUserButton();

            _addUserPage = new AddUserPage(Driver);

        }

        [Test(Description = "Verify that rows has been filtered. ")]
        //[TestCase("test","testov","Test@gmail.com")]
        //[TestCase("Administrator","Platform","admin@me.com")]
        [TestCase("test2","Testov2","9056464545")]
        public void TestRowsHasBeenFiltered(string firstName,string lastName, string email)
        {
            var startRowsCount = _homePage.GetRowCount();
            _addUserPage.SetFirstName(firstName);
            _addUserPage.SetLastName(lastName);
            _addUserPage.SetEmail(email);
            _addUserPage.ClickAddButton();
            var rowsCountAfterAdd = _homePage.GetRowCount();

            Assert.That(startRowsCount+1,Is.EqualTo(rowsCountAfterAdd));
        }
    }
}

using PagesObjectModelSelenium.Pages;

namespace PagesObjectModelSelenium.Tests
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        private LoginPage _loginPage;

        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(Driver);
        }

        [Test(Description = "Verify that a user can login to the application with valid credentials")]
        public void TestValidUserLogin()
        {
            _loginPage.Login("admin","admin");
            Assert.That("ИНКА 4.0", Is.EqualTo(Driver.Title));
        }

        [Test(Description = "Verify that a user cannot login to the application with invalid credentials")]
        public void TestInvalidUserLogin()
        {
            _loginPage.Login("test","test");
            Assert.That("Sign in to stage",Is.EqualTo(Driver.Title));
        }
    }
}

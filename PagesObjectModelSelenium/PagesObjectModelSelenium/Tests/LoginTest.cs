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
        [TestCase("admin","admin")]
        public void TestValidUserLogin(string login, string password)
        {
            _loginPage.Login(login,password);
            Assert.That("Заголовок формы", Is.EqualTo(Driver.Title));
        }

        [Test(Description = "Verify that a user cannot login to the application with invalid credentials")]
        [TestCase("test","test")]
        public void TestInvalidUserLogin(string login,string password)
        {
            _loginPage.Login(login,password);
            Assert.That("Sign in to stage",Is.EqualTo(Driver.Title));
        }
    }
}

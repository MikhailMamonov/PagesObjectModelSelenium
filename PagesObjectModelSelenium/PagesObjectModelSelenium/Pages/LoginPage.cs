using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagesObjectModelSelenium.Pages
{
    internal class LoginPage: BasePage
    {
        private readonly By _usernameTextBox = By.Id("username");
        private readonly By _passwordTextBox = By.Id("password");
        private readonly By _signInButton = By.Id("kc-login");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void SetUsername(string username)
        {
            SendKeys(_usernameTextBox,username);
        }

        public void SetPassword(string password)
        {
            SendKeys(_passwordTextBox,password);
        }

        public void ClickSignInButton()
        {
            Click(_signInButton);
        }

        public void Login(string email,string password)
        {
            SetUsername(email);
            SetPassword(password);
            ClickSignInButton();
        }
    }
}

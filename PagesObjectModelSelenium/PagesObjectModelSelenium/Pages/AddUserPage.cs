

using OpenQA.Selenium;

namespace PagesObjectModelSelenium.Pages;

public class AddUserPage : BasePage
{
    private readonly By _usernameTextBox = By.Id("username");
    private readonly By _passwordTextBox = By.Id("password");
    private readonly By _signInButton = By.Id("kc-login");

    public AddUserPage(IWebDriver driver) : base(driver)
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


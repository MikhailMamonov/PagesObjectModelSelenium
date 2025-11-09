

using OpenQA.Selenium;

namespace PagesObjectModelSelenium.Pages;

public class AddUserPage : BasePage
{
    private readonly By _firstNameTextBox = By.Id("mat-input-8");
    private readonly By _lastNameTextBox = By.Id("mat-input-9");
    private readonly By _emailTextBox = By.Id("mat-input-10");
    private readonly By _addButton = By.CssSelector("mdc-button.mat-mdc-button-base.web-component.inka-ui-button.inka-ui-button__full-width.mdc-button--unelevated.mat-mdc-unelevated-button.mat-primary"); 


    public AddUserPage(IWebDriver driver) : base(driver)
    {
    }

    public void SetFirstName(string username)
    {
        SendKeys(_firstNameTextBox,username);
    }

    public void SetLastName(string password)
    {
        SendKeys(_lastNameTextBox,password);
    }

    public void SetEmail(string password)
    {
        SendKeys(_emailTextBox,password);
    }

    public void ClickAddButton()
    {
        Click(_addButton);
    }
}


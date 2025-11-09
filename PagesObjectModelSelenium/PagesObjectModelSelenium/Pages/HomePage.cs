using NUnit.Framework;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace PagesObjectModelSelenium.Pages
{
    [TestFixture]
    public class HomePage:BasePage
    {
        private readonly By _loginInput = By.Id("mat-input-0");
        private readonly By _rowContainer = By.ClassName("ag-center-cols-container");
        private readonly By _addUserButton = By.CssSelector("mdc-button.mat-mdc-button-base.web-component.inka-ui-button.inka-ui-button__full-width mdc-button--unelevated.mat-mdc-unelevated-button.mat-primary");


        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void SetLogin(string login)
        {
            SendKeys(_loginInput,login);
        }

        public void ClicklLoginInputField()
        {
            Click(_loginInput);
        }

        public void DoubleClicklNameField()
        {
            DoubleClick(_loginInput);
        }

        public void ChangeTextInLoginFilterField(string login)
        {
            ClicklLoginInputField();
            SetLogin(login);
        }

        public void ClicklAddUserButton()
        {
            Click(_loginInput);
        }

        public int GetRowCount() {
            var childElements =  GetChildElements(_rowContainer);
            return childElements.Count();
        }

    }
}

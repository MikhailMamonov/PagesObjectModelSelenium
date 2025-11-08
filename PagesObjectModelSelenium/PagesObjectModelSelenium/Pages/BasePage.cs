using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

using System.Collections.ObjectModel;

using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace PagesObjectModelSelenium.Pages
{
    public class BasePage
    {
        private readonly IWebDriver _driver;

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
        }


        protected void WaitUntilElementVisible(By by)
        {
            var wait = new WebDriverWait(_driver,TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected IWebElement GetElement(By by)
        {
            WaitUntilElementVisible(by);
            return _driver.FindElement(by);
        }

        protected ReadOnlyCollection<IWebElement> GetChildElements(By by)
        {
            var parentElement = GetElement(by);
            return parentElement.FindElements(By.XPath("*"));
        }

        protected void Click(By by)
        {
            WaitUntilElementVisible(by);
            _driver.FindElement(by).Click();
        }

        protected void SendKeys(By by,string text)
        {
            WaitUntilElementVisible(by);
            _driver.FindElement(by).SendKeys(text);
        }



        protected void DoubleClick(By by)
        {
            WaitUntilElementVisible(by);
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(by)).DoubleClick();
           
        }
    }
}

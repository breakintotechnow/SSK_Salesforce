using OpenQA.Selenium;
using SSK_Salesforce.src.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSK_Salesforce.src.Pages
{
    public class SalesforceLoginPage : BasePage
    {

        protected IWebDriver Driver;

        public SalesforceLoginPage(IWebDriver driver) : base(driver)
        {

            this.Driver = driver;
        }

        private By usernameBy = By.Id("username");
        private IWebElement usernameField => Driver.FindElement(usernameBy);

        private By passwordBy = By.Id("password");
        private IWebElement passwordField => Driver.FindElement(passwordBy);

        private By loginButtonBy = By.Id("Login");
        private IWebElement loginBtn => Driver.FindElement(loginButtonBy);

        private By searchHeaderBy = By.ClassName("slds-global-header__item_search");
        private IWebElement searchHeader => Driver.FindElement(searchHeaderBy);

        private By appLauncherBy = By.XPath("//button[@title='App Launcher']");
        private IWebElement appLauncher => Driver.FindElement(appLauncherBy);


        public void GoToLoginPage(String url)
        {
            Driver.Navigate().GoToUrl(url);

        }

        public void Login(string username, string password)
        {
            Wait.UntilVisible(usernameBy);
            usernameField.SendKeys(username);

            Wait.UntilVisible(passwordBy);
            passwordField.SendKeys(password);

            Wait.UntilVisible(loginButtonBy);
            actions.Click(loginBtn).Perform();
        }

        public bool SearchHeaderFound()
        {

            Wait.UntilVisible(searchHeaderBy);
            return searchHeader.Displayed;

        }
        public bool AppLauncherFound()
        {

            Wait.UntilVisible(appLauncherBy);
            return appLauncher.Displayed;

        }



    }
}
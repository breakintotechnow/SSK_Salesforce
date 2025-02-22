using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSK_Salesforce.src.Utilities
{
    public class WaitUtilities
    {

        private IWebDriver driver;
        private IWebDriver driver1;
        private readonly WebDriverWait wait;

        public WaitUtilities(IWebDriver driver)
        {

            this.driver = driver;

            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        }


        public void UntilVisible(By locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public void UntilClickable(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

        public void UntilTextPresentIn(By locator, string text)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(locator, text));
        }

        public IWebElement WaitForElement(By locator)
        {
            return wait.Until(ExpectedConditions.ElementExists(locator));
        }


    }
}
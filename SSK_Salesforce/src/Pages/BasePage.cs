using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SSK_Salesforce.src.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSK_Salesforce.src.Pages
{

    public class BasePage
    {
        public IWebDriver Driver;
        public WaitUtilities Wait;
        public Actions actions;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            Wait = new WaitUtilities(driver);
            this.actions = new Actions(driver);

        }



    }
}

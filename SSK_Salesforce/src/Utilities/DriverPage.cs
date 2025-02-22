using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSK_Salesforce.src.Utilities
{
    public class DriverPage
    {
        public static IWebDriver Driver;

        public DriverPage() { }

        public static IWebDriver GetDriver()
        {
            if (Driver == null)
            {
                InitializeDriver();
            }
            return Driver;
        }

        public static void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("disable-popup-blocking", "true");
            options.AddArguments("--disable-gpu");
            options.AddArguments("--disable-extensions");
            options.AddArguments("--proxy-server='direct://'");
            options.AddArguments("--proxy-bypass-list=*");
            options.AddArguments("--start-maximized");
            options.AddArguments("--no-sandbox");
            options.AddArguments("--incognito");

            Driver = new ChromeDriver(options);
        }
    }

}
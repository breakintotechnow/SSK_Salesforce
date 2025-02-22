using OpenQA.Selenium;
using SSK_Salesforce.src.Pages;
using SSK_Salesforce.src.Utilities;

namespace SSK_Salesforce.src.Tests
{
  
    [TestFixture]
    public class SalesforceLoginTest
    {
        public IWebDriver Driver;
        public SalesforceLoginPage salesforceLoginPage;
        private string url;
        private string username;
        private string password;


        [SetUp]
        public void Setup()
        {
            CredentialManager credentials = CredentialManager.LoadCredentials();

            url = credentials.Url;
            username = credentials.LoginName;
            password = credentials.Password;



            this.Driver = DriverPage.GetDriver();
            salesforceLoginPage = new SalesforceLoginPage(Driver);



        }

        [Test]
        [Order(0)]
        public void LoginTest()
        {
            salesforceLoginPage.GoToLoginPage(url);
            salesforceLoginPage.Login(username, password);

            Assert.That(salesforceLoginPage.AppLauncherFound(), Is.True);
        }




        [TearDown]
        public void MyTestCleanup()
        {
            Driver.Dispose();
            Driver.Quit();
        }
    }
}
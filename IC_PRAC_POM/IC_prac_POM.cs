using IC_PRAC_POM.Login_Page;
using IC_PRAC_POM.Logoff_Page;
using IC_PRAC_POM.Verifiy_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ICAutomation_prac1
{
    public class Tests
    {        
        IWebDriver driver;
        Login_Page login = new Login_Page();
        Logoff_Page logoff = new Logoff_Page();
        Verify_Page verify = new Verify_Page();

        [SetUp]
        public void Setup()
        {
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //Navigate to the website
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
          
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }

        [Test]
        public void VerifyUserCanLogInOutToHorsePortal()
        {
            login.User_Login(); // login
            verify.User_Verify(); // username verification
            logoff.User_Logoff(); // logoff
            var currentBrowserUrl = driver.Url;
            Assert.AreEqual("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f", currentBrowserUrl);
        }

        


       


    }

}
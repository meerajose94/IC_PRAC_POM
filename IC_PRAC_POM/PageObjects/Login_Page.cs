using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace IC_PRAC_POM.Login_Page
{
    class Login_Page
    {
        IWebDriver driver;
        public void User_Login()
        {
            // Find locator for username and pwd and send value
            driver.FindElement(By.CssSelector("input[id= UserName]")).SendKeys("hari");
            driver.FindElement(By.CssSelector("input[id= Password]")).SendKeys("123123");
            driver.FindElement(By.CssSelector("input[type=submit]")).Click();
        }
    }
}

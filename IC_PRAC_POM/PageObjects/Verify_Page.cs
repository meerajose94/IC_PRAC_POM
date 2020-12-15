using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IC_PRAC_POM.Verifiy_Page
{
    class Verify_Page
    {
        IWebDriver driver;
        public void User_Verify()
        {
            //Verify user name
            var username = driver.FindElements(By.CssSelector("a[data-toggle=dropdown]"))[1].Text;
            Assert.AreEqual(username, "Hello hari!");

        }
    }
}

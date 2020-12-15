using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IC_PRAC_POM.Logoff_Page
{
    class Logoff_Page
    {
        IWebDriver driver;
        public void User_Logoff()
        {
            //Verify user can logoff
            driver.FindElements(By.CssSelector("a[data-toggle=dropdown]"))[1].Click();
            driver.FindElement(By.LinkText("Log off")).Click();

        }
    }
}

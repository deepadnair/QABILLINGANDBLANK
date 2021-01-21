using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QAautomtest.NewFolder
{
    class BlankLoginPage
    {
        public void BlankLogin(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://qaauto.co.nz/test-blank-form/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("input[id='wpforms-locked-16-field_form_locker_password']")).SendKeys("Testing");
            driver.FindElement(By.CssSelector("button[id='wpforms-submit-locked-16']")).Click();
        }
    }
}

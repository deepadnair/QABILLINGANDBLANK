using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QAautomtest.NewFolder
{
    class BlankBillingForm
    {

        IWebDriver driver;

        public BlankBillingForm(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void firstName(String firstName)
        {
            driver.FindElement(By.CssSelector("input[id='wpforms-16-field_0']")).SendKeys(firstName);
        }
        public void lastName(String lastName)
        {
            driver.FindElement(By.CssSelector("input[id='wpforms-16-field_0-last']")).SendKeys(lastName);
        }

        public void email(String email)
        {
            driver.FindElement(By.CssSelector("input[id='wpforms-16-field_1']")).SendKeys(email);
        }

        public void comment(String comment)
        {
            driver.FindElement(By.CssSelector("textarea[id='wpforms-16-field_2']")).SendKeys(comment);
        }

        public void submit()
        {
            driver.FindElement(By.CssSelector("button[id=wpforms-submit-16]")).Click();
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace QAautomtest.NewFolder
{
    public class BillingPage
    {
        IWebDriver driver;

        public BillingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public BillingPage()
        {
        }

        public void firstName(String firstName)
        {
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_0]")).SendKeys(firstName);
        }
        public void lastName(String lastName)
        {
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_0-last]")).SendKeys(lastName);
        }

        public void email(String email)
        {
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_1]")).SendKeys(email);
        }
        public void phone(String phone)
        {
            driver.FindElement(By.CssSelector("input[id='wpforms-24-field_2']")).SendKeys(phone);
        }
        public void addressLine1(String addressLine1)
        {
            driver.FindElement(By.CssSelector("input[id='wpforms-24-field_3']")).SendKeys(addressLine1);
        }

               public void addressLine2(String addressLine2)
        {
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_3-address2]")).SendKeys(addressLine2);
        }
        public void city(String city)
        {
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_3-city]")).SendKeys(city);
        }
        public void state(String state)
        {
            new SelectElement(driver.FindElement(By.Id("wpforms-24-field_3-state"))).SelectByText(state);
        }
        public void postal(String postal)
        {
            driver.FindElement(By.CssSelector("input[id=wpforms-24-field_3-postal]")).SendKeys(postal);
        }
        public void comment(String comment)
        {
            driver.FindElement(By.CssSelector("textarea[id=wpforms-24-field_6]")).SendKeys(comment);
        }

        public void itemnumber( int val)
        {

            if (val == 1)
            {
                driver.FindElement(By.Id("wpforms-24-field_4_1")).Click();
            }
            else if (val == 2)
            {
                driver.FindElement(By.Id("wpforms-24-field_4_2")).Click();
            }
            else if (val == 3)
            {
                driver.FindElement(By.Id("wpforms-24-field_4_3")).Click();
            }
        }
        public void submit()
        {
            driver.FindElement(By.CssSelector("button[id=wpforms-submit-24]")).Click();
        }
    }
}
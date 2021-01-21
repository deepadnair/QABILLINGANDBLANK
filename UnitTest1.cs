using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QAautomtest.NewFolder;
using System;

namespace QAautomtest
{
    public class Tests
    {
        IWebDriver driver;
        LoginPage login = new LoginPage();
        BlankLoginPage Blogin = new BlankLoginPage();
        


        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
          //  driver.Navigate().GoToUrl("http://qaauto.co.nz/billing-order-form/");
         //   driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void TearDown()
        {
             driver.Close();
             driver.Dispose();
        }
        [Test, Order(1)]
        public void Test1()
        {
            login.Login(driver);
            BillingPage billing = new BillingPage(driver);
            billing.firstName("Amith");
            billing.lastName("singh");
            billing.email("Amiths@gmail.com");
            billing.phone("1212131412");
            billing.addressLine1("agagdh");
            billing.addressLine2("jhjskfhghgh");
            billing.city("city");
            billing.state("Alaska");
            billing.postal("12121-2121");
            billing.itemnumber(3);
            billing.comment("Please Add some comments here");
            billing.submit();
           
      
       }
        [Test, Order(2)]
        public void Test2()
        {
            Blogin.BlankLogin(driver);
            BlankBillingForm BBilling = new BlankBillingForm(driver);
            BBilling.firstName("Amith");
            BBilling.lastName("singh");
            BBilling.email("Amiths@gmail.com");
           BBilling.comment("Please Add some comments here");
           BBilling.submit();

        }
    }
    }

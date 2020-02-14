﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookPracticTests
{
    [TestFixture]
    public class ContactCreationTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void ContactCreationTest()
        {
            OpenHomePage();
            Login("admin", "password");
            InitContactCreation();
            FillContactForm();
            SubmitContactCreation();
            GoToGroupsPage();
            Logout();
        }

        private void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/index.php");
        }

        private void Login(string user, string password)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(user);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        private void InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void FillContactForm()
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys("1233");
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys("233445");
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys("fhgjhhjy");
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys("werertdtgfg");
            driver.FindElement(By.Name("title")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/form/label[7]")).Click();
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys("srdtrfdf");
        }

        private void SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
        }

        private void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }

        private void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        //private bool IsElementPresent(By by)
        //{
        //    try
        //    {
        //        driver.FindElement(by);
        //        return true;
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return false;
        //    }
        //}

        //private bool IsAlertPresent()
        //{
        //    try
        //    {
        //        driver.SwitchTo().Alert();
        //        return true;
        //    }
        //    catch (NoAlertPresentException)
        //    {
        //        return false;
        //    }
        //}

        //private string CloseAlertAndGetItsText()
        //{
        //    try
        //    {
        //        IAlert alert = driver.SwitchTo().Alert();
        //        string alertText = alert.Text;
        //        if (acceptNextAlert)
        //        {
        //            alert.Accept();
        //        }
        //        else
        //        {
        //            alert.Dismiss();
        //        }
        //        return alertText;
        //    }
        //    finally
        //    {
        //        acceptNextAlert = true;
        //    }
        //}
    }
}

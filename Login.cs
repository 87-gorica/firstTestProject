using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace $safeprojectname$
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void TestCase1()
        {
            //Potrebne promenljive za elemente
            string url = "https://www.extrasports.com/";
            string btnPrijaviteSe = "//li/a[@data-target='#login_modal']";
            string txtUsername = "login_email";
            string txtPassword = "login_password";
            string btn2PrijaviteSe = "#login_modal > div > div > form > div.modal-footer > div > div:nth-child(1) > button";
            string logout = "body > div.header.container-wrapper > div.header-top > div > div.row > div.col-xs-10.col-sm-6.col-md-4.col-lg-4.user-actions-wrapper > div > div > ul > li:nth-child(3) > a";
            string mojNalog = "body > div.header.container-wrapper > div.header-top > div > div.row > div.col-xs-10.col-sm-6.col-md-4.col-lg-4.user-actions-wrapper > div > div > ul > li:nth-child(2) > a";
            string txtNalog = "body > div.container.profile.appear.appeared > div.heading-wrapper-inline.heading-wrapper-profile > div > div > div.headline-title > h1";

            //Potrebne promenljive za Logovanje
            var methodName = "TestCase1-Login with valid data:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            LogTest.LogStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to login page";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme Prijavite se
            stepName = "3.Click on button Prijavite se";
            driver.FindElement(By.XPath(btnPrijaviteSe)).Click();
            Thread.Sleep(3000);
            LogTest.LogStep(methodName, stepName);

            //Unos teksta u polje username
            stepName = "5.Provide valid username";
            driver.FindElement(By.Id(txtUsername)).SendKeys("goricamarinkovic87@gmail.com");
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Unos teksta u polje password
            stepName = "5.Provide valid password";
            driver.FindElement(By.Id(txtPassword)).SendKeys("gorica87");
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Click on button Prijavite se
            stepName = "6.Click on button Prijavite se";
            driver.FindElement(By.CssSelector(btn2PrijaviteSe)).Click();
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var clickNalog = driver.FindElement(By.CssSelector(mojNalog));
                clickNalog .Click();
                Thread.Sleep(2000);
                var confirmLog = driver.FindElement(By.CssSelector(txtNalog));
                confirmLog.GetAttribute("Moj nalog");
                if(confirmLog.Displayed)
                {
                    LogTest.LogPassedTest();
                    
                }
            }
            catch (Exception)
            {

                LogTest.LogFailedTest();
            }
            finally
            {
                //Logout
                driver.FindElement(By.CssSelector(logout)).Click();
                Thread.Sleep(2000);
                //Kraj testa
                LogTest.LogEnd();
                driver.Quit();
            }

        }

        [TestMethod]
        public void TestCase2()
        {
            //Potrebne promenljive za elemente
            string url = "https://www.extrasports.com/";
            string btnPrijaviteSe = "//li/a[@data-target='#login_modal']";
            string txtUsername = "login_email";
            string txtPassword = "login_password";
            string btn2PrijaviteSe = "#login_modal > div > div > form > div.modal-footer > div > div:nth-child(1) > button";
            //string txtLog = "//*[@id=\"parsley - id - 0331\"]/li";

            //Potrebne promenljive za Logovanje
            var methodName = "TestCase2 - Login with invalid username:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            LogTest.LogStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to login page";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme Prijavite se
            stepName = "3.Click on button Prijavite se";
            driver.FindElement(By.XPath(btnPrijaviteSe)).Click();
            Thread.Sleep(3000);
            LogTest.LogStep(methodName, stepName);

            //Unos teksta u polje username
            stepName = "5.Provide invalid username";
            driver.FindElement(By.Id(txtUsername)).SendKeys("");
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Unos teksta u polje password
            stepName = "5.Provide valid password";
            driver.FindElement(By.Id(txtPassword)).SendKeys("gorica87");
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Click on button Prijavite se
            stepName = "6.Click on button Prijavite se";
            driver.FindElement(By.CssSelector(btn2PrijaviteSe)).Click();
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
               var confirmLog = driver.FindElement(By.ClassName("parsley-required"));

                if (confirmLog.Text == "Ovo polje je obavezno.")
                {
                    LogTest.LogPassedTest();
                }
            }
            catch (Exception)
            {

                LogTest.LogFailedTest();
            }
            finally
            {
                //Kraj testa
                LogTest.LogEnd();
                driver.Quit();
            }
        }


        [TestMethod]
        public void TestCase3()
        {
            //Potrebne promenljive za elemente
            string url = "https://www.extrasports.com/";
            string btnPrijaviteSe = "//li/a[@data-target='#login_modal']";
            string txtUsername = "login_email";
            string txtPassword = "login_password";
            string btn2PrijaviteSe = "#login_modal > div > div > form > div.modal-footer > div > div:nth-child(1) > button";
            

            //Potrebne promenljive za Logovanje
            var methodName = "TestCase3 - Login with invalid data:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            LogTest.LogStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to login page";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme Prijavite se
            stepName = "3.Click on button Prijavite se";
            driver.FindElement(By.XPath(btnPrijaviteSe)).Click();
            Thread.Sleep(3000);
            LogTest.LogStep(methodName, stepName);

            //Unos teksta u polje username
            stepName = "5.Provide invalid username";
            driver.FindElement(By.Id(txtUsername)).SendKeys("");
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Unos teksta u polje password
            stepName = "5.Provide invalid password";
            driver.FindElement(By.Id(txtPassword)).SendKeys("");
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Click on button Prijavite se
            stepName = "6.Click on button Prijavite se";
            driver.FindElement(By.CssSelector(btn2PrijaviteSe)).Click();
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var confirmLog = driver.FindElement(By.ClassName("parsley-required"));

                if (confirmLog.Text == "Ovo polje je obavezno.")
                {
                    LogTest.LogPassedTest();
                }
            }
            catch (Exception)
            {

                LogTest.LogFailedTest();
            }
            finally
            {
                //Kraj testa
                LogTest.LogEnd();
                driver.Quit();
            }
        }
    }
}

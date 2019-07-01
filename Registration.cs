using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Project_ExtraSports
{
    [TestClass]
    public class Registration
    {
        [TestMethod]
        public void TestCase1()
        {
            
            //Potrebne promenljive za elemente
            string url = "https://www.extrasports.com/";
            string btnPrijaviteSe = "//li/a[@data-target='#login_modal']";
            string btnRegistrujteSe = "#login_modal > div > div > form > div.modal-footer > div > div.col-xs-12.col-md-12 > a";
            string txtFirstname = "reg_firstname";
            string txtLastname = "reg_lastname";
            string txtEmail = "reg_email";
            string txtPassword = "reg_password";
            string txtPasswordRepeat = "reg_password_repeat";
            string checkboxGender = "//*[@id=\"register_modal\"]/div/div/form/div[2]/div[3]/div/div[5]/div/div/div/div[2]/label";
            string numberPhone = "reg_phone";
            string txtStreet = "reg_address";
            string txtNumberStreet = "reg_street_no";
            string txtCity = "reg_city";
            string txtPostcode = "reg_postcode";
            string dropdownDaybirth = "reg_daybirth";
            string dropdownMonthbirth = "reg_monthbirth";
            string dropdownYearbirth = "reg_yearbirth";
            string dropdownAntispam = "reg_anti";
            string btn2RegistrujteSe = "#register_modal > div > div > form > div.modal-footer > div > div:nth-child(2) > button";
            string txtRegistracija = "//div[contains(text(),'Uspešno ste započeli proces registracije.')]";
            
            //Potrebne promenljive za Registraciju
            var methodName = "TestCase1 - Registration user with valid data:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            RegTest.RegStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to registration page";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            RegTest.RegStep(methodName, stepName);
            
            //Kliknemo na dugme Prijavite se
            stepName = "3.Click on button Prijavite se";
            driver.FindElement(By.XPath(btnPrijaviteSe)).Click();
            Thread.Sleep(3000);
            RegTest.RegStep(methodName, stepName);

            //Kliknemo na dugme Registrujte se
            stepName = "4.Click on button Registrujte se";
            driver.FindElement(By.CssSelector(btnRegistrujteSe)).Click();
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje ime
            stepName = "5.Provide valid first name";
            driver.FindElement(By.Id(txtFirstname)).SendKeys("Gorica");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje prezime
            stepName = "6.Provide valid last name";
            driver.FindElement(By.Id(txtLastname)).SendKeys("Marinkovic");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u email polje
            stepName = "7.Provide valid email";
            driver.FindElement(By.Id(txtEmail)).SendKeys("goricamarinkovic1256@gmail.com");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u password polje
            stepName = "8.Provide valid password";
            driver.FindElement(By.Id(txtPassword)).SendKeys("gorica87");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u passwor-repeat polje
            stepName = "9.Provide valid password_repeat";
            driver.FindElement(By.Id(txtPasswordRepeat)).SendKeys("gorica87");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Cekiranje checkbox-pol
            stepName = "10.Checked the gender";
            driver.FindElement(By.XPath(checkboxGender)).Click();
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos broja telefona
            stepName = "11.Provide number phone";
            driver.FindElement(By.Id(numberPhone)).SendKeys("064/460-1599");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje ulica
            stepName = "12.Provide name street";
            driver.FindElement(By.Id(txtStreet)).SendKeys("Radomira Markovica");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos broja ulice 
            stepName = "13.Provide number street";
            driver.FindElement(By.Id(txtNumberStreet)).SendKeys("33");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje grad
            stepName = "14.Provide city";
            driver.FindElement(By.Id(txtCity)).SendKeys("Beograd");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje postanski broj
            stepName = "15.Provide Zip Code";
            driver.FindElement(By.Id(txtPostcode)).SendKeys("11000");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje dan rodjenja
            stepName = "16.Provide daybirth";
            var daybirth = driver.FindElement(By.Id(dropdownDaybirth));
            var selectDaybirth = new SelectElement(daybirth);
            selectDaybirth.SelectByValue("20");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje mesec rodjenja
            stepName = "17.Provide month birth";
            var monthbirth = driver.FindElement(By.Id(dropdownMonthbirth));
            var selectMonthbirth = new SelectElement(monthbirth);
            selectMonthbirth.SelectByValue("2");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje godina rodjenja
            stepName = "18.Provide year birth";
            var yearbirth = driver.FindElement(By.Id(dropdownYearbirth));
            var selectYearbirth = new SelectElement(yearbirth);
            selectYearbirth.SelectByValue("1987");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje Anti spam zastite
            stepName = "19.Provide valid Anti spam  protect";
            var antiSpam = driver.FindElement(By.Id(dropdownAntispam));
            var selectAntispam= new SelectElement(antiSpam);
            selectAntispam.SelectByValue("7");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Click on button Registrujte se
            stepName = "20.Click on button Registrujte se";
            driver.FindElement(By.CssSelector(btn2RegistrujteSe)).Click();
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            // Proveravamo ispravnost testa
            try
            {
                var confirmReg = driver.FindElement(By.XPath(txtRegistracija));
                
                if (confirmReg.Displayed)
                {
                    RegTest.RegPassedTest();
                }

            }
            catch (Exception)
            {

                RegTest.RegFailedTest();
            }
            finally
            {
                //Kraj testa
                RegTest.RegEnd();
                driver.Quit();
            }

        }

        [TestMethod]
        public void TestCase2()
        {
            //Potrebne promenljive za elemente
            string url = "https://www.extrasports.com/";
            string btnPrijaviteSe = "//li/a[@data-target='#login_modal']";
            string btnRegistrujteSe = "#login_modal > div > div > form > div.modal-footer > div > div.col-xs-12.col-md-12 > a";
            string txtFirstname = "reg_firstname";
            string txtLastname = "reg_lastname";
            string txtEmail = "reg_email";
            string txtPassword = "reg_password";
            string txtPasswordRepeat = "reg_password_repeat";
            string checkboxGender = "//*[@id=\"register_modal\"]/div/div/form/div[2]/div[3]/div/div[5]/div/div/div/div[2]/label";
            string numberPhone = "reg_phone";
            string txtStreet = "reg_address";
            string txtNumberStreet = "reg_street_no";
            string txtCity = "reg_city";
            string txtPostcode = "reg_postcode";
            string dropdownDaybirth = "reg_daybirth";
            string dropdownMonthbirth = "reg_monthbirth";
            string dropdownYearbirth = "reg_yearbirth";
            string dropdownAntispam = "reg_anti";
            //string checkbox1 = "reg_confirm";
            //string checkbox2 = "reg_sendNewsletter";
            string btn2RegistrujteSe = "#register_modal > div > div > form > div.modal-footer > div > div:nth-child(2) > button";

            //Potrebne promenljive za Registraciju
            var methodName = "TestCase2 - Registration with invalid email:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            RegTest.RegStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to registration page";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            RegTest.RegStep(methodName, stepName);


            //Kliknemo na dugme Prijavite se
            stepName = "3.Click on button Prijavite se";
            driver.FindElement(By.XPath(btnPrijaviteSe)).Click();
            Thread.Sleep(3000);
            RegTest.RegStep(methodName, stepName);

            //Kliknemo na dugme Registrujte se
            stepName = "4.Click on button Registrujte se";
            driver.FindElement(By.CssSelector(btnRegistrujteSe)).Click();
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje ime
            stepName = "5.Provide valid first name";
            driver.FindElement(By.Id(txtFirstname)).SendKeys("Gorica");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje prezime
            stepName = "6.Provide valid last name";
            driver.FindElement(By.Id(txtLastname)).SendKeys("Marinkovic");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u email polje
            stepName = "7.Provide invalid email";
            driver.FindElement(By.Id(txtEmail)).SendKeys("goricamarinkovic87gmail.com");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u password polje
            stepName = "8.Provide valid password";
            driver.FindElement(By.Id(txtPassword)).SendKeys("gorica87");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u passwor-repeat polje
            stepName = "9.Provide valid password_repeat";
            driver.FindElement(By.Id(txtPasswordRepeat)).SendKeys("gorica87");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Cekiranje checkbox-pol
            stepName = "10.Checked the gender";
            driver.FindElement(By.XPath(checkboxGender)).Click();
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos broja telefona
            stepName = "11.Provide number phone";
            driver.FindElement(By.Id(numberPhone)).SendKeys("064/460-1599");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje ulica
            stepName = "12.Provide name street";
            driver.FindElement(By.Id(txtStreet)).SendKeys("Radomira Markovica");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos broja ulice 
            stepName = "13.Provide number street";
            driver.FindElement(By.Id(txtNumberStreet)).SendKeys("33");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje grad
            stepName = "14.Provide city";
            driver.FindElement(By.Id(txtCity)).SendKeys("Beograd");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje postanski broj
            stepName = "15.Provide Zip Code";
            driver.FindElement(By.Id(txtPostcode)).SendKeys("11000");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje dan rodjenja
            stepName = "16.Provide daybirth";
            var daybirth = driver.FindElement(By.Id(dropdownDaybirth));
            var selectDaybirth = new SelectElement(daybirth);
            selectDaybirth.SelectByValue("20");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje mesec rodjenja
            stepName = "17.Provide month birth";
            var monthbirth = driver.FindElement(By.Id(dropdownMonthbirth));
            var selectMonthbirth = new SelectElement(monthbirth);
            selectMonthbirth.SelectByValue("2");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje godina rodjenja
            stepName = "18.Provide year birth";
            var yearbirth = driver.FindElement(By.Id(dropdownYearbirth));
            var selectYearbirth = new SelectElement(yearbirth);
            selectYearbirth.SelectByValue("1987");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje Anti spam zastite
            stepName = "19.Provide valid Anti spam  protect";
            var antiSpam = driver.FindElement(By.Id(dropdownAntispam));
            var selectAntispam = new SelectElement(antiSpam);
            selectAntispam.SelectByValue("7");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Click on button Registrujte se
            stepName = "20.Click on button Registrujte se";
            driver.FindElement(By.CssSelector(btn2RegistrujteSe)).Click();
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            // Proveravamo ispravnost testa
            try
            { 
                var confirmReg = driver.FindElement(By.ClassName("parsley-type"));

                if (confirmReg.Text == "Unesite validan email.")
                {
                    RegTest.RegPassedTest();
                }

            }
            catch (Exception)
            {

                RegTest.RegFailedTest();
            }
            finally
            {
                //Kraj testa
                RegTest.RegEnd();
                driver.Quit();
            }


        }


        [TestMethod]
        public void TestCase3()
        {
            //Potrebne promenljive za elemente
            string url = "https://www.extrasports.com/";
            string btnPrijaviteSe = "//li/a[@data-target='#login_modal']";
            string btnRegistrujteSe = "#login_modal > div > div > form > div.modal-footer > div > div.col-xs-12.col-md-12 > a";
            string txtFirstname = "reg_firstname";
            string txtLastname = "reg_lastname";
            string txtEmail = "reg_email";
            string txtPassword = "reg_password";
            string txtPasswordRepeat = "reg_password_repeat";
            string checkboxGender = "//*[@id=\"register_modal\"]/div/div/form/div[2]/div[3]/div/div[5]/div/div/div/div[2]/label";
            string numberPhone = "reg_phone";
            string txtStreet = "reg_address";
            string txtNumberStreet = "reg_street_no";
            string txtCity = "reg_city";
            string txtPostcode = "reg_postcode";
            string dropdownDaybirth = "reg_daybirth";
            string dropdownMonthbirth = "reg_monthbirth";
            string dropdownYearbirth = "reg_yearbirth";
            string dropdownAntispam = "reg_anti";
            //string checkbox1 = "reg_confirm";
            //string checkbox2 = "reg_sendNewsletter";
            string btn2RegistrujteSe = "#register_modal > div > div > form > div.modal-footer > div > div:nth-child(2) > button";

            //Potrebne promenljive za Registraciju
            var methodName = "TestCase3 - Registration with invalid character:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            RegTest.RegStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to registration page";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            RegTest.RegStep(methodName, stepName);


            //Kliknemo na dugme Prijavite se
            stepName = "3.Click on button Prijavite se";
            driver.FindElement(By.XPath(btnPrijaviteSe)).Click();
            Thread.Sleep(3000);
            RegTest.RegStep(methodName, stepName);

            //Kliknemo na dugme Registrujte se
            stepName = "4.Click on button Registrujte se";
            driver.FindElement(By.CssSelector(btnRegistrujteSe)).Click();
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje ime
            stepName = "5.Provide invalid first name";
            driver.FindElement(By.Id(txtFirstname)).SendKeys("234576");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje prezime
            stepName = "6.Provide invalid last name";
            driver.FindElement(By.Id(txtLastname)).SendKeys("2437490#");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u email polje
            stepName = "7.Provide valid email";
            driver.FindElement(By.Id(txtEmail)).SendKeys("goricamarinkovic5609@gmail.com");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u password polje
            stepName = "8.Provide valid password";
            driver.FindElement(By.Id(txtPassword)).SendKeys("gorica87");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u passwor-repeat polje
            stepName = "9.Provide valid password_repeat";
            driver.FindElement(By.Id(txtPasswordRepeat)).SendKeys("gorica87");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Cekiranje checkbox-pol
            stepName = "10.Checked the gender";
            driver.FindElement(By.XPath(checkboxGender)).Click();
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos broja telefona
            stepName = "11.Provide invalid number phone";
            driver.FindElement(By.Id(numberPhone)).SendKeys("gorica");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje ulica
            stepName = "12.Provide name street";
            driver.FindElement(By.Id(txtStreet)).SendKeys("Radomira Markovica");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos broja ulice 
            stepName = "13.Provide number street";
            driver.FindElement(By.Id(txtNumberStreet)).SendKeys("33");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje grad
            stepName = "14.Provide city";
            driver.FindElement(By.Id(txtCity)).SendKeys("Beograd");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Unos teksta u polje postanski broj
            stepName = "15.Provide Zip Code";
            driver.FindElement(By.Id(txtPostcode)).SendKeys("11000");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje dan rodjenja
            stepName = "16.Provide daybirth";
            var daybirth = driver.FindElement(By.Id(dropdownDaybirth));
            var selectDaybirth = new SelectElement(daybirth);
            selectDaybirth.SelectByValue("20");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje mesec rodjenja
            stepName = "17.Provide month birth";
            var monthbirth = driver.FindElement(By.Id(dropdownMonthbirth));
            var selectMonthbirth = new SelectElement(monthbirth);
            selectMonthbirth.SelectByValue("2");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje godina rodjenja
            stepName = "18.Provide year birth";
            var yearbirth = driver.FindElement(By.Id(dropdownYearbirth));
            var selectYearbirth = new SelectElement(yearbirth);
            selectYearbirth.SelectByValue("1987");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Selektovanje Anti spam zastite
            stepName = "19.Provide valid Anti spam  protect";
            var antiSpam = driver.FindElement(By.Id(dropdownAntispam));
            var selectAntispam = new SelectElement(antiSpam);
            selectAntispam.SelectByValue("7");
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            //Click on button Registrujte se
            stepName = "20.Click on button Registrujte se";
            driver.FindElement(By.CssSelector(btn2RegistrujteSe)).Click();
            Thread.Sleep(2000);
            RegTest.RegStep(methodName, stepName);

            // Provera ispravnosti testa
            try
            {
                var confirmReg = driver.FindElement(By.ClassName("parsley-required"));

                if (confirmReg.Text == "Ovo polje je obavezno.")
                {
                    RegTest.RegPassedTest();
                }

            }
            catch (Exception)
            {
                RegTest.RegFailedTest();
            }
            finally
            {
                //Kraj testa
                RegTest.RegEnd();
                driver.Quit();
            }


        }
    }
}

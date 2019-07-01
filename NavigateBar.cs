using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Project_ExtraSports
{
    [TestClass]
    public class NavigateBar
    {
       

        [TestMethod]
        public void TestCase1()
        {
           
            //Potrebne promenljive za elemente
            string url = "https://www.extrasports.com/";
            string btnMen = "body > div.header.container-wrapper > div.nav.nav-main-wrapper.ease > div > ul > li:nth-child(2) > a";
            string btnWomen = "body > div.header.container-wrapper > div.nav.nav-main-wrapper.ease > div > ul > li:nth-child(3) > a";
            string btnChildren = "//a[contains(text(),'Deca')]";
            string btnVesti = "/html/body/div[1]/div[3]/div/ul/li[4]/a";
            string btnExtraKupovina = "/html/body/div[1]/div[3]/div/ul/li[5]/a";
            string btnObuca = "body > div.header.container-wrapper > div.nav.nav-main-wrapper.ease > div > ul > li:nth-child(2) > div > div > div > div > div > div:nth-child(1) > div > a > div";
            string btnBrendovi = "body > div.header.container-wrapper > div.nav.nav-main-wrapper.ease > div > ul > li:nth-child(3) > div > div > div > div > div > div:nth-child(5) > div > a > div";
            string btnSportovi = "body > div.header.container-wrapper > div.nav.nav-main-wrapper.ease > div > ul > li:nth-child(4) > div > div > div > div > div > div:nth-child(4) > div > a > div";
            string pageMagazin = "body > div:nth-child(4) > div > div.listing-products.appear.appeared > div.heading-wrapper > h1 > span";
            string pokazivacExtraBuy = "body > div.container.hidden-fullscreen > div > div.row.listing-products > div.col-xs-12.col-sm-9.col-lg-9 > div.product-listing-tags > div > div.col-xs-12.col-sm-10.col-lg-10.hidden-xs > div.tag.nb-sel-fiter-list > div.tag-text";

            //Potrebne promenljive za Registraciju
            var methodName = "TestCase1 - Navigate to fields in navigation bar:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver.";
            IWebDriver driver = new ChromeDriver();
            NavTest.NavTestStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to Navigation bar.";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            NavTest.NavTestStep(methodName, stepName);

            //Navigiramo do prvog polja navigacionog bara
            stepName = "3.Navigation to first field navigtion bar.";
            var navMen = driver.FindElement(By.CssSelector(btnMen));
            Actions navigation = new Actions(driver);
            navigation.MoveToElement(navMen).Perform();
            Thread.Sleep(2000);
            NavTest.NavTestStep(methodName, stepName);
            try
            {
                var navOdeca= driver.FindElement(By.CssSelector(btnObuca));
                if (navOdeca.Displayed)
                {

                      NavTest.NavTestPassed();
                }
            }
            catch (Exception)
            {

                NavTest.NavTestFailed();
            }
            

            //Navigiramo do drugog polja navigacionog bara
            stepName = "4.Navigation to second field navigtion bar.";
            var navWomen = driver.FindElement(By.CssSelector(btnWomen));
            navigation.MoveToElement(navWomen).Perform();
            Thread.Sleep(2000);
            NavTest.NavTestStep(methodName, stepName);
            try
            {
                var navBrendovi = driver.FindElement(By.CssSelector(btnBrendovi));
                if (navBrendovi.Displayed)
                {

                    NavTest.NavTestPassed();
                }
            }
            catch (Exception)
            {

                NavTest.NavTestFailed();
            }

            //Navigiramo do treceg polja navigacionog bara
            stepName = "5.Navigation to third field navigtion bar.";
            var navChildren = driver.FindElement(By.XPath(btnChildren));
            navigation.MoveToElement(navChildren).Perform();
            Thread.Sleep(2000);
            NavTest.NavTestStep(methodName, stepName);
            try
            {
                var navSportovi = driver.FindElement(By.CssSelector(btnSportovi));
                if (navSportovi.Displayed)
                {

                    NavTest.NavTestPassed();
                }
            }
            catch (Exception)
            {

                NavTest.NavTestFailed();
            }


            //Kliknemo na dugme Vesti u navigacionom baru
            stepName = "6.Click on button Vesti.";
            var btnNavVesti = driver.FindElement(By.XPath(btnVesti));
            btnNavVesti.Click();
            Thread.Sleep(1000);
            NavTest.NavTestStep(methodName, stepName);
            try
            {
                var navPageMagazin = driver.FindElement(By.CssSelector(pageMagazin));
                if (navPageMagazin.Displayed)
                {

                    NavTest.NavTestPassed();
                }
            }
            catch (Exception)
            {

                NavTest.NavTestFailed();
            }

            //Kliknemo na dugme Extra Kupovina u navigacionom baru 
            stepName = "7.Click on button Extra Kupovina";
            var btnNavExtraKupovina = driver.FindElement(By.XPath(btnExtraKupovina));
            btnNavExtraKupovina.Click();
            Thread.Sleep(2000);
            NavTest.NavTestStep(methodName, stepName);

            //Provera ispravnosti testa

            try
            {
                var extraBuy = driver.FindElement(By.CssSelector(pokazivacExtraBuy));
                if (extraBuy.Displayed)
                {

                      NavTest.NavTestPassed();
                }
            }
            catch (Exception)
            {

                NavTest.NavTestFailed();
            }
            finally
            {
                //Kraj testa
                NavTest.NavTestEnd();
                driver.Quit();
            }
        }


        [TestMethod]
        public void TestCase2()
        {
            //Potrebne promenljive za elemente
            string url = "https://www.extrasports.com/";
            string btnMen = "body > div.header.container-wrapper > div.nav.nav-main-wrapper.ease > div > ul > li:nth-child(2) > a";
            string btnNavBrend = "/html/body/div[1]/div[3]/div/ul/li[1]/div/div/div/div/div/div[5]/div/a";
            string btnReebok = "body > div.header.container-wrapper > div.nav.nav-main-wrapper.ease > div > ul > li:nth-child(2) > div > div > div > div > div > div:nth-child(5) > div > ul > li:nth-child(3) > a";
            //string filterPuma = "#filter_form > div:nth-child(3) > div.filter-group-items-wrapper > ul > li:nth-child(5) > div > label";
            string pokazivacReebok = "body > div.container.hidden-fullscreen > div > div.row.listing-products > div.col-xs-12.col-sm-9.col-lg-9 > div.product-listing-tags > div > div.col-xs-12.col-sm-10.col-lg-10.hidden-xs > div:nth-child(5) > div.tag-text";

            //Potrebne promenljive za Registraciju
            var methodName = "TestCase2 - Navigate to filters in navigation bar:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            NavTest.NavTestStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to page";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            NavTest.NavTestStep(methodName, stepName);

            //Navigiranje prvog polja navigacionog bara
            stepName = "3.Navigation to first field navigtion bar.";
            var navMen = driver.FindElement(By.CssSelector(btnMen));
            Actions navigation = new Actions(driver);
            navigation.MoveToElement(navMen).Perform();
            Thread.Sleep(2000);
            NavTest.NavTestStep(methodName, stepName);

            //Navigiranje do petog polja u podmeniju
            stepName = "4.Navigation to fifth field navigtion bar.";
            var navBrendovi = driver.FindElement(By.XPath(btnNavBrend));
            navigation.MoveToElement(navBrendovi).Perform();
            Thread.Sleep(2000);
            NavTest.NavTestStep(methodName, stepName);

            //Kliknemo na filter-Reebok
            stepName = "5.Click on filter Reebok.";
            var filterRebook = driver.FindElement(By.CssSelector(btnReebok));
            filterRebook.Click();
            Thread.Sleep(1000);
            NavTest.NavTestStep(methodName, stepName);
            

            //Provera ispravnosti testa
            try
            {
                var filterReebok2 = driver.FindElement(By.CssSelector(pokazivacReebok));
                if (filterReebok2.Displayed)
                {
                    NavTest.NavTestPassed();
                }
                
            }
            catch (Exception)
            {


                NavTest.NavTestFailed();
            }
            finally
            {
                //Kraj testa
                NavTest.NavTestEnd();
                driver.Quit();
            }
        }

          
    }
}

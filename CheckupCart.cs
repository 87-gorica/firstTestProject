using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Project_ExtraSports
{
    [TestClass]
    public class CheckupCart
    {
        [TestMethod]
        public void TestCase1()
        {
            //Potrebne promenljive za elemente
            string url = "https://www.extrasports.com/";
            string btnShop = "//*[@id='miniCartContent']/a/div/div[1]";
            string btnWomen = "body > div.header.container-wrapper > div.nav.nav-main-wrapper.ease > div > ul > li:nth-child(3) > a";
            string btnOdeca = "/html/body/div[1]/div[3]/div/ul/li[2]/div/div/div/div/div/div[2]/div/a/div";
            string btnTrenerke = "body > div.header.container-wrapper > div.nav.nav-main-wrapper.ease > div > ul > li:nth-child(3) > div > div > div > div > div > div:nth-child(2) > div > ul > li:nth-child(3) > a";
            string linkProduct = "//a[contains(text(),'ADIDAS Trenerka WTS Plain Tric ')]";
            string btnSize = "/html/body/div[5]/div/div/div[1]/div[1]/div/div[2]/div[5]/label";
            string btnSizeM = "/html/body/div[5]/div/div/div[1]/div[1]/div/div[2]/div[5]/ul/li[2]";
            string btnKupite = "//*[@id=\"nb_addToCartButton\"]";
            string btnMojaKorpa = "//*[@id=\"miniCartContent\"]/div[1]/div[3]/a";
            string imageProduct = "body > div.product-details.ease-slow.hideon-fullscreen > div > div > div.col-md-12.product-information-wrapper > div.container > div > div.hidden-xs.col-sm-7.col-md-7.product-gallery-wrapper > div.product-images > div > div.col-md-2.col-sm-2.hidden-xs > div > div > div.product-images-thumbs.ease-slow.slick-initialized.slick-slider.slick-vertical > div > div > img:nth-child(8)";
            string image2Product = "body > div.product-details.ease-slow.hideon-fullscreen > div > div > div.col-md-12.product-information-wrapper > div.container > div > div.hidden-xs.col-sm-7.col-md-7.product-gallery-wrapper > div.product-images > div > div.col-md-2.col-sm-2.hidden-xs > div > div > div.product-images-thumbs.ease-slow.slick-initialized.slick-slider.slick-vertical > div > div > img:nth-child(10)";
            string zoomImage = "body > div:nth-child(77) > div > div";
            string txtReebok = "//a[contains(text(),'ADIDAS Trenerka WTS Plain Tric ')]";
            //Potrebne promenljive za proveru korpe
            var methodName = "TestCase1 - Checkup to cart:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver.";
            IWebDriver driver = new ChromeDriver();
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to page.";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);

            //Navigiramo do drugog polja navigacionog bara
            stepName = "3.Navigation to second field navigtion bar.";
            var navWomen = driver.FindElement(By.CssSelector(btnWomen));
            Actions action = new Actions(driver);
            action.MoveToElement(navWomen).Perform();
            Thread.Sleep(2000);
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);

            //Navigiranje do petog polja u podmeniju
            stepName = "4.Navigation to fifth field navigtion bar.";
            var navOdeca = driver.FindElement(By.XPath(btnOdeca));
            action.MoveToElement(navOdeca).Perform();
            Thread.Sleep(2000);
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);

            //Kliknemo na filter-Trenerke
            stepName = "5.Click on filter Trenerke.";
            var filterTrenerke = driver.FindElement(By.CssSelector(btnTrenerke));
            filterTrenerke.Click();
            Thread.Sleep(1000);
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);
            
            //Odaberemo proizvod
            stepName = "6.Click on name product.";
            var nameProduct = driver.FindElement(By.XPath(linkProduct));
            nameProduct.Click();
            Thread.Sleep(2000);
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);

            //Kliknemo na  sliku proizvoda
            stepName = "7.Click on image product.";
            var clickImage= driver.FindElement(By.CssSelector(imageProduct));
            clickImage.Click();
            Thread.Sleep(3000);
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);

            //Kliknemo na  drugu sliku proizvoda
            stepName = "8.Click on second image product.";
            var clickImage2 = driver.FindElement(By.CssSelector(image2Product));
            clickImage2.Click();
            Thread.Sleep(3000);
            var zoomImage2 = driver.FindElement(By.CssSelector(zoomImage));
            action.MoveToElement(zoomImage2).Perform();
            Thread.Sleep(2000);
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);

            //Odaberemo velicinu proizvoda
            stepName = "9.Click on size product.";
            var filterSize = driver.FindElement(By.XPath(btnSize));
            filterSize.Click();
            var filterSizeM = driver.FindElement(By.XPath(btnSizeM));
            filterSizeM.Click();
            Thread.Sleep(2000);
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);

            //Kliknemo na dugme kupite
            stepName = "10.Click on button Kupite";
            var submitKupite = driver.FindElement(By.XPath(btnKupite));
            submitKupite.Click();
            Thread.Sleep(3000);
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);

            //Kliknemo na korpu za kupovinu-proveravamo da li je napunjena
            stepName = "11.Click on cart";
            var shopCart = driver.FindElement(By.XPath(btnShop));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", shopCart);
            Thread.Sleep(3000);
            CheckupCartTest.CheckupCartTestStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var confirmCart = driver.FindElement(By.XPath(txtReebok));
                if (confirmCart.Displayed)
                {
                    CheckupCartTest.CheckupCartTestPassed();
                }

            }
            catch (Exception)
            {


                CheckupCartTest.CheckupCartTestFailed();
            }
            finally
            {
                //Kraj testa
                CheckupCartTest.CheckupCartTestEnd();
                driver.Quit();
            }
        }

        
    }
}

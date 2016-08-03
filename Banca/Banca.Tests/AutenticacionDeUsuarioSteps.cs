using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Banca.Tests
{
    [Binding]    
    public class AutenticacionDeUsuarioSteps
    {
        private static IWebDriver driver;
        

        [BeforeScenario]
        public void setUp()
        {
            driver = new ChromeDriver("driver");           
        }

        [AfterScenario]
        public void tearDown()
        {
            driver.Quit();
        }
        
        [Given(@"Ingreso a la sucursal virtual")]
        public void GivenIngresoALaSucursalVirtual()
        {
            driver.Navigate().GoToUrl("http://localhost/Banca/Login");

        }
        
        [When(@"Ingreso login ""(.*)""")]
        public void WhenIngresoLogin(string usuario)
        {
            driver.FindElement(By.Id("idUsuario")).SendKeys(usuario);            
        }
        
        [When(@"y passwrod ""(.*)""")]
        public void WhenYPasswrod(string pass)
        {
            driver.FindElement(By.Id("idPassword")).SendKeys(pass);           
        }
        
        [When(@"seleccion ingresar")]
        public void WhenSeleccionIngresar()
        {
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Id("idLoguearse")).Click();
            
        }
        
        [Then(@"Ingreso a la pagina de transferencia")]
        public void ThenIngresoALaPaginaDeTransferencia()
        {
          
            String url = "http://localhost/Banca/Transferencias";            
            Assert.IsTrue(driver.Url.Contains(url));
            
        }
    }
}

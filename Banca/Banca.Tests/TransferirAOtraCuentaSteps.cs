using Banca.Bussines;
using Banca.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using static NUnit.Core.NUnitFramework;

namespace Banca.Tests
{
    [Binding]
    public class TransferirAOtraCuentaSteps
    {
        private static IWebDriver driver;
        private Cliente clienteOrigen;
        [BeforeScenario]
        public void setUp()
        {
            driver = new ChromeDriver("driver");
            clienteOrigen = DataUser.getDataUser()[0];
        }

        [AfterScenario]
        public void tearDown()
        {
            driver.Quit();
        }
        [Given(@"mi saldo actual es ""(.*)""")]
        public void GivenMiSaldoActualEs(int saldo)
        {
            clienteOrigen.Saldo = saldo;
        }
        
        [Given(@"estoy en la pantalla de cuentas")]
        public void GivenEstoyEnLaPantallaDeCuentas()
        {
            driver.Navigate().GoToUrl("http://localhost/Banca/Usuario/index");
            driver.FindElement(By.Id("idUsuario")).SendKeys(clienteOrigen.username);
            driver.FindElement(By.Id("idPassword")).SendKeys(clienteOrigen.password);
            driver.FindElement(By.Id("idLoguearse")).Click();
            String url = "/Banca/Transferencias/index";
            Assert.Equals(url,driver.Url);
           
        }
        
        [When(@"ingreso el saldo a transferir de ""(.*)""")]
        public void WhenIngresoElSaldoATransferirDe(int saldo)
        {
            driver.FindElement(By.Id("idCuentaOrigen")).SendKeys(clienteOrigen.NumeroCuenta);
            driver.FindElement(By.Id("idSaldoCO")).SendKeys(clienteOrigen.Saldo.ToString());
            driver.FindElement(By.Id("idSaldoTransferir")).SendKeys(saldo.ToString());
            System.Threading.Thread.Sleep(1000);
        }
        
        [When(@"ingreso la cuenta destino ""(.*)""")]
        public void WhenIngresoLaCuentaDestino(Decimal cuenta)
        {
            driver.FindElement(By.Id("idCuentaDestino")).SendKeys(cuenta.ToString());
        }
        
        [When(@"seleccion la opcion Transferir")]
        public void WhenSeleccionLaOpcionTransferir()
        {
            driver.FindElement(By.Id("idTransferir")).Click();
        }
        
        [Then(@"veo el mensaje ""(.*)""")]
        public void ThenVeoElMensaje(string mensaje)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"mi nuevo saldo es ""(.*)""")]
        public void ThenMiNuevoSaldoEs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;

namespace Banca.Tests
{
    [DeploymentItem("driver\\IEDriverServer.exe", "driver")]
    [TestClass]
    public class LoginAceptTest
    {
        private string password;
        private string usuario;
        

        [TestMethod]
        [TestCategory("AceptTest")]      
        public void Login()
        {
 
            IWebDriver driver = new InternetExplorerDriver((string.Format("{0}\\{1}", AppDomain.CurrentDomain.BaseDirectory, "driver")));
            
                usuario = "admin";
                password = "admin";
                driver.Navigate().GoToUrl("http://localhost/Banca/Login");
                driver.FindElement(By.Id("idUsuario")).SendKeys(usuario);
                driver.FindElement(By.Id("idPassword")).SendKeys(password);
                driver.FindElement(By.Id("idLoguearse")).Click();
                String url = "http://localhost/Banca/Transferencias";
                Assert.IsTrue(driver.Url.Contains(url));
            
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace fill_form
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlScraping = "https://itaucard.milhasdecliente.com/login/cliente";
            string fillCreditCardNumber = "5547420782499627";
            string fillPasswordNumber = "aaaa";
            string urlScraping2 = "https://itaucard.clientesdepontos.com/login/cliente";
            string validateDate = "02/20";
            string secureCode = "123";
            string nomeTitular = "Your mother is mine";
            string cpfNumber = "93303687005";
            string numberPhone = "99999999999";


            ChromeOptions chromeCapabilities = new ChromeOptions();

            chromeCapabilities.EnableMobileEmulation("iPhone 6");

            IWebDriver driver = new ChromeDriver(chromeCapabilities);

            driver.Navigate().GoToUrl(urlScraping);

            try
            {
                driver.FindElement(By.Id("numcd")).SendKeys(fillCreditCardNumber);
                driver.FindElement(By.Id("passcd")).SendKeys(fillPasswordNumber);
                driver.FindElement(By.Id("btnlog")).Click();
                driver.FindElement(By.Id("numdtv")).SendKeys(validateDate);
                driver.FindElement(By.Id("numcvv")).SendKeys(secureCode);
                driver.FindElement(By.Id("btncad")).Click();
                driver.FindElement(By.Id("namefull")).SendKeys(nomeTitular);
                driver.FindElement(By.Id("numcpf")).SendKeys(cpfNumber);
                driver.FindElement(By.Id("telephone")).SendKeys(numberPhone);
                driver.FindElement(By.Id("btncad")).Click();
                Console.WriteLine("fill success");
            }
            catch(Exception ex)
            {
                Console.WriteLine("something wrong happend", ex);
                return;
            }
            Console.WriteLine("has worked");
        }

        
    }
}

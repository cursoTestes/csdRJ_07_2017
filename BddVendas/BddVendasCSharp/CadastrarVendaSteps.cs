using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BddVendasCSharp
{
    [Binding]
    public class CadastrarVendaSteps
    {
        IWebDriver driver;

        [BeforeScenario()]
        public void Setup()
        {
            driver = new ChromeDriver(); 
            //load db
        }

        [AfterScenario()]
        public void TearDown()
        {
            driver.Quit();
        }

       
        
        [Given(@"I have entered the sales webpage")]
        public void GivenIHaveEnteredTheSalesWebpage()
        {
            driver.Navigate().GoToUrl("http://localhost:3000/");
        }
        
        [Given(@"I have entered (.*) into the salesman")]
        public void GivenIHaveEnteredIntoTheSalesman(string idVendedor) 
        {
            driver.FindElement(By.Id("vendedor")).SendKeys(idVendedor);
        }
        
        [Given(@"the price was (.*)")]
        public void GivenThePriceWas(string valor)
        {
            driver.FindElement(By.Id("valorVenda")).SendKeys(valor);
        }

        [Given(@"the date was (.*)")]
        public void GivenTheDateWas(string dia)
        {
            driver.FindElement(By.Id("dataVenda")).SendKeys(dia);
        }
        
        [When(@"I press save")]
        public void WhenIPressSave()
        {

        }
        
        [Then(@"a success message should appear")]
        public void ThenASuccessMessageShouldAppear()
        {

        }

        [Then(@"an error message should appear")]
        public void ThenAnErrorMessageShouldAppear()
        {
            //ScenarioContext.Current.Pending();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BddVendasCSharp
{
    [Binding]
    public class CalculadoraTrabalhistaSteps
    {
        [Given(@"que eu estou na pagina da calculadora")]
        public void DadoQueEuEstouNaPaginaDaCalculadora()
        {
         //   ScenarioContext.Current.Pending();
        }

        [Given(@"preenchi o campo salario bruto com '(.*)'")]
        public void DadoPreenchiOCampoSalarioBrutoCom(Decimal p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [Given(@"preenchi o campo vale transporte com '(.*)'")]
        public void DadoPreenchiOCampoValeTransporteCom(Decimal p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"preenchi o campo vale refeicao com '(.*)'")]
        public void DadoPreenchiOCampoValeRefeicaoCom(Decimal p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"preenchi o campo plano de saude com '(.*)'")]
        public void DadoPreenchiOCampoPlanoDeSaudeCom(Decimal p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"eu clicar no botao calcular")]
        public void QuandoEuClicarNoBotaoCalcular()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"deve ser exibido o custo final de '(.*)'")]
        public void EntaoDeveSerExibidoOCustoFinalDe(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}

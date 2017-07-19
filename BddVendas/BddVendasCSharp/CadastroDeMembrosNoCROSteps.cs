using System;
using TechTalk.SpecFlow;

namespace BddVendasCSharp
{
    [Binding]
    public class CadastroDeMembrosNoCROSteps
    {
        [Given(@"que eu estou logado")]
        public void DadoQueEuEstouLogado()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"entrei na página de criar novos membros")]
        public void DadoEntreiNaPaginaDeCriarNovosMembros()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"preenchi o campo nome com '(.*)' e o campo CPF com '(.*)'")]
        public void DadoPreenchiOCampoNomeComEOCampoCPFCom(string p0, Decimal p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"eu clicar no botão salvar")]
        public void QuandoEuClicarNoBotaoSalvar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"devo ser levado para a página de emissâo de guia de pagamento")]
        public void EntaoDevoSerLevadoParaAPaginaDeEmissaoDeGuiaDePagamento()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"deve ser exibido uma mensagem dizendo ""(.*)""\.")]
        public void EntaoDeveSerExibidoUmaMensagemDizendo_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

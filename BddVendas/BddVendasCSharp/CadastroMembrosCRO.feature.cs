﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BddVendasCSharp
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Cadastro de Membros no CRO", Description="\tPara que possa gerenciar os membros deste conselho\r\n\tEu, enquanto secretário,\r\n\t" +
        "Desejo conseguir criar ou editar novos membros ", SourceFile="CadastroMembrosCRO.feature", SourceLine=2)]
    public partial class CadastroDeMembrosNoCROFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CadastroMembrosCRO.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Cadastro de Membros no CRO", "\tPara que possa gerenciar os membros deste conselho\r\n\tEu, enquanto secretário,\r\n\t" +
                    "Desejo conseguir criar ou editar novos membros ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar um novo membro com sucesso", SourceLine=8)]
        public virtual void CriarUmNovoMembroComSucesso()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar um novo membro com sucesso", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
    testRunner.Given("que eu estou logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 11
    testRunner.And("entrei na página de criar novos membros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 12
 testRunner.And("preenchi o campo nome com \'Felippe\' e o campo CPF com \'11161276790\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 13
    testRunner.When("eu clicar no botão salvar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 14
    testRunner.Then("devo ser levado para a página de emissâo de guia de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 15
    testRunner.And("deve ser exibido uma mensagem dizendo \"O membro Felippe acaba de ser cadastrado c" +
                    "om sucesso\".", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Novo membro que esta se tentando cadastrar está bloqueado na receita federal", SourceLine=16)]
        public virtual void NovoMembroQueEstaSeTentandoCadastrarEstaBloqueadoNaReceitaFederal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Novo membro que esta se tentando cadastrar está bloqueado na receita federal", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
    testRunner.Given("que eu estou logado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 19
    testRunner.And("entrei na página de criar novos membros", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 20
 testRunner.And("preenchi o campo nome com \'Felippe\' e o campo CPF com \'11161276790\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 21
    testRunner.When("eu clicar no botão salvar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 22
    testRunner.Then("devo ser levado para a página de emissâo de guia de pagamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 23
    testRunner.And("deve ser exibido uma mensagem dizendo \"O membro Felippe acaba de ser cadastrado c" +
                    "om sucesso\".", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
package br.com.k21;

import junit.framework.Assert;

import org.fluentlenium.adapter.FluentTest;
import org.junit.Test;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.ie.InternetExplorerDriver;

public class SimuladorImobiliarioInterfaceTest extends FluentTest {

	@Override
	public WebDriver getDefaultDriver() {
		return new ChromeDriver();
	}
	
	@Test
	public void teste_imovel_novo_sac_com_sucesso() throws InterruptedException {
		goTo("https://www42.bb.com.br/portalbb/cim/creditoimobiliario/simular,802,2250,2250.bbx");
		click("#faixa1 > div.content-box > div:nth-child(1) > label:nth-child(2) > input[type=\"radio\"]");
		click("#faixa1 > div.content-box > div:nth-child(2) > label:nth-child(2) > input[type=\"radio\"]");
		click("#idEmpreendimento > div > label:nth-child(4) > input[type=\"radio\"]");
		Thread.sleep(5000);

		click("#select2-chosen-1");
		click("#select2-result-label-318 > span");
		click("#select2-chosen-341");
		click("#select2-result-label-433 > span");
		click("#faixa1 > div.content-box > div:nth-child(5) > label:nth-child(3) > input[type=\"radio\"]");
		
		fill("#formulario:valorImovel").with("500000");
		
		click("#btnSobreImovel");
		
		Thread.sleep(5000);
		//Assert.assertEquals("Venda conclu�da.", findFirst("#vendaConcluida").getText());
					
	}

	private void clicarEmpreedimentoNAOFinanciadoPeloBB() {
		click("#idEmpreendimento > div > label:nth-child(4) > input[type=\"radio\"]");
	}

	private void clicarNoImovelNovo() {
		click("#faixa1 > div.content-box > div:nth-child(2) > label:nth-child(2) > input[type=\"radio\"]");
	}

	private void clicarNoTipoResidencial() {
		click("#faixa1 > div.content-box > div:nth-child(1) > label:nth-child(2) > input[type=\"radio\"]");
	}	
	
}

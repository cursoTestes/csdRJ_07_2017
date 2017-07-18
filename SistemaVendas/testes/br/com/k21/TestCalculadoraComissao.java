package br.com.k21;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class TestCalculadoraComissao {
	
	@Test
	public void teste_comissao_com_venda_abaixo_10k_deve_ser_5_porcento() {
		int valorVenda = 6000;
		int comissaoEsperada = 300;		
		
		CalculadoraComissao calculadora = new CalculadoraComissao();
		double comissaoCalculada = calculadora.calcular(valorVenda);
		
		assertEquals(comissaoEsperada, comissaoCalculada, 0);
	}

	@Test
	public void teste_comissao_com_venda_igual_10k_deve_ser_5_porcento() {
		int valorVenda = 10000;
		int comissaoEsperada = 500;		
		
		CalculadoraComissao calculadora = new CalculadoraComissao();
		double comissaoCalculada = calculadora.calcular(valorVenda);
		
		assertEquals(comissaoEsperada, comissaoCalculada, 0);
	}
	
	
	@Test
	public void teste_comissao_com_venda_acima_10k_deve_ser_6_porcento() {
		int valorVenda = 12000;
		int comissaoEsperada = 720;		
		
		CalculadoraComissao calculadora = new CalculadoraComissao();
		double comissaoCalculada = calculadora.calcular(valorVenda);
		
		assertEquals(comissaoEsperada, comissaoCalculada, 0);
	}
	
	@Test
	public void teste_comissao_com_venda_decimal_acima_10k_deve_ser_6_porcento() {
		double valorVenda = 12000.30;
		double comissaoEsperada = 720.01;		
		
		CalculadoraComissao calculadora = new CalculadoraComissao();
		double comissaoCalculada = calculadora.calcular(valorVenda);
		
		assertEquals(comissaoEsperada, comissaoCalculada, 0);
	}
}





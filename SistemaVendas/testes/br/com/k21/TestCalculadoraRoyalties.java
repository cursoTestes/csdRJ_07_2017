package br.com.k21;

import static org.junit.Assert.assertEquals;

import java.util.ArrayList;
import java.util.List;

import org.junit.Test;
import org.mockito.Mockito;

import br.com.k21.dao.VendaRepository;
import br.com.k21.modelo.Venda;

public class TestCalculadoraRoyalties {
	
	private double vendaAbaixoDaMargem = 1000;
	private double vendaAcimaDaMargem = 11000;
	private int id = 1;
	private int vendedor = 1;
	private List<Venda> listaVenda = new ArrayList<Venda>();
	private VendaRepository repositorio = Mockito.mock(VendaRepository.class);	
	
	@Test
	public void teste_um_mes_com_uma_venda() {
		int mes = 1;
		int ano = 2017;
		double royaltyEsperado = 190;
		
		Venda venda1 = new Venda(id, vendedor, mes, ano, vendaAbaixoDaMargem);
		listaVenda.add(venda1);
		Mockito.when(repositorio.obterVendasPorMesEAno(ano, mes)).thenReturn(listaVenda);
		
		CalculadoraRoyalty calculadora = new CalculadoraRoyalty();
		calculadora.setVendaRepository(repositorio);
		
		double royaltyCalculado = calculadora.calcular(mes, ano);
		
		assertEquals(royaltyEsperado, royaltyCalculado, 0);
	}
	
	@Test
	public void teste_um_mes_sem_vendas() {
		int mes = 1;
		int ano = 2017;
		double royaltyEsperado = 0;

		VendaRepository repositorio = Mockito.mock(VendaRepository.class);	
		Mockito.when(repositorio.obterVendasPorMesEAno(ano, mes)).thenReturn(listaVenda);
		CalculadoraRoyalty calculadora = new CalculadoraRoyalty();
		calculadora.setVendaRepository(repositorio);
		
		double royaltyCalculado = calculadora.calcular(mes, ano);
		
		assertEquals(royaltyEsperado, royaltyCalculado, 0);
	}
	
	@Test
	public void teste_um_mes_com_duas_vendas() {
		int mes = 2;
		int ano = 2017;
		double royaltyEsperado = 2258;
		
		Venda venda1 = new Venda(id, vendedor, mes, ano, vendaAbaixoDaMargem);
		Venda venda2 = new Venda(id, vendedor, mes, ano, vendaAcimaDaMargem);
		listaVenda.add(venda1);
		listaVenda.add(venda2);
		Mockito.when(repositorio.obterVendasPorMesEAno(ano, mes))
		.thenReturn(listaVenda);
		
		CalculadoraRoyalty calculadora = new CalculadoraRoyalty();
		calculadora.setVendaRepository(repositorio);
		
		double royaltyCalculado = calculadora.calcular(mes, ano);

		assertEquals(royaltyEsperado, royaltyCalculado, 0);
	}
}





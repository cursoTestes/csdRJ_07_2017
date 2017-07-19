package br.com.k21;

import org.junit.Test;

import br.com.k21.dao.VendaDAO;
import br.com.k21.infra.BaseDBTest;

public class VendaDAOTest extends BaseDBTest {

	@Test
	public void testTotal_Para_Vendedor_Inexistente() {
		// Arrange
		Vendedor vendedor = new Vendedor();
		int entradaIdVendedor = 99;
		vendedor.setId(entradaIdVendedor);
		int entradaAno = 2001;
		double resultado;
		double esperado = 0.0;
		
		// act
		VendaDAO.setEntityManager(emf.createEntityManager());
		resultado = VendaDAO.buscarTotalDeVendasPorVendedorEAno(vendedor, entradaAno);
		
		// asserts
		assertEquals(esperado, resultado);
		
	}
	
	@Test
	public void testTotal_Para_Vendedor_Com_Unica_Venda_No_Ano() {
		// Arrange
		Vendedor vendedor = new Vendedor();
		int entradaIdVendedor = 1;
		vendedor.setId(entradaIdVendedor);
		int entradaAno = 2017;
		double resultado;
		double esperado = 100.0;
		
		// act
		VendaDAO.setEntityManager(emf.createEntityManager());
		resultado = VendaDAO.buscarTotalDeVendasPorVendedorEAno(vendedor, entradaAno);
		
		// asserts
		assertEquals(esperado, resultado);
	}
	
	@Test
	public void testTotal_Para_Vendedor_Com_Duas_Vendas_No_Ano() {
		// Arrange
		Vendedor vendedor = new Vendedor();
		int entradaIdVendedor = 2;
		vendedor.setId(entradaIdVendedor);
		int entradaAno = 2017;
		double resultado;
		double esperado = 3000.0;
		
		// act
		VendaDAO.setEntityManager(emf.createEntityManager());
		resultado = VendaDAO.buscarTotalDeVendasPorVendedorEAno(vendedor, entradaAno);
		
		// asserts
		assertEquals(esperado, resultado);
	}
	
	@Test
	public void testTotal_Para_Vendedor_Sem_Vendas_No_Ano() {
		// Arrange
		Vendedor vendedor = new Vendedor();
		int entradaIdVendedor = 3;
		vendedor.setId(entradaIdVendedor);
		int entradaAno = 2017;
		double resultado;
		double esperado = 0.0;

		// act
		VendaDAO.setEntityManager(emf.createEntityManager());
		resultado = VendaDAO.buscarTotalDeVendasPorVendedorEAno(vendedor, entradaAno);

		// asserts
		assertEquals(esperado, resultado);
	}
	
	@Test
	public void testTotal_Para_Vendedor_Com_Vendas_Em_Outro_Ano() {
		// Arrange
		Vendedor vendedor = new Vendedor();
		int entradaIdVendedor = 2;
		vendedor.setId(entradaIdVendedor);
		int entradaAno = 2016;
		double resultado;
		double esperado = 0.0;

		// act
		VendaDAO.setEntityManager(emf.createEntityManager());
		resultado = VendaDAO.buscarTotalDeVendasPorVendedorEAno(vendedor, entradaAno);

		// asserts
		assertEquals(esperado, resultado);
	}
}

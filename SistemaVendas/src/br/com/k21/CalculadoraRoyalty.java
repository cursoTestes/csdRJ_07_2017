package br.com.k21;

import java.util.Collection;

import br.com.k21.dao.VendaRepository;
import br.com.k21.modelo.Venda;

public class CalculadoraRoyalty {
	
	private CalculadoraComissao calculadoraComissao = new CalculadoraComissao();
	
	private VendaRepository vendaRepository; 

	public double calcular(int mes, int ano) {
		
		Collection<Venda> listaDeVendas = this.vendaRepository.obterVendasPorMesEAno(ano, mes);
		
		double faturamentoTotal = 0;
		double comissaoTotal = 0;
		
		for (Venda venda: listaDeVendas) {
			faturamentoTotal += venda.getValor();
			comissaoTotal += calculadoraComissao.calcular(venda.getValor());
		}
		
		return 0.2*(faturamentoTotal - comissaoTotal);
	}

	public void setVendaRepository(VendaRepository vendaRepository) {
		this.vendaRepository = vendaRepository;
	}
}

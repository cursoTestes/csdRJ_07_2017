package br.com.k21;

public class CalculadoraComissao {

	private static final int VALOR_LIMITE = 10000;

	public double calcular(double valorVenda) {
		if (valorVenda <= VALOR_LIMITE) {
			return (Math.floor(valorVenda * 5) / 100);
			
		} else {
			return (Math.floor(valorVenda * 6) / 100);
		}
	}

}

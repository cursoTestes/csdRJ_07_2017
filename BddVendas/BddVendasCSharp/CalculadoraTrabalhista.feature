#language: pt-BR

Funcionalidade: Custo final por trabalhador
	

Cenario: Criar um trabalhador que recebe um salario minimo
    Dado que eu estou na pagina da calculadora
    E preenchi o campo salario bruto com '937,00' 
	E preenchi o campo vale transporte com '450,00'
	E preenchi o campo vale refeicao com '350,00'
	E preenchi o campo plano de saude com '200,00'
    Quando eu clicar no botao calcular
    Entao deve ser exibido o custo final de '2376,35'
    


Esquema do Cenario: Criar trabalhadores com categoria a., b, c, dehgdhbvdshs
    Dado que eu estou na pagina da calculadora
    E preenchi o campo salario bruto com <salario_bruto>
	E preenchi o campo vale transporte com <vale_transporte>
	Quando eu clicar no botao calcular
    Entao deve ser exibido o custo final de <custo_final>

	Exemplos: 
			| salario_bruto | vale_transporte | custo_final |
			| 122 | 21 | 12 |
			| 121122 | 2132 | 1233 |
   
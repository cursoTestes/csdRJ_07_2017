#language: pt-BR

Funcionalidade: Cadastro de Membros no CRO
	Para que possa gerenciar os membros deste conselho
	Eu, enquanto secretário,
	Desejo conseguir criar ou editar novos membros 


Cenário: Criar um novo membro com sucesso
    Dado que eu estou logado
    E entrei na página de criar novos membros 
	E preenchi o campo nome com 'Felippe' e o campo CPF com '11161276790'
    Quando eu clicar no botão salvar
    Então devo ser levado para a página de emissâo de guia de pagamento
    E deve ser exibido uma mensagem dizendo "O membro Felippe acaba de ser cadastrado com sucesso". 

Cenário: Novo membro que esta se tentando cadastrar está bloqueado na receita federal
    Dado que eu estou logado
    E entrei na página de criar novos membros 
	E preenchi o campo nome com 'Felippe' e o campo CPF com '11161276790'
    Quando eu clicar no botão salvar
    Então devo ser levado para a página de emissâo de guia de pagamento
    E deve ser exibido uma mensagem dizendo "O membro Felippe acaba de ser cadastrado com sucesso". 

Essa API está conectada a um banco de dados local.
Ela possui três endpoints
/api/cliente/
	-Esta possui três métodos:
		-GET- Sem nenhum parâmetro, ela retorna a lista dos clientes ordenados em ordem alfabética (JSON)
		-GET/id- Com um parâmetro inteiro (id), ela retorna informações sobre um cliente específico
		-POST- Insira informações no body para criar um novo cliente
/api/os/
	-Esta possui dois métodos:
		-GET- Sem nenhum parâmetro, ela retorna a lista das ordens de serviço
		-GET/id- Com um parâmetro inteiro (id), ela retorna informações sobre uma ordem de serviço específica
/api/servico/
	-Esta possui dois métodos:
		-GET- Sem nenhum parâmetro, ela retorna a lista dos serviços
		-GET/id- Com um parâmetro inteiro (id), ela retorna informações sobre um serviço específico
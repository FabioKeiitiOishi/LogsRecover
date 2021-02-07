Tech Challenge-Ben Fatto

Chamei de: Log Recovery
Frontend: Angular 8
Backend: .Net Core 3.1

Projeto com arquitetura em camadas orientado a domínio (DDD)
- Test: Testes unitários utilizando xUnix

- Web: WebAPI em .Net Core e Frontend com Angular 8
	Frontend: Foi separado o que deve ser executado em cada componente e foi criado o log.services.ts com as funções que se comunicam com a API, para separar as regras.

- Application: 
	- Services: Regras para traduzir a ViewModel para a Entidade(Entity)
	- AutoMapper: Utilização de AutoMapper para converter de ViewModel para Entity e vice-versa
	- Interfaces: Interfaces dos serviços para utilização na camada Web
	- ViewModels: ViewModel classe para a Camada Web

- Domain: 
	- Entities: Entidades utilizadas na aplicação
	- Interfaces: Interfaces dos repositórios, para poder ser utlizada na camada de Applications
	- Models: Foi criada para ser a base para as outras entidades, hoje só tem 1, mas ficou para futuras ampliações na aplicação

- Infrastruture:
	- Data: Comunicação com o banco
		- Contexts: Cria o contexto do banco a partir da entidade do Domain
		- Mappings: Mapea a entidade com o contexto para o banco
		- Repository: São os métodos do CRUD para realizar as ações no banco
		- Migrations: Migrações criadas pela biblioteca Npgsql.EntityFrameworkCore 5.0.2 para gerar as tabelas no banco
		- Extensions: Regras para auxiliar a construção das tabelas e adicionar no banco o primeiro registro, como exemplo
	- Ioc: Classe de inversão de Controle, facilita a implementação da injeção de dependência

Ajustes para iniciar a aplicação:

Inicialmente deve-se alterar as configurações de "ConnectionStrings" no "appsettings.json", com as informações do servidor onde o banco que receberá os dados da aplicação está.
As informações necessárias são: 
		- "User ID";
		- "Password";
		- "Server";
		- "Port";
		- "Database";


Esta aplicação foi desenvolvida no VS2019, logo utilizei o Package Manager Console para executar o comando "Update-database", antes deve verificar se o projeto selecionado é o Infrastruture.Data

E aí é só Executar pelo projeto Web

- Infelizmente o envio de arquivo não foi possível fazer funcionar, mas depois desta primeira entrega vou aproveitar para estudar mais o assunto e habilitar esta funcionalidade.
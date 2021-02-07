Tech Challenge-Ben Fatto

Chamei de: Log Recovery
Frontend: Angular 8
Backend: .Net Core 3.1

Projeto com arquitetura em camadas orientado a dom�nio (DDD)
- Test: Testes unit�rios utilizando xUnix

- Web: WebAPI em .Net Core e Frontend com Angular 8
	Frontend: Foi separado o que deve ser executado em cada componente e foi criado o log.services.ts com as fun��es que se comunicam com a API, para separar as regras.

- Application: 
	- Services: Regras para traduzir a ViewModel para a Entidade(Entity)
	- AutoMapper: Utiliza��o de AutoMapper para converter de ViewModel para Entity e vice-versa
	- Interfaces: Interfaces dos servi�os para utiliza��o na camada Web
	- ViewModels: ViewModel classe para a Camada Web

- Domain: 
	- Entities: Entidades utilizadas na aplica��o
	- Interfaces: Interfaces dos reposit�rios, para poder ser utlizada na camada de Applications
	- Models: Foi criada para ser a base para as outras entidades, hoje s� tem 1, mas ficou para futuras amplia��es na aplica��o

- Infrastruture:
	- Data: Comunica��o com o banco
		- Contexts: Cria o contexto do banco a partir da entidade do Domain
		- Mappings: Mapea a entidade com o contexto para o banco
		- Repository: S�o os m�todos do CRUD para realizar as a��es no banco
		- Migrations: Migra��es criadas pela biblioteca Npgsql.EntityFrameworkCore 5.0.2 para gerar as tabelas no banco
		- Extensions: Regras para auxiliar a constru��o das tabelas e adicionar no banco o primeiro registro, como exemplo
	- Ioc: Classe de invers�o de Controle, facilita a implementa��o da inje��o de depend�ncia

Ajustes para iniciar a aplica��o:

Inicialmente deve-se alterar as configura��es de "ConnectionStrings" no "appsettings.json", com as informa��es do servidor onde o banco que receber� os dados da aplica��o est�.
As informa��es necess�rias s�o: 
		- "User ID";
		- "Password";
		- "Server";
		- "Port";
		- "Database";


Esta aplica��o foi desenvolvida no VS2019, logo utilizei o Package Manager Console para executar o comando "Update-database", antes deve verificar se o projeto selecionado � o Infrastruture.Data

E a� � s� Executar pelo projeto Web

- Infelizmente o envio de arquivo n�o foi poss�vel fazer funcionar, mas depois desta primeira entrega vou aproveitar para estudar mais o assunto e habilitar esta funcionalidade.
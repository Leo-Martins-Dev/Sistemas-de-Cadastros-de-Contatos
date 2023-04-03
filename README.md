# Sistema de cadastro de contatos
Este projeto é um sistema de cadastro de contatos utilizando ASP.NET Core, SQL Server e o padrão arquitetural MVC. O objetivo é permitir que o usuário possa cadastrar, visualizar, atualizar e excluir contatos da agenda.

O sistema é implementado como um CRUD (Create, Read, Update, Delete), que são as operações básicas de qualquer aplicação que gerencia dados. Ele permite que o usuário possa adicionar novos contatos, editar as informações existentes de um contato e excluir um contato existente.

O sistema usa o Entity Framework Core para interagir com o banco de dados SQL Server. A interface de usuário é criada com o Razor Pages e o Bootstrap.

O objetivo deste sistema é permitir que o usuário cadastre e gerencie seus contatos de forma fácil e eficiente. O sistema possui as seguintes funcionalidades:

- Cadastro de novo contato
- Edição de contato existente
- Exclusão de contato existente
- Listagem de todos os contatos cadastrados

# Tecnologias utilizadas
- ASP.NET (Framework .NET)
- SQL Server
- MVC (Model-View-Controller)
- HTML, CSS e JavaScript
- C#
- Bootstrap

# Requisitos
Para executar este projeto, é necessário:

- Visual Studio (versão mais recente)
- SQL Server Management Studio 
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.AspNetCore.Mvc.Core

# Instalação e execução
- Clone o repositório em sua máquina local.
- Abra o Visual Studio e abra a solução CadastroContatos.sln.
- Execute o comando Update-Database no console do Package Manager para criar as tabelas do banco de dados no SQL Server.
- Pressione a tecla F5 para executar o projeto no navegador da web.
  
 Obs: O arquivo appsettings.json contém as informações de configuração do banco de dados SQL Server. É possível alterar o nome do servidor, nome do banco de dados e outras configurações relevantes no arquivo. Não esqueça de alterar para poder sincronizar com o seu banco de dados.

# Contribuindo
Contribuições são bem-vindas e encorajadas! Se você quiser contribuir com este projeto, sinta-se à vontade para fazer um fork, fazer as alterações necessárias e enviar um pull request.

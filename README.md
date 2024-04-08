# InfnetMVC

Este é um projeto ASP.NET Core MVC para gerenciar funcionários e departamentos.

## Requisitos

- .NET 8 SDK
- Visual Studio ou Visual Studio Code (opcional)

## Configuração do Banco de Dados

Este projeto utiliza SQLite como banco de dados. Certifique-se de executar as migrações para criar o banco de dados:
## dotnet ef database update

## Funcionalidades

- CRUD de funcionários e departamentos
- Busca por nome de funcionário na página de índice
- Autenticação de contas individuais com ASP.NET Core Identity
- Senhas exigem pelo menos 6 caracteres, incluindo maiúsculas, minúsculas e caracteres especiais
- Bloqueio de conta após 5 tentativas de login malsucedidas
- Tempo de expiração do cookie de autenticação configurado para 5 minutos
- Páginas de login, registro, esqueceu a senha e confirmação de e-mail fornecidas pelo ASP.NET Core Identity UI

## Como Executar

1. Clone este repositório.
2. Navegue até a pasta do projeto.
3. Execute o comando `dotnet run` para iniciar o servidor.
4. Acesse `https://localhost:5001` no seu navegador.


## Funcionalidades

- CRUD de funcionários e departamentos
- Busca por nome de funcionário na página de índice
- Autenticação de contas individuais com ASP.NET Core Identity
- Senhas exigem pelo menos 6 caracteres, incluindo maiúsculas, minúsculas e caracteres especiais
- Bloqueio de conta após 5 tentativas de login malsucedidas
- Tempo de expiração do cookie de autenticação configurado para 5 minutos
- Páginas de login, registro, esqueceu a senha e confirmação de e-mail fornecidas pelo ASP.NET Core Identity UI

## Como Executar

1. Clone este repositório.
2. Navegue até a pasta do projeto.
3. Execute o comando `dotnet run` para iniciar o servidor.
4. Acesse `https://localhost:5001` no seu navegador.

## Personalização

- Personalize as páginas de UI do ASP.NET Core Identity conforme necessário.
- Adicione estilos CSS e ajuste as views conforme desejado.

## Dependências do Projeto

Este projeto utiliza as seguintes dependências:

- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Microsoft.AspNetCore.Identity.UI
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SQLite
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.VisualStudio.Web.CodeGeneration.Design


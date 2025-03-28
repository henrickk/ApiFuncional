# ApiFuncional

Este projeto faz parte do curso "Fundamentos de APIs em ASP.NET Core" da plataforma Desenvolvedor.io. Ele demonstra a implementação de uma API funcional usando ASP.NET Core.

## Funcionalidades

- Registro e autenticação de usuários
- Geração de token JWT
- Integração com Entity Framework Core
- Documentação da API com Swagger
- Configuração de CORS para ambientes de desenvolvimento e produção

## Tecnologias Utilizadas

- ASP.NET Core 8
- C# 12.0
- Entity Framework Core
- Microsoft Identity
- Autenticação JWT Bearer
- Swagger

## Começando

### Pré-requisitos

- .NET 8 SDK
- SQL Server ou outro banco de dados compatível

### Instalação

1. Clone o repositório:
git clone https://github.com/seuusuario/ApiFuncional.git

2. Navegue até o diretório do projeto:
cd ApiFuncional

3. Restaure as dependências:
dotnet restore


### Configuração

1. Atualize o arquivo `appsettings.json` com a string de conexão do seu banco de dados e outras configurações necessárias.

### Executando a Aplicação

1. Aplique as migrações do banco de dados:
dotnet ef database update

2. Execute a aplicação:
dotnet run


### Usando o Swagger

- Navegue até `https://localhost:5001/swagger` para acessar a interface do Swagger e explorar os endpoints da API.

## Uso

- Registre um novo usuário usando o endpoint `/registrar`.
- Autentique-se usando o endpoint `/login` para receber um token JWT.
- Use o token para acessar endpoints protegidos.

## Licença

Este projeto está licenciado sob a Licença MIT.

## Agradecimentos

- Desenvolvedor.io por fornecer o curso e os recursos.

Sinta-se à vontade para contribuir com este projeto enviando issues ou pull requests.



# Projeto Restaurantes -- (Em desenvolvimento) 🚧

Este projeto é uma plataforma para encontrar restaurantes próximos que sejam compatíveis com o budget diário de um usuário.

## Funcionalidades

- Listar todos os restaurantes com opção de ordenação por preço ou avaliações.
- Permitir que consumidores indiquem restaurantes.
- Permitir que administradores visualizem os restaurantes indicados e moderação de comentários.

## Tecnologias Utilizadas

- .NET 8.0
- Entity Framework Core
- Docker
- Swagger
- xUnit para testes unitários

## Estrutura do Projeto

O projeto está estruturado conforme o padrão de arquitetura limpa (Clean Architecture):

- **Restaurantes.API**: Projeto de interface de API REST.
- **Restaurantes.Domain**: Lógica de negócios e definições de entidades.
- **Restaurantes.Infrastructure**: Implementações de infraestrutura, como acesso a dados.
- **Restaurantes.Application**: Serviços de aplicação e mapeamentos DTO.
- **Restaurantes.Tests**: Testes unitários.

## Configuração

### Pré-requisitos

- SDK .NET 8.0
- Docker Desktop

### Instalação e Execução

1. Clone o repositório:

   ```bash
   git clone https://github.com/Eriberto-lab/projeto-restaurantes.git
   cd projeto-restaurantes
   ```

2. Inicie o container Docker com o banco de dados SQL Server:

   ```bash
   docker-compose up -d
   ```

3. Compile o projeto e execute a API:

   ```bash
   dotnet build
   dotnet run --project Restaurantes.API
   ```

4. Acesse a documentação da API via Swagger:

   Abra o navegador e vá para `https://localhost:44301/swagger/index.html`.

## Contribuição

- Para contribuir com novas funcionalidades ou correções de bugs, faça um fork do repositório e envie um pull request.
- Certifique-se de seguir as diretrizes de código e boas práticas.


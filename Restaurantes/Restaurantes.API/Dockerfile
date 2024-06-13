# Usar a imagem base do SDK do .NET para compilar e publicar a aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar o arquivo de solução e os arquivos do projeto
COPY *.sln ./
COPY Restaurantes.API/*.csproj Restaurantes.API/
COPY Restaurantes.Application/*.csproj Restaurantes.Application/
COPY Restaurantes.CrossCutting/*.csproj Restaurantes.CrossCutting/
COPY Restaurantes.Domain/*.csproj Restaurantes.Domain/
COPY Restaurantes.Infrastructure/*.csproj Restaurantes.Infrastructure/

# Restaurar as dependências
RUN dotnet restore

# Copiar o restante dos arquivos do projeto
COPY . .

# Compilar a aplicação e publicar o resultado em uma pasta chamada out
RUN dotnet publish Restaurantes.API/Restaurantes.API.csproj -c Release -o /app/publish

# Usar a imagem base do runtime do .NET para executar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copiar os arquivos publicados da fase anterior
COPY --from=build /app/publish .

# Definir o comando de entrada
ENTRYPOINT ["dotnet", "Restaurantes.API.dll"]

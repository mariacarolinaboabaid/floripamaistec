# indica qual imagem será usada como base para a nova imagem que será criada
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env  

# define o diretório de trabalho dentro do container, criando a pasta /app_container para colocar os arquivos 
WORKDIR /app_container 

# copia todo o src para dentro do workdir
COPY src .

# executa comandos dentro do container para restaurar a imagem do projeto
RUN dotnet restore "loja.csproj" --use-current-runtime

RUN dotnet publish exercicios.sln -c Release -o /publish

# nova imagem chamada runtime, que será responsável pela execução do programa
FROM mcr.microsoft.com/dotnet/sdk:7.0 as runtime 

# parte de execução direta no publish 
WORKDIR /publish

# copiando o app_container e o /publish anterior para dentro do /publish criado na linha 28
COPY --from=build-env /publish .

# porta do container que correponde a porta do programa é a 5000
EXPOSE 80

# comando padrão a ser executado quando o container for iniciado, ele permite que o container receba comandos extras
ENTRYPOINT [ "dotnet", "loja.dll" ]
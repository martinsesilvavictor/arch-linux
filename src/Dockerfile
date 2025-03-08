# Acesse https://aka.ms/customizecontainer para saber como personalizar seu contêiner de depuração e como o Visual Studio usa este Dockerfile para criar suas imagens para uma depuração mais rápida.

# Esta fase é usada durante a execução no VS no modo rápido (Padrão para a configuração de Depuração)
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /src
EXPOSE 80
EXPOSE 443

# Esta fase é usada para compilar o projeto de serviço
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /ARCHLINUX
COPY . .
#COPY ArchLinux.sln .
RUN dotnet restore "ArchLinux/ArchLinux.csproj"

# Esta fase é usada para publicar o projeto de serviço a ser copiado para a fase final
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish -c $BUILD_CONFIGURATION -o /src/publish /p:UseAppHost=false

# Esta fase é usada na produção ou quando executada no VS no modo normal (padrão quando não está usando a configuração de Depuração)
FROM base AS final
WORKDIR /src
COPY --from=publish /src/publish .
ENTRYPOINT ["dotnet", "ArchLinux.dll"]


#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
#WORKDIR /App
#
#COPY ./src ./src
#COPY ./test ./test
#COPY AppTemplate.sln .
#
#RUN dotnet restore
#RUN dotnet publish -c Release -o out
#
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#
##RUN addgroup nonroot \
    ##&& adduser dotnet \
    ##&& usermod -aG nonroot dotnet
#
##USER nonroot
#
#WORKDIR /App
#EXPOSE 8080
#COPY --from=build-env /App/out .
#ENTRYPOINT ["dotnet", "AppTemplate.Api.dll"]
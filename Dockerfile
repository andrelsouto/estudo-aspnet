FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["rest-consulta.csproj", "./"]
RUN dotnet restore "./rest-consulta.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "rest-consulta.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "rest-consulta.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "rest-consulta.dll"]

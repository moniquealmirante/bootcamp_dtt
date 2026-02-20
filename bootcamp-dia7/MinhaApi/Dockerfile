FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# copia só o csproj primeiro (melhora cache)
COPY *.csproj ./
RUN dotnet restore

# copia o resto
COPY . .
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080

ENTRYPOINT ["dotnet", "MinhaApi.dll"]
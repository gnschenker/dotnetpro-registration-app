FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as builder
WORKDIR /src
COPY ./applications-api/*.csproj ./applications-api/
RUN dotnet restore applications-api
COPY ./applications-api ./applications-api
RUN dotnet build applications-api
RUN dotnet publish applications-api -c Release -o ./publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=builder /src/publish .
ENTRYPOINT ["dotnet", "applications-api.dll"]
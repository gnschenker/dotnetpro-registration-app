FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
COPY ./applications-api/*.csproj ./applications-api/
RUN dotnet restore applications-api
COPY ./applications-api ./applications-api
CMD dotnet run -p applications-api
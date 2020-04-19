FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
COPY ./flaky-service/*.csproj ./flaky-service/
RUN dotnet restore flaky-service
COPY ./flaky-service ./flaky-service
CMD dotnet run -p flaky-service
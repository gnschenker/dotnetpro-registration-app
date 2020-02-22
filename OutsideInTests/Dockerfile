FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
COPY ./OutsideInTests/*.csproj ./OutsideInTests/
RUN dotnet restore OutsideInTests
COPY ./OutsideInTests ./OutsideInTests
CMD dotnet test OutsideInTests
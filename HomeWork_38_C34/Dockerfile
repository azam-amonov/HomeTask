FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HomeWork_38_C34/HomeWork_38_C34.csproj", "HomeWork_38_C34/"]
RUN dotnet restore "HomeWork_38_C34/HomeWork_38_C34.csproj"
COPY . .
WORKDIR "/src/HomeWork_38_C34"
RUN dotnet build "HomeWork_38_C34.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HomeWork_38_C34.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomeWork_38_C34.dll"]

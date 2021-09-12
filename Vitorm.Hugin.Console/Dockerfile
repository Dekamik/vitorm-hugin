FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Vitorm.Hugin.Console/Vitorm.Hugin.Console.csproj", "Vitorm.Hugin.Console/"]
RUN dotnet restore "Vitorm.Hugin.Scraper/Vitorm.Hugin.Console.csproj"
COPY . .
WORKDIR "/src/Vitorm.Hugin.Console"
RUN dotnet build "Vitorm.Hugin.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vitorm.Hugin.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vitorm.Hugin.Console.dll"]

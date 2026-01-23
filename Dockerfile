# 1. Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY ["KumaranCoffeeCorner.csproj", "./"]
RUN dotnet restore "KumaranCoffeeCorner.csproj"

COPY . .
RUN dotnet publish "KumaranCoffeeCorner.csproj" -c Release -o /app/out

# 2. Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Render dynamic port binding
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "KumaranCoffeeCorner.dll"]

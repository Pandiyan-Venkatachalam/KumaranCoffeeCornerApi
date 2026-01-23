# .NET 8.0 SDK use panni build pannanum
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Project files-ah copy panni restore pannanum
COPY *.sln .
COPY *.csproj ./
RUN dotnet restore

# Moththa code-ahyum copy panni publish pannanum
COPY . .
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Render dynamic port set panna ithu mukkiyam
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "KumaranCoffeeCorner.dll"]

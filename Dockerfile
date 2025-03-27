# Use the official .NET SDK image to build and publish the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the project files and restore dependencies
COPY *.sln .
COPY jasper-portfolio/*.csproj ./jasper-portfolio/
RUN dotnet restore ./jasper-portfolio/jasper-portfolio.csproj

# Build and publish the application
COPY . .
RUN dotnet publish -c Release -o out ./jasper-portfolio/jasper-portfolio.csproj

# Use the official ASP.NET runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Expose port 80 for the application
EXPOSE 80
ENTRYPOINT ["dotnet", "jasper-portfolio.dll"]

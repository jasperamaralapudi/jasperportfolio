# Use the official .NET SDK image to build and publish the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the solution and project files
COPY jasper-portfolio.sln .
COPY jasper-portfolio/*.csproj ./jasper-portfolio/

# Restore dependencies
WORKDIR /app/jasper-portfolio
RUN dotnet restore

# Copy all files and build the application
WORKDIR /app
COPY . .
WORKDIR /app/jasper-portfolio
RUN dotnet publish -c Release -o /app/out

# Use the official ASP.NET runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Expose port 80 for the application
EXPOSE 80
ENTRYPOINT ["dotnet", "jasper-portfolio.dll"]

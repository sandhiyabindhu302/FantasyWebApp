# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# Copy the project file and restore dependencies
COPY FantasyWebApp.csproj ./
RUN dotnet restore "FantasyWebApp.csproj"

# Copy the entire source code
COPY . .

# Publish the application
RUN dotnet publish "FantasyWebApp.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/publish .

# Set environment variables
ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_URLS=http://+:5000

EXPOSE 5000

# Run the application
ENTRYPOINT ["dotnet", "FantasyWebApp.dll"]

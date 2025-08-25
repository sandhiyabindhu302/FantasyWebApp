# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000
 
# Build and publish the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
 
# Copy only the project file and restore dependencies
COPY FantasyWebApp.csproj ./
RUN dotnet restore "FantasyWebApp.csproj"
 
# Copy the rest of the project files
COPY . .
 
# Build and publish the project
RUN dotnet publish "FantasyWebApp.csproj" -c Release -o /app/publish /p:UseAppHost=false
 
# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "FantasyWebApp.dll"]
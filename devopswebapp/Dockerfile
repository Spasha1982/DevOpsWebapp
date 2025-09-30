# Base runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

# Build image
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG configuration=Release
WORKDIR /src

# Copy csproj and restore dependencies
COPY ["devopswebapp.csproj", "./"]
RUN dotnet restore "devopswebapp.csproj"

# Copy the rest of the code and build
COPY . .
RUN dotnet build "devopswebapp.csproj" -c $configuration -o /app/build

# Publish the app
FROM build AS publish
ARG configuration=Release
RUN dotnet publish "devopswebapp.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "devopswebapp.dll"]

#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Arteon.WebAPI/Arteon.WebAPI.csproj", "Arteon.WebAPI/"]
COPY ["Arteon.Application/Arteon.Application.csproj", "Arteon.Application/"]
COPY ["Arteon.Core/Arteon.Core.csproj", "Arteon.Core/"]
COPY ["Arteon.Infrastructure/Arteon.Infrastructure.csproj", "Arteon.Infrastructure/"]
RUN dotnet restore "./Arteon.WebAPI/./Arteon.WebAPI.csproj"
COPY . .
WORKDIR "/src/Arteon.WebAPI"
RUN dotnet build "./Arteon.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Arteon.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Arteon.WebAPI.dll"]
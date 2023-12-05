#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DreamDirectum.Web/DreamDirectum.Web.csproj", "DreamDirectum.Web/"]
COPY ["DreamDirectum.Core/DreamDirectum.Core.csproj", "DreamDirectum.Core/"]
COPY ["DreamDirectum.Infrastructure/DreamDirectum.Infrastructure.csproj", "DreamDirectum.Infrastructure/"]
COPY ["DreamDirectum.UseCases/DreamDirectum.UseCases.csproj", "DreamDirectum.UseCases/"]
RUN dotnet restore "./DreamDirectum.Web/./DreamDirectum.Web.csproj"
COPY . .
WORKDIR "/src/DreamDirectum.Web"
RUN dotnet build "./DreamDirectum.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DreamDirectum.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DreamDirectum.Web.dll"]
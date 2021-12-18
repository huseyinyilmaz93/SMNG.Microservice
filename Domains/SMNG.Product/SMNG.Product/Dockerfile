#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SMNG.Product/SMNG.Product.csproj", "SMNG.Product/"]
RUN dotnet restore "SMNG.Product/SMNG.Product.csproj"
COPY . .
WORKDIR "/src/SMNG.Product"
RUN dotnet build "SMNG.Product.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SMNG.Product.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SMNG.Product.dll"]
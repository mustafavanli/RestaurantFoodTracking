#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/RestaurantFoodTracking.Api/RestaurantFoodTracking.Api.csproj", "src/RestaurantFoodTracking.Api/"]
COPY ["src/RestaurantFoodTracking.Infrastructure/RestaurantFoodTracking.Infrastructure.csproj", "src/RestaurantFoodTracking.Infrastructure/"]
COPY ["src/RestaurantFoodTracking.Domain/RestaurantFoodTracking.Domain.csproj", "src/RestaurantFoodTracking.Domain/"]
COPY ["src/RestaurantFoodTracking.Application/RestaurantFoodTracking.Application.csproj", "src/RestaurantFoodTracking.Application/"]
RUN dotnet restore "src/RestaurantFoodTracking.Api/RestaurantFoodTracking.Api.csproj"
COPY . .
WORKDIR "/src/src/RestaurantFoodTracking.Api"
RUN dotnet build "RestaurantFoodTracking.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestaurantFoodTracking.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestaurantFoodTracking.Api.dll"]
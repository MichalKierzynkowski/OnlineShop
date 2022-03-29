FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY . ./

RUN dotnet publish OnlineShop.sln -c Debug -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0

COPY --from=build /app/out /app
WORKDIR /app

EXPOSE 8000
CMD ["dotnet","WebApi.dll"]
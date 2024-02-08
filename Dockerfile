# docker file for web mvc application in .net core

# Use the official image as a parent image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["WebMvcApp/WebMvcApp.csproj", "WebMvcApp/"]
RUN dotnet restore "WebMvcApp/WebMvcApp.csproj"
COPY . .
WORKDIR "/src/WebMvcApp"
RUN dotnet build "WebMvcApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebMvcApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebMvcApp.dll"]
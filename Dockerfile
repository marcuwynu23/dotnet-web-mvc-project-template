# Use the official Microsoft ASP.NET Core Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

# Copy the published web application files to the container
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BHMS.csproj", "."]
RUN dotnet restore "BHMS.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "BHMS.csproj" -c Release -o /app/build

# Publish the web application
FROM build AS publish
RUN dotnet publish "BHMS.csproj" -c Release -o /app/publish

# Build runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BHMS.dll"]

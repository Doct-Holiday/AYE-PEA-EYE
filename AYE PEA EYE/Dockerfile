#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AYE PEA EYE/AYE PEA EYE.csproj", "AYE PEA EYE/"]
RUN dotnet restore "AYE PEA EYE/AYE PEA EYE.csproj"
COPY . .
WORKDIR "/src/AYE PEA EYE"
RUN dotnet build "AYE PEA EYE.csproj" -c Release -o /app/build

# Generate the developer certificate
RUN dotnet dev-certs https --trust

FROM build AS publish
RUN dotnet publish "AYE PEA EYE.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AYE PEA EYE.dll"]
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Veginder/Veginder.csproj", "Veginder/"]
COPY ["DLL/DAL.csproj", "DLL/"]
COPY ["BLL/BLL.csproj", "BLL/"]
RUN dotnet restore "Veginder/Veginder.csproj"
COPY . .
WORKDIR "/src/Veginder"
RUN dotnet build "Veginder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Veginder.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Veginder.dll"]
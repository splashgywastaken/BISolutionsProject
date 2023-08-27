#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BISolutionsProject/Systems/Api/BISolutionsProject.Api/BISolutionsProject.Api.csproj", "BISolutionsProject/Systems/Api/BISolutionsProject.Api/"]
COPY ["BISolutionsProject/Services/BISolutionsProject.Services.FirstAppResponse/BISolutionsProject.Services.FirstAppResponse.csproj", "BISolutionsProject/Services/BISolutionsProject.Services.FirstAppResponse/"]
COPY ["BISolutionsProject/Shared/BISolutionsProject.Shared.Common/BISolutionsProject.Shared.Common.csproj", "BISolutionsProject/Shared/BISolutionsProject.Shared.Common/"]
COPY ["BISolutionsProject/Services/BISolutionsProject.Services.FirstApp/BISolutionsProject.Services.FirstApp.csproj", "BISolutionsProject/Services/BISolutionsProject.Services.FirstApp/"]
COPY ["BISolutionsProject/Services/BISolutionsProject.Services.SecondAppResponse/BISolutionsProject.Services.SecondAppResponse.csproj", "BISolutionsProject/Services/BISolutionsProject.Services.SecondAppResponse/"]
COPY ["BISolutionsProject/Services/BISolutionsProject.Services.SecondApp/BISolutionsProject.Services.SecondApp.csproj", "BISolutionsProject/Services/BISolutionsProject.Services.SecondApp/"]
COPY ["BISolutionsProject/Services/BISolutionsProject.Services.Settings/BISolutionsProject.Services.Settings.csproj", "BISolutionsProject/Services/BISolutionsProject.Services.Settings/"]
COPY ["BISolutionsProject/Shared/BISolutions.Settings/BISolutionsProject.Settings.csproj", "BISolutionsProject/Shared/BISolutions.Settings/"]
COPY ["BISolutionsProject/Systems/Api/BISolutionsProject.Api.Settings/BISolutionsProject.Api.Settings.csproj", "BISolutionsProject/Systems/Api/BISolutionsProject.Api.Settings/"]
RUN dotnet restore "BISolutionsProject/Systems/Api/BISolutionsProject.Api/BISolutionsProject.Api.csproj"
COPY . .
WORKDIR "/src/BISolutionsProject/Systems/Api/BISolutionsProject.Api"
RUN dotnet build "BISolutionsProject.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BISolutionsProject.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BISolutionsProject.Api.dll"]
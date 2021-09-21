#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Template_TMS/Template_TMS.csproj", "Template_TMS/"]
RUN dotnet restore "Template_TMS/Template_TMS.csproj"
COPY . .
WORKDIR "/src/Template_TMS"
RUN dotnet build "Template_TMS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Template_TMS.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Template_TMS.dll"]
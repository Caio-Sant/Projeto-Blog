FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TechChallengeBlogWebApi/TechChallengeBlogWebApi.csproj", "TechChallengeBlogWebApi/"]
RUN dotnet restore "TechChallengeBlogWebApi/TechChallengeBlogWebApi.csproj"
COPY . .
WORKDIR "/src/TechChallengeBlogWebApi"
RUN dotnet build "TechChallengeBlogWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TechChallengeBlogWebApi.csproj" -c Release -o /app/publish

FROM base AS final 
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TechChallengeBlogWebApi.dll"]
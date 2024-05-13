FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TechChallengeBlogWebApp/TechChallengeBlogWebApp.csproj", "TechChallengeBlogWebApp/"]
RUN dotnet restore "TechChallengeBlogWebApp/TechChallengeBlogWebApp.csproj"
COPY . .
WORKDIR "/src/TechChallengeBlogWebApp"
RUN dotnet build "TechChallengeBlogWebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TechChallengeBlogWebApp.csproj" -c Release -o /app/publish

FROM base AS final 
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TechChallengeBlogWebApp.dll"]
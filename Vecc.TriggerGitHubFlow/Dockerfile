FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Vecc.TriggerGitHubFlow/Vecc.TriggerGitHubFlow.csproj", "Vecc.TriggerGitHubFlow/"]
RUN dotnet restore "Vecc.TriggerGitHubFlow/Vecc.TriggerGitHubFlow.csproj"
COPY . .
WORKDIR "/src/Vecc.TriggerGitHubFlow"
RUN dotnet build "Vecc.TriggerGitHubFlow.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vecc.TriggerGitHubFlow.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vecc.TriggerGitHubFlow.dll"]
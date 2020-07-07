#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM masteroleary/selenium-dotnetcore2.2-linux:v2 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
FROM masteroleary/selenium-dotnetcore2.2-linux:v2 AS build WORKDIR /src
COPY ["fill-form/fill-form.csproj", "fill-form/"]
RUN dotnet restore "fill-form/fill-form.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "MyProject.csproj" -c Prod -o /app
FROM build AS publish
RUN dotnet publish "MyProject.csproj" -c Prod -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "fill-form.dll"]
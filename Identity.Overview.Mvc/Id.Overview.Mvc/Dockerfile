#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/aspnetcore:2.0-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-sac2016 AS build
WORKDIR /src
COPY ["Id.Overview.Mvc/Id.Overview.Mvc.csproj", "Id.Overview.Mvc/"]
RUN dotnet restore "Id.Overview.Mvc/Id.Overview.Mvc.csproj"
COPY . .
WORKDIR "/src/Id.Overview.Mvc"
RUN dotnet build "Id.Overview.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Id.Overview.Mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Id.Overview.Mvc.dll"]
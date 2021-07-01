FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

COPY . /DockerConsole/
WORKDIR /DockerConsole

RUN dotnet restore
RUN dotnet publish -c release -o /appbuild --no-restore
WORKDIR /appbuild

ENTRYPOINT ["dotnet", "DockerConsole.dll"]
CMD ["Yurii"]
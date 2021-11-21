FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine

WORKDIR /app

copy . .

EXPOSE 80

ENTRYPOINT ["dotnet", "Backend.dll"]
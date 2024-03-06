# SDK image to build the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy the .csproj file and restore any dependencies (via nuget)
COPY ["Example.csproj", "./"]
RUN dotnet restore "Example.csproj"

# Copy the project files and build for release
COPY . .
RUN dotnet publish "Example.csproj" -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "Example.dll" ]
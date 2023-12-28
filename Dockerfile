FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

# Expose the port your application will run on
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# copy all the layers' csproj files into respective folders
COPY *.sln .
COPY ["./HospitalManagement.Api/HospitalManagement.Api.csproj", "src/HospitalManagement.Api/"]

# run restore over API project - this pulls restore over the dependent projects as well
RUN dotnet restore "src/HospitalManagement.Api/HospitalManagement.Api.csproj"

COPY . .

# run build over the API project
WORKDIR "/src/HospitalManagement.Api/"
RUN dotnet build -c Release -o /app/build

# run publish over the API project
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS runtime
WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT [ "dotnet", "HospitalManagement.Api.dll" ]
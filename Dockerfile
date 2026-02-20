# -----------------------------
# Stage 1: Build
# -----------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY LongestIncreasingSubset.sln ./
COPY LongestIncreasingSubset/ ./LongestIncreasingSubset/
COPY LongestIncreasingService/ ./LongestIncreasingService/

RUN dotnet restore LongestIncreasingSubset/LongestIncreasingSubset.csproj

RUN dotnet build LongestIncreasingSubset/LongestIncreasingSubset.csproj -c Release

RUN dotnet publish LongestIncreasingSubset/LongestIncreasingSubset.csproj \
    -c Release -o /app/publish /p:UseAppHost=false

# -----------------------------
# Stage 2: Runtime
# -----------------------------
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "LongestIncreasingSubset.dll"]
#Imagem para deploy de API
#Docker build -t Minimal_API:1.0.0 --target SQL .
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS BUILD
WORKDIR /usr/
COPY . .
RUN rsync -av --exclude='SQL' /SQL/ /usr/
#PARA FAZER



#Imagem para deploy de banco 
#Docker build -t minimalsqlserver:1.0.0 --target SQL .
FROM  mcr.microsoft.com/mssql/server:2022-preview-ubuntu-22.04 AS  SQL
USER root
RUN mkdir -p /usr/scripts
WORKDIR /usr/
COPY SQL /usr/scripts
COPY Start_SQL.sh /usr/scripts
EXPOSE  1433
USER mssql
ENV PATH="${PATH}:/opt/mssql-tools/bin/"


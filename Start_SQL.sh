#Execute depois da criação do container 
#sh /usr/scripts/Start_SQL.sh
for script in /usr/scripts/*.sql; do sqlcmd -S localhost  -d master -U SA -P $MSSQL_SA_PASSWORD  -i $script; done
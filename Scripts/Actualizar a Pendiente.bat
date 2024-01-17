@echo off
cd "C:\Program Files\MySQL\MySQL Shell 8.1\bin"
mysqlsh.exe --sql --uri escanerTienda@208.109.68.135:3306 --password=Ferrari1 < "C:\Users\plata\Desktop\PENDIENTE.sql"
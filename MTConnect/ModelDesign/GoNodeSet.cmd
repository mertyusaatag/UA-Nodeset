set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.MTConnect.Model.xml" -c "Opc.Ua.MTConnect.Model.csv" --o2 "MTConnect"
xcopy %1\mdc.log .\MTConnect\mdc.log /y /i
xcopy %1\mdc.warnings.log .\MTConnect\mdc.warnings.log /y /i



set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Machinery.Model.xml" -c "Opc.Ua.Machinery.Model.csv" --o2 "Machinery"
xcopy %1\mdc.log .\Machinery\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Machinery\mdc.warnings.log /y /i



set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.FDI7.Model.xml" -c "Opc.Ua.FDI7.Model.csv" --o2 "FDI7"
xcopy %1\mdc.log .\FDI7\mdc.log /y /i
xcopy %1\mdc.warnings.log .\FDI7\mdc.warnings.log /y /i

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Fdi5.Model.xml" -c "Opc.Ua.Fdi5.Model.csv" --o2 "Fdi5"
xcopy %1\mdc.log .\Fdi5\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Fdi5\mdc.warnings.log /y /i



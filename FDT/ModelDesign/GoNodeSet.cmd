set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.FDT.Model.xml" -c "Opc.Ua.FDT.Model.csv" --o2 "FDT"
xcopy %1\mdc.log .\FDT\mdc.log /y /i
xcopy %1\mdc.warnings.log .\FDT\mdc.warnings.log /y /i



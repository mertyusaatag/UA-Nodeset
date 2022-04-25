set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.CNC.Model.xml" -c "Opc.Ua.CNC.Model.csv" --o2 "CNC"
xcopy %1\mdc.log .\CNC\mdc.log /y /i
xcopy %1\mdc.warnings.log .\CNC\mdc.warnings.log /y /i



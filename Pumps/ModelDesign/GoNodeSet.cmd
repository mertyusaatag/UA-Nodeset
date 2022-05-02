set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Pumps.Model.xml" -c "Opc.Ua.Pumps.Model.csv" --o2 "Pumps"
xcopy %1\mdc.log .\Pumps\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Pumps\mdc.warnings.log /y /i



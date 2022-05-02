set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PLCopen.Model.xml" -c "Opc.Ua.PLCopen.Model.csv" --o2 "PLCopen"
xcopy %1\mdc.log .\PLCopen\mdc.log /y /i
xcopy %1\mdc.warnings.log .\PLCopen\mdc.warnings.log /y /i



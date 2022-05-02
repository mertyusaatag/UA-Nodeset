set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.OPENSCS.Model.xml" -c "Opc.Ua.OPENSCS.Model.csv" --o2 "OPENSCS"
xcopy %1\mdc.log .\OPENSCS\mdc.log /y /i
xcopy %1\mdc.warnings.log .\OPENSCS\mdc.warnings.log /y /i



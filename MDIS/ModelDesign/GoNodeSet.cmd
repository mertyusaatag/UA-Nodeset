set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.MDIS.Model.xml" -c "Opc.Ua.MDIS.Model.csv" --o2 "MDIS"
xcopy %1\mdc.log .\MDIS\mdc.log /y /i
xcopy %1\mdc.warnings.log .\MDIS\mdc.warnings.log /y /i



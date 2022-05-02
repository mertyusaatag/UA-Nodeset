set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.DEXPI.Model.xml" -c "Opc.Ua.DEXPI.Model.csv" --o2 "DEXPI"
xcopy %1\mdc.log .\DEXPI\mdc.log /y /i
xcopy %1\mdc.warnings.log .\DEXPI\mdc.warnings.log /y /i



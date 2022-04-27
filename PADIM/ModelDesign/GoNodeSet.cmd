set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.IRDI.Model.xml" -c "Opc.Ua.IRDI.Model.csv" --o2 "IRDI"
xcopy %1\mdc.log .\IRDI\mdc.log /y /i
xcopy %1\mdc.warnings.log .\IRDI\mdc.warnings.log /y /i

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PADIM.Model.xml" -c "Opc.Ua.PADIM.Model.csv" --o2 "PADIM"
xcopy %1\mdc.log .\PADIM\mdc.log /y /i
xcopy %1\mdc.warnings.log .\PADIM\mdc.warnings.log /y /i



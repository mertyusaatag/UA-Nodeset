set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.POWERLINK.Model.xml" -c "Opc.Ua.POWERLINK.Model.csv" --o2 "POWERLINK"
xcopy %1\mdc.log .\POWERLINK\mdc.log /y /i
xcopy %1\mdc.warnings.log .\POWERLINK\mdc.warnings.log /y /i



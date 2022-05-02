set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Di.Model.xml" -c "Opc.Ua.Di.Model.csv" --o2 "Di"
xcopy %1\mdc.log .\Di\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Di\mdc.warnings.log /y /i



set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Safety.Model.xml" -c "Opc.Ua.Safety.Model.csv" --o2 "Safety"
xcopy %1\mdc.log .\Safety\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Safety\mdc.warnings.log /y /i



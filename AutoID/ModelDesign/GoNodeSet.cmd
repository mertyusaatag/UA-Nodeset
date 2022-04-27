set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.AutoID.Model.xml" -c "Opc.Ua.AutoID.Model.csv" --o2 "AutoID"
xcopy %1\mdc.log .\AutoID\mdc.log /y /i
xcopy %1\mdc.warnings.log .\AutoID\mdc.warnings.log /y /i



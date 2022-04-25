set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PnEm.Model.xml" -c "Opc.Ua.PnEm.Model.csv" --o2 "PnEm"
xcopy %1\mdc.log .\PnEm\mdc.log /y /i
xcopy %1\mdc.warnings.log .\PnEm\mdc.warnings.log /y /i



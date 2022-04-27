set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.ISA95.Model.xml" -c "Opc.Ua.ISA95.Model.csv" --o2 "ISA95"
xcopy %1\mdc.log .\ISA95\mdc.log /y /i
xcopy %1\mdc.warnings.log .\ISA95\mdc.warnings.log /y /i



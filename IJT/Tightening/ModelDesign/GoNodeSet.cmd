set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Ijt.Tightening.Model.xml" -c "Opc.Ua.Ijt.Tightening.Model.csv" --o2 "Ijt.Tightening"
xcopy %1\mdc.log .\Ijt.Tightening\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Ijt.Tightening\mdc.warnings.log /y /i



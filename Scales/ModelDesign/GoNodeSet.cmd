set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Scales.Model.xml" --cg "Opc.Ua.Scales.Model.csv" --o2 "Scales"
xcopy %1\mdc.log .\Scales\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Scales\mdc.warnings.log /y /i

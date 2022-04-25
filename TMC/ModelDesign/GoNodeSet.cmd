set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.TMC.Model.xml" --cg "Opc.Ua.TMC.Model.csv" --o2 "TMC"
xcopy %1\mdc.log .\TMC\mdc.log /y /i
xcopy %1\mdc.warnings.log .\TMC\mdc.warnings.log /y /i

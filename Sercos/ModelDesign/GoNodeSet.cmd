set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Sercos.Model.xml" --cg "Opc.Ua.Sercos.Model.csv" --o2 "Sercos"
xcopy %1\mdc.log .\Sercos\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Sercos\mdc.warnings.log /y /i

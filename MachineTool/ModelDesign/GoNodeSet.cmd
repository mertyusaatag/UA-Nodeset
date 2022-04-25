set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.MachineTool.Model.xml" -c "Opc.Ua.MachineTool.Model.csv" --o2 "MachineTool"
xcopy %1\mdc.log .\MachineTool\mdc.log /y /i
xcopy %1\mdc.warnings.log .\MachineTool\mdc.warnings.log /y /i



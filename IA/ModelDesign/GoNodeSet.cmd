set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.IA.Model.xml" -c "Opc.Ua.IA.Model.csv" --o2 "IA"
xcopy %1\mdc.log .\IA\mdc.log /y /i
xcopy %1\mdc.warnings.log .\IA\mdc.warnings.log /y /i



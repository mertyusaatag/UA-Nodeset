set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.I4AAS.Model.xml" -c "Opc.Ua.I4AAS.Model.csv" --o2 "I4AAS"
xcopy %1\mdc.log .\I4AAS\mdc.log /y /i
xcopy %1\mdc.warnings.log .\I4AAS\mdc.warnings.log /y /i



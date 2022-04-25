set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.CAS.Model.xml" -c "Opc.Ua.CAS.Model.csv" --o2 "CAS"
xcopy %1\mdc.log .\CAS\mdc.log /y /i
xcopy %1\mdc.warnings.log .\CAS\mdc.warnings.log /y /i



set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PackML.Model.xml" -c "Opc.Ua.PackML.Model.csv" --o2 "PackML"
xcopy %1\mdc.log .\PackML\mdc.log /y /i
xcopy %1\mdc.warnings.log .\PackML\mdc.warnings.log /y /i



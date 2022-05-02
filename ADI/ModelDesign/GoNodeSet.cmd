set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Adi.Model.xml" -c "Opc.Ua.Adi.Model.csv" --o2 "ADI"
xcopy %1\mdc.log .\ADI\mdc.log /y /i
xcopy %1\mdc.warnings.log .\ADI\mdc.warnings.log /y /i



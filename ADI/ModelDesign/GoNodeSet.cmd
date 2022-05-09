set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "..\OpcUaAdiModel.xml" -c "..\OpcUaAdiModel.csv" --o2 "ADI-OldModel "
xcopy %1\mdc.log .\ADI-OldModel\mdc.log /y /i
xcopy %1\mdc.warnings.log .\ADI-OldModel\mdc.warnings.log /y /i



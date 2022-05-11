set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Gds.Model.xml" -c "..\OpcUaGdsModel.csv" --o2 "GDS"
xcopy %1\mdc.log .\GDS\mdc.log /y /i
xcopy %1\mdc.warnings.log .\GDS\mdc.warnings.log /y /i



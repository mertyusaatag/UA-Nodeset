set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "..\Opc.Ua.PlasticsRubber.LDS.NodeSet2.bsd" -g "..\NodeIds.csv" --o2 "LDS"
xcopy %1\mdc.log .\LDS\mdc.log /y /i
xcopy %1\mdc.warnings.log .\LDS\mdc.warnings.log /y /i

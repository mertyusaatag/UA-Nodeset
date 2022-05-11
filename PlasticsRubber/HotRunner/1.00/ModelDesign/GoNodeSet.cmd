set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.HotRunner.Model.xml" -g "HotRunner.Model.csv" --o2 "HotRunner"
xcopy %1\mdc.log .\HotRunner\mdc.log /y /i
xcopy %1\mdc.warnings.log .\HotRunner\mdc.warnings.log /y /i

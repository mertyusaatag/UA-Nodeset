set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.MeltPump.Model.xml" -g "MeltPump.Model.csv" --o2 "MeltPump"
xcopy %1\mdc.log .\MeltPump\mdc.log /y /i
xcopy %1\mdc.warnings.log .\MeltPump\mdc.warnings.log /y /i

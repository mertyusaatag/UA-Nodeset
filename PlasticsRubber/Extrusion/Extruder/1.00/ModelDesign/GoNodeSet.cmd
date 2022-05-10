set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.Extruder.Model.xml" -g "Extruder.Model.csv" --o2 "Extruder"
xcopy %1\mdc.log .\Extruder\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Extruder\mdc.warnings.log /y /i

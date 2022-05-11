set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.ExtrusionLine.Model.xml" -g "ExtrusionLine.Model.csv" --o2 "ExtrusionLine"
xcopy %1\mdc.log .\ExtrusionLine\mdc.log /y /i
xcopy %1\mdc.warnings.log .\ExtrusionLine\mdc.warnings.log /y /i

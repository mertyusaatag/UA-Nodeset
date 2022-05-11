set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.Cutter.Model.xml" -g "Cutter.Model.csv" --o2 "Cutter"
xcopy %1\mdc.log .\Cutter\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Cutter\mdc.warnings.log /y /i

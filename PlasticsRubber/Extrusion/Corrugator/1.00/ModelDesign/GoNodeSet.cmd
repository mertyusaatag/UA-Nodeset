set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.Corrugator.Model.xml" -g "Corrugator.Model.csv" --o2 "Corrugator"
xcopy %1\mdc.log .\Corrugator\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Corrugator\mdc.warnings.log /y /i

set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.Filter.Model.xml" -g "Filter.Model.csv" --o2 "Filter"
xcopy %1\mdc.log .\Filter\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Filter\mdc.warnings.log /y /i

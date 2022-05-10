set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.Calender.Model.xml" -g "Opc.Ua.PlasticsRubber.Extrusion.Calender.Model.csv" --o2 "Calender"
xcopy %1\mdc.log .\Calender\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Calender\mdc.warnings.log /y /i

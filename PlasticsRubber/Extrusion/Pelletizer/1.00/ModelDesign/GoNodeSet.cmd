set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.Pelletizer.Model.xml" -g "Pelletizer.Model.csv" --o2 "Pelletizer"
xcopy %1\mdc.log .\Pelletizer\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Pelletizer\mdc.warnings.log /y /i

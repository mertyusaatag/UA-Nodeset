set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.Die.Model.xml" -g "Die.Model.csv" --o2 "Die"
xcopy %1\mdc.log .\Die\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Die\mdc.warnings.log /y /i

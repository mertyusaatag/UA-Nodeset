set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.GeneralTypes.Model.xml" -g "GeneralTypes.Model.csv" --o2 "GeneralTypes"
xcopy %1\mdc.log .\GeneralTypes\mdc.log /y /i
xcopy %1\mdc.warnings.log .\GeneralTypes\mdc.warnings.log /y /i

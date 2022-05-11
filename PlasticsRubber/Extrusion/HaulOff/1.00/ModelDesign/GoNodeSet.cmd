set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.HaulOff.Model.xml" -g "HaulOff.Model.csv" --o2 "HaulOff"
xcopy %1\mdc.log .\HaulOff\mdc.log /y /i
xcopy %1\mdc.warnings.log .\HaulOff\mdc.warnings.log /y /i

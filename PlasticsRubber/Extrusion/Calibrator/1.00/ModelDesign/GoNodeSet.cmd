set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.Extrusion.Calibrator.Model.xml" -g "Calibrator.Model.csv" --o2 "Calibrator"
xcopy %1\mdc.log .\Calibrator\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Calibrator\mdc.warnings.log /y /i

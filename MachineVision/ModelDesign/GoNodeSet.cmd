set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.MachineVision.Model.xml" -c "Opc.Ua.MachineVision.Model.csv" --o2 "MachineVision"
xcopy %1\mdc.log .\MachineVision\mdc.log /y /i
xcopy %1\mdc.warnings.log .\MachineVision\mdc.warnings.log /y /i



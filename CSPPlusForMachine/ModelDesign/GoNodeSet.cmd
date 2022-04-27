set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.CSPPlusForMachine.Model.xml" -c "Opc.Ua.CSPPlusForMachine.Model.csv" --o2 "CSPPlusForMachine"
xcopy %1\mdc.log .\CSPPlusForMachine\mdc.log /y /i
xcopy %1\mdc.warnings.log .\CSPPlusForMachine\mdc.warnings.log /y /i



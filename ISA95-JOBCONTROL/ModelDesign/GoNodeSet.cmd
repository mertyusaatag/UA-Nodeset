set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.ISA95-JOBCONTROL.Model.xml" -c "Opc.Ua.ISA95-JOBCONTROL.Model.csv" --o2 "ISA95-JOBCONTROL"
xcopy %1\mdc.log .\ISA95-JOBCONTROL\mdc.log /y /i
xcopy %1\mdc.warnings.log .\ISA95-JOBCONTROL\mdc.warnings.log /y /i



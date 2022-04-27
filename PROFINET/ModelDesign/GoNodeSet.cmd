set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PROFINET.Model.xml" -c "Opc.Ua.PROFINET.Model.xml" --o2 "PROFINET"
xcopy %1\mdc.log .\PROFINET\mdc.log /y /i
xcopy %1\mdc.warnings.log .\PROFINET\mdc.warnings.log /y /i



set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.AMLBaseTypes.Model.xml" -c "Opc.Ua.AMLBaseTypes.Model.csv" --o2 "AMLBASETYPES"
xcopy %1\mdc.log .\AMLBASETYPES\mdc.log /y /i
xcopy %1\mdc.warnings.log .\AMLBASETYPES\mdc.warnings.log /y /i

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.AMLLibraries.Model.xml" -c "Opc.Ua.AMLLibraries.Model.csv" --o2 "AMLLibraries"
xcopy %1\mdc.log .\AMLLibraries\mdc.log /y /i
xcopy %1\mdc.warnings.log .\AMLLibraries\mdc.warnings.log /y /i



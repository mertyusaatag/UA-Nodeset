set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.IEC61850-7-3.Model.xml" -c "Opc.Ua.IEC61850-7-3.csv" --o2 "IEC61850-7-3"
xcopy %1\mdc.log .\IEC61850-7-3\mdc.log /y /i
xcopy %1\mdc.warnings.log .\IEC61850-7-3\mdc.warnings.log /y /i

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.IEC61850-6.Model.xml" -c "Opc.Ua.IEC61850-6.csv" --o2 "IEC61850-6"
xcopy %1\mdc.log .\IEC61850-6\mdc.log /y /i
xcopy %1\mdc.warnings.log .\IEC61850-6\mdc.warnings.log /y /i

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.IEC61850-7-4.Model.xml" -c "Opc.Ua.IEC61850-7-4.csv" --o2 "IEC61850-7-4"
xcopy %1\mdc.log .\IEC61850-7-4\mdc.log /y /i
xcopy %1\mdc.warnings.log .\IEC61850-7-4\mdc.warnings.log /y /i


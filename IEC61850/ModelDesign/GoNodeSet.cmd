set COMPILER=OOI.ModelCompilerUI

del %1\OOIMC.log  /q
del %1\OOIMC.warnings.log /q
"%1\%COMPILER%" -d2 "Opc.Ua.IEC61850-7-3.Model.xml" -cg "Opc.Ua.IEC61850-7-3.csv" -o "IEC61850-7-3"
xcopy %1\OOIMC.log .\IEC61850-7-3\OOIMC.log /y /i
xcopy %1\OOIMC.warnings.log .\IEC61850-7-3\OOIMC.warnings.log /y /i

del %1\OOIMC.log  /q
del %1\OOIMC.warnings.log /q
"%1\%COMPILER%" -d2 "Opc.Ua.IEC61850-6.Model.xml" -cg "Opc.Ua.IEC61850-6.csv" -o "IEC61850-6"
xcopy %1\OOIMC.log .\IEC61850-6\OOIMC.log /y /i
xcopy %1\OOIMC.warnings.log .\IEC61850-6\OOIMC.warnings.log /y /i

del %1\OOIMC.log  /q
del %1\OOIMC.warnings.log /q
"%1\%COMPILER%" -d2 "Opc.Ua.IEC61850-7-4.Model.xml" -cg "Opc.Ua.IEC61850-7-4.csv" -o "IEC61850-7-4"
xcopy %1\OOIMC.log .\IEC61850-7-4\OOIMC.log /y /i
xcopy %1\OOIMC.warnings.log .\IEC61850-7-4\OOIMC.warnings.log /y /i


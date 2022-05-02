set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.Weihenstephan.Model.xml" --cg "Opc.Ua.Weihenstephan.Model.xml" --o2 "Weihenstephan"
xcopy %1\mdc.log .\Weihenstephan\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Weihenstephan\mdc.warnings.log /y /i

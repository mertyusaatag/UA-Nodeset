set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.IOLink.Model.xml" --cg "Opc.Ua.IOLink.Model.xml" --o2 "IOLink"
xcopy %1\mdc.log .\IOLink\mdc.log /y /i
xcopy %1\mdc.warnings.log .\IOLink\mdc.warnings.log /y /i



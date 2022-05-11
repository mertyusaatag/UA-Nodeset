set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.PlasticsRubber.IMM2MES.NodeSet2.xml" -g "IMM2MES.Model.csv" --o2 "IMM2MES"
xcopy %1\mdc.log .\IMM2MES\mdc.log /y /i
xcopy %1\mdc.warnings.log .\IMM2MES\mdc.warnings.log /y /i

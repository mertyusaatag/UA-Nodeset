set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "opc.Ua.Robotics.Model.xml" -c "opc.Ua.Robotics.Model.csv" --o2 "Pumps"
xcopy %1\mdc.log .\Robotics\mdc.log /y /i
xcopy %1\mdc.warnings.log .\Robotics\mdc.warnings.log /y /i



set COMPILER=mdc

del %1\mdc.log  /q
del %1\mdc.warnings.log /q
"%1\%COMPILER%" compile --d2 "Opc.Ua.CommercialKitchenEquipment.Model.xml" -c "Opc.Ua.CommercialKitchenEquipment.Model.csv" --o2 "CommercialKitchenEquipment"
xcopy %1\mdc.log .\CommercialKitchenEquipment\mdc.log /y /i
xcopy %1\mdc.warnings.log .\CommercialKitchenEquipment\mdc.warnings.log /y /i



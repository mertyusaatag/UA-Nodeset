:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\Opc.Ua.CNC.NodeSet.xml" -e "Opc.Ua.CNC.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/CNC"
xcopy "%1\asp.log" "asp.log" /y
xcopy "%1\asp.warnings.log" ".\asp.warnings.log" /y /i

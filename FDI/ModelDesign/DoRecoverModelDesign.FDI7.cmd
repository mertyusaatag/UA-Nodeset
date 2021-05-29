:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\..\DI\Opc.Ua.Di.NodeSet2.xml" "..\Opc.Ua.FDI7.NodeSet2.xml" -e "Opc.Ua.FDI7.Model.xml" -s XMLstylesheet -n "http://fdi-cooperation.com/OPCUA/FDI7/"
xcopy %1\asp.log asp.FDI7.log /y
xcopy %1\asp.warnings.log .\asp.warnings.FDI7.log /y /i


